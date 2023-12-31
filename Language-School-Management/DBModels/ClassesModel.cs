﻿using System.Collections.Generic;
using System.Data.SQLite;

namespace Language_School_Management
{
    public class Classes : BaseDB
    {
        public static void AddClass(
            string className,
            string startTime,
            string endTime,
            int sessions,
            string teacherName,
            string teacherNcode
            )
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    INSERT INTO classes(className, startTime, endTime, sessions, teacherName, teacherNcode)
                    VALUES (@className, @startTime, @endTime, @sessions, @teacherName, @teacherNcode);";

                cmd.Parameters.AddWithValue("className", className);
                cmd.Parameters.AddWithValue("startTime", startTime);
                cmd.Parameters.AddWithValue("endTime", endTime);
                cmd.Parameters.AddWithValue("sessions", sessions);
                cmd.Parameters.AddWithValue("teacherName", teacherName);
                cmd.Parameters.AddWithValue("teacherNcode", teacherNcode);

                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteClass(int classCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM classes WHERE classCode=@classCode; UPDATE students SET classCode=0 WHERE classCode=@classCode";
                cmd.Parameters.AddWithValue("classCode", classCode);
                cmd.ExecuteNonQuery();
            }
        }


        public static void UpdateClass(
            int classCode,
            string className,
            string startTime,
            string endTime,
            int sessions,
            string teacherName,
            string teacherNcode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    UPDATE classes
                    SET className=@className, startTime=@startTime,
                        endTime=@endTime, sessions=@sessions, teacherName=@teacherName, teacherNcode=@teacherNcode
                    WHERE classCode=@classCode";

                cmd.Parameters.AddWithValue("classCode", classCode);
                cmd.Parameters.AddWithValue("className", className);
                cmd.Parameters.AddWithValue("startTime", startTime);
                cmd.Parameters.AddWithValue("endTime", endTime);
                cmd.Parameters.AddWithValue("sessions", sessions);
                cmd.Parameters.AddWithValue("teacherName", teacherName);
                cmd.Parameters.AddWithValue("teacherNcode", teacherNcode);

                cmd.ExecuteNonQuery();
            }
        }
        public static bool isClassExists(string teacherNcode, string startTime, string endTime)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT 1 FROM classes WHERE teacherNcode=@teacherNcode AND startTime=@startTime AND endTime=@endTime;";

                cmd.Parameters.AddWithValue("teacherNcode", teacherNcode);
                cmd.Parameters.AddWithValue("startTime", startTime);
                cmd.Parameters.AddWithValue("endTime", endTime);

                return cmd.ExecuteScalar() != null ? true : false;
            }
        }

        public static bool isClassExists(int classCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT 1 FROM classes WHERE classCode=@classCode;";

                cmd.Parameters.AddWithValue("classCode", classCode);

                return cmd.ExecuteScalar() != null ? true : false;
            }
        }

        public static Dictionary<string, object> GetClass(int classCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM classes WHERE classCode=@classCode";
                cmd.Parameters.AddWithValue("classCode", classCode);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> output = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            output.Add(reader.GetName(i), reader.GetValue(i));
                        }

                        return output;
                    }
                }

                return null;
            }
        }
        public static List<Dictionary<string, object>> GetClasses()
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM classes";

                List<Dictionary<string, object>> classes = new List<Dictionary<string, object>>();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Dictionary<string, object> output = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            output.Add(reader.GetName(i), reader[i]);
                        }

                        classes.Add(output);

                    }

                }

                return classes;
            }
        }
        public static List<Dictionary<string, object>> GetClassStudents(int classCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT firstName,lastName,fatherName,nCode,phoneNumber,parentPhone
                    FROM students WHERE classCode=@classCode
                ";

                cmd.Parameters.AddWithValue("classCode", classCode);

                List<Dictionary<string, object>> students = new List<Dictionary<string, object>>();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Dictionary<string, object> output = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            output.Add(reader.GetName(i), reader[i]);
                        }

                        students.Add(output);

                    }

                }

                return students;
            }
        }

        public static List<Dictionary<string, object>> GetNotAddedStudents()
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT firstName,lastName,nCode FROM students WHERE classCode=0
                ";

                List<Dictionary<string, object>> students = new List<Dictionary<string, object>>();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Dictionary<string, object> output = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            output.Add(reader.GetName(i), reader[i]);
                        }

                        students.Add(output);

                    }

                }

                return students;

            }
        }

        public static bool isStudentInClass(int classCode, string nCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT 1 FROM students WHERE nCode=@nCode AND classCode=@classCode;";

                cmd.Parameters.AddWithValue("nCode", nCode);
                cmd.Parameters.AddWithValue("classCode", classCode);

                return cmd.ExecuteScalar() != null ? true : false;
            }
        }

        public static void AddStudentToClass(int classCode, string nCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE students SET classCode=@classCode WHERE nCode=@nCode";

                cmd.Parameters.AddWithValue("classCode", classCode);
                cmd.Parameters.AddWithValue("nCode", nCode);

                cmd.ExecuteNonQuery();
            }
        }

        public static void DelStudentFromClass(string nCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE students SET classCode=0 WHERE nCode=@nCode";

                cmd.Parameters.AddWithValue("nCode", nCode);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
