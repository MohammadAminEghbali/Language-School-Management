using System.Collections.Generic;
using System.Data.SQLite;

namespace Language_School_Management
{
    public class Teachers : BaseDB
    {
        public static void AddTeacher(
            string firstName,
            string lastName,
            string fatherName,
            string nCode,
            string certificate,
            string phoneNumber,
            string homeAddress)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    INSERT INTO teachers VALUES(
                        @firstName, @lastName, @fatherName, @nCode, @certificate, @phoneNumber, @homeAddress
                    );
                ";

                cmd.Parameters.AddWithValue("firstName", firstName);
                cmd.Parameters.AddWithValue("lastName", lastName);
                cmd.Parameters.AddWithValue("fatherName", fatherName);
                cmd.Parameters.AddWithValue("nCode", nCode);
                cmd.Parameters.AddWithValue("phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("certificate", certificate);
                cmd.Parameters.AddWithValue("homeAddress", homeAddress);

                /*cmd.Parameters.AddWithValue("birthDate", birthDate);*/
                /*cmd.Parameters.AddWithValue("signDate", signDate);*/

                /*var parameters = new { firstName, lastName, fatherName, birthDate, phoneNumber, homePhone, parentPhone, homeAddress };

                foreach (PropertyInfo parameter in parameters.GetType().GetProperties())
                {
                    cmd.Parameters.AddWithValue(parameter.Name, parameter.GetValue(parameters, null));
                }*/

                cmd.ExecuteNonQuery();
            }
        }

        public static void updateTeacher(
            string nCode,
            string firstName,
            string lastName,
            string fatherName,
            string certificate,
            string phoneNumber,
            string homeAddress)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    UPDATE teachers SET
                    firstName=@firstName, lastName=@lastName, fatherName=@fatherName, 
                    certificate=@certificate, phoneNumber=@phoneNumber, homeAddress=@homeAddress
                    WHERE nCode=@nCode;
                ";

                cmd.Parameters.AddWithValue("firstName", firstName);
                cmd.Parameters.AddWithValue("lastName", lastName);
                cmd.Parameters.AddWithValue("fatherName", fatherName);
                cmd.Parameters.AddWithValue("nCode", nCode);
                cmd.Parameters.AddWithValue("phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("certificate", certificate);
                cmd.Parameters.AddWithValue("homeAddress", homeAddress);

                /*cmd.Parameters.AddWithValue("birthDate", birthDate);*/
                /*cmd.Parameters.AddWithValue("signDate", signDate);*/

                /*var parameters = new { firstName, lastName, fatherName, birthDate, phoneNumber, homePhone, parentPhone, homeAddress };

                foreach (PropertyInfo parameter in parameters.GetType().GetProperties())
                {
                    cmd.Parameters.AddWithValue(parameter.Name, parameter.GetValue(parameters, null));
                }*/

                cmd.ExecuteNonQuery();
            }
        }

        public static bool isTeacherExists(string nCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT 1 FROM teachers WHERE nCode=@nCode";
                cmd.Parameters.AddWithValue("nCode", nCode);

                return cmd.ExecuteScalar() != null ? true : false;
            }
        }

        public static void delTeacher(string nCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM teachers WHERE nCode=@nCode";
                cmd.Parameters.AddWithValue("nCode", nCode);
                cmd.ExecuteNonQuery();
            }

        }
        public static Dictionary<string, string> getTeacher(string nCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM teachers WHERE nCode=@nCode";
                cmd.Parameters.AddWithValue("nCode", nCode);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, string> output = new Dictionary<string, string>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            output.Add(reader.GetName(i), reader.GetString(i));
                        }

                        return output;
                    }
                }

                return null;
            }
        }

        public static List<Dictionary<string, object>> getTeachers()
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM teachers";

                List<Dictionary<string, object>> teachers = new List<Dictionary<string, object>>();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Dictionary<string, object> output = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            output.Add(reader.GetName(i), reader[i]);
                        }

                        teachers.Add(output);

                    }

                }

                return teachers;
            }
        }
    }
}
