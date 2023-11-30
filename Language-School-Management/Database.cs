using System.Data.SQLite;
using System.Reflection;
using System.Windows.Forms;

namespace Language_School_Management
{
    public class Database
    {
        private static SQLiteConnection conn;
        public Database()
        {
            conn = new SQLiteConnection("Data source=data.db");
            conn.Open();
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS students (
                        firstName TEXT, lastName TEXT, fatherName TEXT, nCode TEXT, birthDate TEXT,
                        phoneNumber TEXT, homePhone TEXT, parentPhone TEXT, homeAddress TEXT
                    );

                    CREATE TABLE IF NOT EXISTS teachers (name TEXT);
                ";
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddStudent(
            string firstName,
            string lastName,
            string fatherName,
            string nCode,
            string birthDate,
            string phoneNumber,
            string homePhone,
            string parentPhone,
            string homeAddress)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    INSERT INTO students VALUES(
                        @firstName, @lastName, @fatherName, @nCode, @birthDate, @phoneNumber, @homePhone, @parentPhone, @homeAddress
                    );
                ";

                cmd.Parameters.AddWithValue("firstName", firstName);
                cmd.Parameters.AddWithValue("lastName", lastName);
                cmd.Parameters.AddWithValue("fatherName", fatherName);
                cmd.Parameters.AddWithValue("nCode", nCode);
                cmd.Parameters.AddWithValue("birthDate", birthDate);
                cmd.Parameters.AddWithValue("phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("homePhone", homePhone);
                cmd.Parameters.AddWithValue("parentPhone", parentPhone);
                cmd.Parameters.AddWithValue("homeAddress", homeAddress);

                /*var parameters = new { firstName, lastName, fatherName, birthDate, phoneNumber, homePhone, parentPhone, homeAddress };

                foreach (PropertyInfo parameter in parameters.GetType().GetProperties())
                {
                    cmd.Parameters.AddWithValue(parameter.Name, parameter.GetValue(parameters, null));
                }*/

                cmd.ExecuteNonQuery();
            }
        }
    }
}
