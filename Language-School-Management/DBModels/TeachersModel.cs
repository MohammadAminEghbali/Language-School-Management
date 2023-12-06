using System.Collections.Generic;
using System.Data.SQLite;

namespace Language_School_Management
{
    public class Teachers : BaseDB
    {
        public static void AddStudent(
            string firstName,
            string lastName,
            string fatherName,
            string nCode,
            string phoneNumber,
            string homePhone,
            string parentPhone,
            string homeAddress)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            INSERT INTO students VALUES(
                @firstName, @lastName, @fatherName, @nCode, @phoneNumber, @homePhone, @parentPhone, @homeAddress
            );
        ";

                cmd.Parameters.AddWithValue("firstName", firstName);
                cmd.Parameters.AddWithValue("lastName", lastName);
                cmd.Parameters.AddWithValue("fatherName", fatherName);
                cmd.Parameters.AddWithValue("nCode", nCode);
                /*cmd.Parameters.AddWithValue("birthDate", birthDate);*/
                cmd.Parameters.AddWithValue("phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("homePhone", homePhone);
                cmd.Parameters.AddWithValue("parentPhone", parentPhone);
                cmd.Parameters.AddWithValue("homeAddress", homeAddress);
                /*cmd.Parameters.AddWithValue("signDate", signDate);*/

                /*var parameters = new { firstName, lastName, fatherName, birthDate, phoneNumber, homePhone, parentPhone, homeAddress };

                foreach (PropertyInfo parameter in parameters.GetType().GetProperties())
                {
                    cmd.Parameters.AddWithValue(parameter.Name, parameter.GetValue(parameters, null));
                }*/

                cmd.ExecuteNonQuery();
            }
        }

        public static bool isStudentExists(string nCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT 1 FROM students WHERE nCode=@nCode";
                cmd.Parameters.AddWithValue("nCode", nCode);

                return cmd.ExecuteScalar() != null ? true : false;
            }
        }

        public static void delStudent(string nCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM students WHERE nCode=@nCode";
                cmd.Parameters.AddWithValue("nCode", nCode);
                cmd.ExecuteNonQuery();
            }

        }
        public static Dictionary<string, string> getStudent(string nCode)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM students WHERE nCode=@nCode";
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

        public static List<Dictionary<string, object>> getStudents()
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM students";

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
    }
}
