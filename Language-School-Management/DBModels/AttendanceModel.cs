using System.Collections.Generic;
using System.Data.SQLite;

namespace Language_School_Management
{
    public class Attendance : BaseDB
    {
        public static void AddStudent(
            int classCode,
            int sessionNumber,
            string sessionDate,
            string studentNcode,
            int status
            )
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    INSERT INTO attendance(classCode, sessionNumber, sessionDate, studentNcode, status)
                    VALUES (@classCode, @sessionNumber, @sessionDate, @studentNcode, @status);";

                cmd.Parameters.AddWithValue("classCode", classCode);
                cmd.Parameters.AddWithValue("sessionNumber", sessionNumber);
                cmd.Parameters.AddWithValue("sessionDate", sessionDate);
                cmd.Parameters.AddWithValue("studentNcode", studentNcode);
                cmd.Parameters.AddWithValue("status", status);

                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateStudentStatus(int classCode, int sessionNumber, string sessionDate, string studentNcode, int status)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    UPDATE attendance SET sessionDate=@sessionDate, status=@status
                    WHERE classCode=@classCode AND sessionNumber=@sessionNumber AND studentNcode=@studentNcode";

                cmd.Parameters.AddWithValue("classCode", classCode);
                cmd.Parameters.AddWithValue("sessionNumber", sessionNumber);
                cmd.Parameters.AddWithValue("sessionDate", sessionDate);
                cmd.Parameters.AddWithValue("studentNcode", studentNcode);
                cmd.Parameters.AddWithValue("status", status);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Dictionary<string, object>> GetClassAttendance(int classCode, int sessionNumber)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM attendance WHERE classCode=@classCode AND sessionNumber=@sessionNumber";
                cmd.Parameters.AddWithValue("classCode", classCode);
                cmd.Parameters.AddWithValue("sessionNumber", sessionNumber);

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

        public static int GetClassPassedSessions(int classCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT COUNT(DISTINCT sessionNumber) AS sessionCount
                    FROM attendance
                    WHERE classCode=@classCode
                    GROUP BY classCode;";

                cmd.Parameters.AddWithValue("classCode", classCode);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }

                }
            }
            
            return 0;
        }
    }
}
