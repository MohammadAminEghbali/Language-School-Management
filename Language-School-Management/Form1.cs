﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace Language_School_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            PersianCalendar calender = new PersianCalendar();
            DatenTime.Text = $@"{calender.GetYear(time).ToString()}/{calender.GetMonth(time).ToString()}/{calender.GetDayOfMonth(time).ToString()} | {calender.GetHour(time).ToString("D2")}:{calender.GetMinute(time).ToString("D2")}:{calender.GetSecond(time).ToString("D2")}";
        }


        private void students_Click(object sender, EventArgs e)
        {
            studentsManageForm studentsManageForm = new studentsManageForm();
            studentsManageForm.ShowDialog();
        }

        private void students_MouseEnter(object sender, EventArgs e)
        {
            // students.UseVisualStyleBackColor = false;
            // students.BackColor = Color.;
            //students.ForeColor = Color.White;
        }

        private void students_MouseLeave(object sender, EventArgs e)
        {
            //students.UseVisualStyleBackColor = true;
            // students.ForeColor = Color.Black;
        }

        private void teachers_Click(object sender, EventArgs e)
        {
            teachersManageForm teachersManageForm = new teachersManageForm();
            teachersManageForm.ShowDialog();
        }

        private void classes_Click(object sender, EventArgs e)
        {
            ClassManageForm classManageForm = new ClassManageForm();
            classManageForm.ShowDialog();
        }

        private void attendance_Click(object sender, EventArgs e)
        {
            attendanceForm attendanceform = new attendanceForm();

            attendanceform.ShowDialog();
        }
    }
}
