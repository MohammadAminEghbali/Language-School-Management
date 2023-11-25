using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Language_School_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void DatenTime_Click(object sender, EventArgs e)
        {


        }

        private void Home_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=hello.db");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS test(name TEXT);";
            cmd.ExecuteNonQuery();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            PersianCalendar calender = new PersianCalendar();
            DatenTime.Text = $@"{calender.GetYear(time).ToString()}/{calender.GetMonth(time).ToString()}/{calender.GetDayOfMonth(time).ToString()} | {calender.GetHour(time).ToString("D2")}:{calender.GetMinute(time).ToString("D2")}:{calender.GetSecond(time).ToString("D2")}";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
