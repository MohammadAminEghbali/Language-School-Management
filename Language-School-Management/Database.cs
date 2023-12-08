using System.Data.SQLite;

namespace Language_School_Management
{
    public class BaseDB
    {
        internal static SQLiteConnection conn;
    }


    public class Database : BaseDB
    {
        public Database()
        {
            conn = new SQLiteConnection("Data source=data.db");
            conn.Open();
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS students (
                        firstName TEXT, lastName TEXT, fatherName TEXT, nCode TEXT,
                        phoneNumber TEXT, homePhone TEXT, parentPhone TEXT, homeAddress TEXT
                    );

                    CREATE TABLE IF NOT EXISTS teachers (
                        firstName TEXT, lastName TEXT, fatherName TEXT, nCode TEXT,
                        certificate TEXT, phoneNumber TEXT, homeAddress TEXT
                    );
                ";
                cmd.ExecuteNonQuery();
            }
        }


    }
}
