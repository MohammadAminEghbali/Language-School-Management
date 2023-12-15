using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Collections.Generic;
using System.IO;
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
        bool isCorrect4;
        private void classInfo()
        {
            Dictionary<string, object> _class = Classes.GetClass(classCode);

            int passed = Attendance.GetClassPassedSessions(classCode);
            string totalSessions = _class["sessions"].ToString();

            classCodeValue.Text = classCode.ToString();
            className.Text = (string)_class["className"];
            startTimeValue.Text = (string)_class["startTime"];
            endTimeVAlue.Text = (string)_class["endTime"];
            sessionCountValue.Text = totalSessions + " / " + passed;
            teacherNameValue.Text = (string)_class["teacherName"];
            teacherIDValue.Text = (string)_class["teacherNcode"];
            classProgress.Maximum = int.Parse(totalSessions);
            classProgress.Value = passed;

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

                            MessageBox.Show("زبان آموز باموفقیت به کلاس اضافه شد", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            searchBox.Text = string.Empty;

                            studentslist_Refresh();
                            studentsDataGridView_Refresh();
                        }
                        else
                        {
                            MessageBox.Show("زبان آموز در یک کلاس دیگر وجود دارد", "زبان آموز مشغول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("زبان آموز در این کلاس وجود دارد", "زبان آموز تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("زبان آموز وجود ندارد", "کد ملی ثبت نشده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("کد ملی معتبر نیست", "کد ملی نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                        DialogResult result = MessageBox.Show("آیا از حذف زبان آموز از کلاس مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            Classes.DelStudentFromClass(nCode);

                            MessageBox.Show("زبان آموز باموفقیت از کلاس حذف شد", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            boxIDDelete.Text = string.Empty;

                            studentslist_Refresh();
                            studentsDataGridView_Refresh();

                        }
                        else
                        {
                            MessageBox.Show("عملیات با موفقیت لغو شد", "لغو عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("زبان آموز در این کلاس وجود ندارد", "زبان آموز نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("زبان اموز وجود ندارد", "زبان آموز نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("کد ملی معتبر نیست", "کد ملی نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void studentsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (0 <= e.RowIndex)
            {
                boxIDDelete.Text = studentsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ExcelSaveDialog4.Title = "Save Excel File";
            ExcelSaveDialog4.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
            ExcelSaveDialog4.FileName = "Class.xlsx";
            DialogResult ExcelDialog = ExcelSaveDialog4.ShowDialog();

            if (ExcelDialog == DialogResult.OK)
            {
                SaveToExcel(studentsDataGridView, ExcelSaveDialog4.FileName);
                isCorrect4 = true;
            }
            if (isCorrect4 == true)
            {
                MessageBox.Show("فایل اکسل اطلاعات شما با موفقیت ذخیره شد", "ذخیره شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveToExcel(DataGridView dataGridView, string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");
                worksheet.View.RightToLeft = true;


                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                }

                ExcelRange cells = worksheet.Cells[1, 1, 1, worksheet.Cells.End.Column];

                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cells.Style.Font.SetFromFont("B Titr", 14);

                for (int i = 1; i <= dataGridView.Rows.Count; i++)
                {
                    for (int j = 1; j <= dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 1, j].Value = dataGridView.Rows[i - 1].Cells[j - 1].Value;
                    }
                }

                cells = worksheet.Cells[2, 1, worksheet.Cells.End.Row, worksheet.Cells.End.Column];

                cells.Style.Font.SetFromFont("Vazir", 12);
                cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;


                if (worksheet.Dimension != null)
                {
                    cells = worksheet.Cells[worksheet.Dimension.Address];

                    cells.AutoFitColumns();
                    cells.Style.Numberformat.Format = "@";

                }

                FileInfo output = new FileInfo(filePath);
                package.SaveAs(output);
            }
        }
    }
}
