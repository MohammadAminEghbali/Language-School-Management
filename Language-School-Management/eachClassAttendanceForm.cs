using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Language_School_Management
{
    public partial class eachClassAttendanceForm : Form
    {
        private int classCode;
        public eachClassAttendanceForm(int classCode)
        {
            InitializeComponent();
            this.classCode = classCode;
        }

        private void eachClassAttendanceForm_Load(object sender, EventArgs e)
        {
            //studentsDataGridView.Rows.Clear();


            Dictionary<string, object> _class = Classes.GetClass(classCode);

            sessionNumber.Maximum = int.Parse(_class["sessions"].ToString());
        }

        private void sessionNumber_ValueChanged(object sender, EventArgs e)
        {
            if ((int)sessionNumber.Value != 0)
            {
                studentsDataGridView.Rows.Clear();
                List<Dictionary<string, object>> sessionAttendance = Attendance.GetClassAttendance(classCode, ((int)sessionNumber.Value));

                if (sessionAttendance.Count > 0)
                {
                    updateBtn.Enabled = true;
                    addBtn.Enabled = false;

                    sessionDate.Text = sessionAttendance[0]["sessionDate"].ToString();

                    foreach (Dictionary<string, object> st in sessionAttendance)
                    {
                        Dictionary<string, string> student = Students.getStudent(st["studentNcode"].ToString());

                        if (Classes.isStudentInClass(classCode, st["studentNcode"].ToString()))
                        {
                            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
                            keyValuePairs["firstName"] = student["firstName"];
                            keyValuePairs["lastName"] = student["lastName"];
                            keyValuePairs["fatherName"] = student["fatherName"];
                            keyValuePairs["nCode"] = st["studentNcode"].ToString();
                            keyValuePairs["status"] = Convert.ToBoolean(int.Parse(st["status"].ToString()));

                            studentsDataGridView.Rows.Add(keyValuePairs.Values.ToArray());

                        }
                    }

                }
                else
                {
                    List<Dictionary<string, object>> students = Classes.GetClassStudents(classCode);

                    foreach (Dictionary<string, object> student in students)
                    {
                        Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
                        keyValuePairs["firstName"] = student["firstName"];
                        keyValuePairs["lastName"] = student["lastName"];
                        keyValuePairs["fatherName"] = student["fatherName"];
                        keyValuePairs["nCode"] = student["nCode"];
                        keyValuePairs["status"] = false;

                        studentsDataGridView.Rows.Add(keyValuePairs.Values.ToArray());
                    }

                    updateBtn.Enabled = false;
                    addBtn.Enabled = true;

                }

            }
            else
            {
                updateBtn.Enabled = false;
                addBtn.Enabled = false;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in studentsDataGridView.Rows)
                {
                    Attendance.UpdateStudentStatus(
                        classCode,
                        ((int)sessionNumber.Value),
                        sessionDate.Text.ToString(),
                        row.Cells[3].Value.ToString(),
                        Convert.ToInt32(bool.Parse(row.Cells[4].Value.ToString()))
                        );
                }
                MessageBox.Show("لیست به روزرسانی شد","به روزرسانی موفق",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("لیست خالی است","لیست خالی",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in studentsDataGridView.Rows)
                {
                    Attendance.AddStudent(classCode,
                        ((int)sessionNumber.Value),
                        sessionDate.Text.ToString(),
                        row.Cells[3].Value.ToString(),
                        Convert.ToInt32(bool.Parse(row.Cells[4].Value.ToString())));
                }
                MessageBox.Show("لیست ثبت شد","عملیات موفق",MessageBoxButtons.OK,MessageBoxIcon.Information);
                sessionNumber_ValueChanged(sender, e);
            }
            else
            {
                MessageBox.Show("لیست خالی است","لیست خالی",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
