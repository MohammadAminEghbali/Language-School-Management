using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Language_School_Management
{
    public partial class eachClassManageForm : Form
    {
        private int classCode;
        private List<string> studentslist = new List<string>();
        public eachClassManageForm(int classCode)
        {
            this.classCode = classCode;
            InitializeComponent();
        }

        private void classInfo()
        {
            Dictionary<string, object> _class = Classes.GetClass(classCode);


            classCodeValue.Text = classCode.ToString();
            className.Text = (string)_class["className"];
            startTimeValue.Text = (string)_class["startTime"];
            endTimeVAlue.Text = (string)_class["endTime"];
            sessionCountValue.Text = _class["sessions"].ToString();
            teacherNameValue.Text = (string)_class["teacherName"];
            teacherIDValue.Text = (string)_class["teacherNcode"];

        }

        private void studentslist_Refresh()
        {
            studntsListBox.Items.Clear();
            studentslist.Clear();

            List<Dictionary<string, object>> notAded = Classes.GetNotAddedStudents();

            foreach (Dictionary<string, object> keyValuePairs in notAded)
            {
                string student = keyValuePairs["firstName"] + " " + keyValuePairs["lastName"] + " - " + keyValuePairs["nCode"];

                studentslist.Add(student);
                studntsListBox.Items.Add(student);
            }

        }

        private void studentsDataGridView_Refresh()
        {
            studentsDataGridView.Rows.Clear();

            List<Dictionary<string, object>> students = Classes.GetClassStudents(classCode);

            foreach (Dictionary<string, object> student in students)
            {
                studentsDataGridView.Rows.Add(student.Values.ToArray());
            }
        }
        private void eachClassManageForm_Load(object sender, System.EventArgs e)
        {
            classInfo();
            studentslist_Refresh();
            studentsDataGridView_Refresh();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            studntsListBox.Items.Clear();

            if (!string.IsNullOrEmpty(searchBox.Text))
            {
                foreach (string st in studentslist)
                {
                    if (st.StartsWith(searchBox.Text))
                    {
                        studntsListBox.Items.Add(st);
                    }
                }
            }
            else
            {
                foreach (string st in studentslist)
                {
                    studntsListBox.Items.Add(st);
                }
            }
        }

        private void studntsListBox_DoubleClick(object sender, System.EventArgs e)
        {
            if (studntsListBox.SelectedItem != null)
            {
                string student = studntsListBox.SelectedItem.ToString();
                string[] strings = student.Split('-');
                searchBox.Text = strings.Last().Trim();

                studntsListBox.Items.Clear();
                foreach (string st in studentslist)
                {
                    studntsListBox.Items.Add(st);
                }
            }
        }

        private void addStudent_Click(object sender, System.EventArgs e)
        {
            string nCode = searchBox.Text;

            if (nCode != string.Empty && nCode.All(char.IsDigit) && nCode.Length == 10)
            {
                if (Students.isStudentExists(nCode))
                {
                    if (!Classes.isStudentInClass(classCode, nCode))
                    {
                        if (!Students.isStudentHasClass(nCode))
                        {
                            Classes.AddStudentToClass(classCode, nCode);

                            MessageBox.Show("زبان آموز باموفقیت به کلاس اضافه شد");
                            searchBox.Text = string.Empty;

                            studentslist_Refresh();
                            studentsDataGridView_Refresh();
                        }
                        else
                        {
                            MessageBox.Show("زبان اموز در یک کلاس دیگر وجود دارد");
                        }
                    }
                    else
                    {
                        MessageBox.Show("زبان اموز در این کلاس وجود دارد");
                    }

                }
                else
                {
                    MessageBox.Show("زبان اموز وجود ندارد.");
                }

            }
            else
            {
                MessageBox.Show("کد ملی معتبر نیست");

            }
        }

        private void btnDeleteStudent_Click(object sender, System.EventArgs e)
        {
            string nCode = boxIDDelete.Text;

            if (nCode != string.Empty && nCode.All(char.IsDigit) && nCode.Length == 10)
            {
                if (Students.isStudentExists(nCode))
                {
                    if (Classes.isStudentInClass(classCode, nCode))
                    {
                        DialogResult result = MessageBox.Show("آیا از حذف زبان آموز از کلاس مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            Classes.DelStudentFromClass(nCode);

                            MessageBox.Show("زبان آموز باموفقیت از کلاس حذف شد");
                            boxIDDelete.Text = string.Empty;

                            studentslist_Refresh();
                            studentsDataGridView_Refresh();

                        }
                        else
                        {
                            MessageBox.Show("عملیات با موفقیت لغو شد");
                        }
                    }
                    else
                    {
                        MessageBox.Show("زبان اموز در این کلاس وجود ندارد");

                    }
                }
                else
                {
                    MessageBox.Show("زبان اموز وجود ندارد.");
                }

            }
            else
            {
                MessageBox.Show("کد ملی معتبر نیست");

            }
        }

        private void studentsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (0 <= e.RowIndex)
            {
                boxIDDelete.Text = studentsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
