using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Language_School_Management
{
    public partial class ClassManageForm : Form
    {
        public ClassManageForm()
        {
            InitializeComponent();
        }
        bool isCorrect3;
        bool isEditing;

        private void btnClear_Click(object sender, EventArgs e)
        {
            boxClassName.Clear();
            boxStartTime.Text = DateTime.Now.ToString("HH:mm");
            boxEndTime.Text = DateTime.Now.ToString("HH:mm");
            boxTeacherID.Clear();
            boxSessionCount.Clear();
        }

        private void excelOutput_Click(object sender, EventArgs e)
        {
            ExcelSaveDialog3.Title = "Save Excel File";
            ExcelSaveDialog3.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
            ExcelSaveDialog3.FileName = "Classes.xlsx";
            DialogResult ExcelDialog = ExcelSaveDialog3.ShowDialog();

            if (ExcelDialog == DialogResult.OK)
            {
                SaveToExcel(classesDataGridView, ExcelSaveDialog3.FileName);
                isCorrect3 = true;
            }
            if (isCorrect3 == true)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string className = boxClassName.Text;
            string startTime = boxStartTime.Text;
            string endTime = boxEndTime.Text;
            int sessions = 0;

            if (boxSessionCount.Text != string.Empty)
            {
                try
                {
                    sessions = Convert.ToInt32(boxSessionCount.Text);

                }
                catch (FormatException)
                {
                    MessageBox.Show("تعداد جلسات باید عدد باشد");
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("تعداد جلسات معتبر نیست");
                    return;
                }
            }

            string teacherNcode = boxTeacherID.Text;

            if (className == "")
            {
                MessageBox.Show("نام کلاس نمیتواند خالی باشد");
                return;
            }

            if (startTime == endTime)
            {
                MessageBox.Show("ساعت شروع و ساعت پایان نمیتوانند یکسان باشند");
                return;
            }

            if (sessions < 1)
            {
                MessageBox.Show("تعداد جلسات نمیتواند از 1 کوچک تر باشد");
                return;
            }

            if (teacherNcode == "" || teacherNcode.Length < 10)
            {
                MessageBox.Show("کد ملی استاد نمیتواند خالی یا کمتر از 10 رقم باشد");
                return;
            }

            if (!Classes.isClassExists(teacherNcode, startTime, endTime))
            {
                Dictionary<string, string> teacher = Teachers.getTeacher(teacherNcode);

                if (teacher != null)
                {
                    string teacherName = teacher["firstName"] + " " + teacher["lastName"];

                    Classes.AddClass(className, startTime, endTime, sessions, teacherName, teacherNcode);
                    MessageBox.Show("کلاس با موفقیت اضافه شد");
                    ClassManageForm_Load(sender, e);
                    btnClear_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("استاد در لیست اساتید وجود ندارد");
                }

            }
            else
            {
                MessageBox.Show("استاد مورد نظر از قبل در این ساعت کلاس دارد");
            }

        }

        private void ClassManageForm_Load(object sender, EventArgs e)
        {
            classesDataGridView.Rows.Clear();

            List<Dictionary<string, object>> classes = Classes.GetClasses();

            foreach (Dictionary<string, object> _class in classes)
            {
                classesDataGridView.Rows.Add(_class.Values.ToArray());
            }
        }

        private void classesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString() + e.ColumnIndex.ToString());
        }

        private void btnClassDelete_Click(object sender, EventArgs e)
        {
            if (boxClassDelete.Text != string.Empty)
            {
                int classCode;
                try
                {
                    classCode = Convert.ToInt32(boxClassDelete.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("مقدار وارد شده عدد نیست");
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("مقدار وارد شده معتبر نیست");
                    return;
                }

                if (Classes.isClassExists(classCode))
                {
                    DialogResult result = MessageBox.Show("ایا از حذف کلاس مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Classes.DeleteClass(classCode);
                        MessageBox.Show("کلاس با موفقیت حذف شد");
                        ClassManageForm_Load(sender, e);
                        boxClassDelete.Text = string.Empty;

                    }
                    else
                    {
                        MessageBox.Show("عملیات با موفقیت لغو شد");
                    }

                }
                else
                {
                    MessageBox.Show("کلاس مورد نظر وجود ندارد");
                }
            }
        }

        private void btnInfoCall_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                boxClassNameUpdate.Text = string.Empty;
                boxClassNameUpdate.Enabled = false;

                boxSessionCountUpdate.Text = string.Empty;
                boxSessionCountUpdate.Enabled = false;

                boxStartTimeUpdate.Text = DateTime.Now.ToString("HH:mm");
                boxStartTimeUpdate.Enabled = false;

                boxEndTimeUpdate.Text = DateTime.Now.ToString("HH:mm");
                boxEndTimeUpdate.Enabled = false;

                boxTeacherNcodeUpdate.Text = string.Empty;
                boxTeacherNcodeUpdate.Enabled = false;

                btnInfoCall.Text = "فراخوانی";
                boxClassCodeUpdate.Enabled = true;

                isEditing = false;

            }
            else
            {
                int classCode;

                try
                {
                    classCode = Convert.ToInt32(boxClassCodeUpdate.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("مقدار وارد شده عدد نیست");
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("مقدار وارد شده معتبر نیست");
                    return;
                }

                if (Classes.isClassExists(classCode))
                {
                    Dictionary<string, object> _class = Classes.GetClass(classCode);

                    boxClassNameUpdate.Text = (string)_class["className"];
                    boxClassNameUpdate.Enabled = true;

                    boxSessionCountUpdate.Text = _class["sessions"].ToString();
                    boxSessionCountUpdate.Enabled = true;

                    boxStartTimeUpdate.Text = (string)_class["startTime"];
                    boxStartTimeUpdate.Enabled = true;

                    boxEndTimeUpdate.Text = (string)_class["endTime"];
                    boxEndTimeUpdate.Enabled = true;

                    boxTeacherNcodeUpdate.Text = (string)_class["teacherNcode"];
                    boxTeacherNcodeUpdate.Enabled = true;

                    btnInfoCall.Text = "لفو";
                    boxClassCodeUpdate.Enabled = false;


                    btnEdit.Enabled = isEditing = true;
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int classCode = Convert.ToInt32(boxClassCodeUpdate.Text);

            string className = boxClassNameUpdate.Text;
            string startTime = boxStartTimeUpdate.Text;
            string endTime = boxEndTimeUpdate.Text;
            int sessions = 0;

            if (boxSessionCountUpdate.Text != string.Empty)
            {
                try
                {
                    sessions = Convert.ToInt32(boxSessionCountUpdate.Text);

                }
                catch (FormatException)
                {
                    MessageBox.Show("تعداد جلسات باید عدد باشد");
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("تعداد جلسات معتبر نیست");
                    return;
                }
            }

            string teacherNcode = boxTeacherNcodeUpdate.Text;

            if (className == "")
            {
                MessageBox.Show("نام کلاس نمیتواند خالی باشد");
                return;
            }

            if (startTime == endTime)
            {
                MessageBox.Show("ساعت شروع و ساعت پایان نمیتوانند یکسان باشند");
                return;
            }

            if (sessions < 1)
            {
                MessageBox.Show("تعداد جلسات نمیتواند از 1 کوچک تر باشد");
                return;
            }

            if (teacherNcode == "" || teacherNcode.Length < 10)
            {
                MessageBox.Show("کد ملی استاد نمیتواند خالی یا کمتر از 10 رقم باشد");
                return;
            }

            if (Classes.isClassExists(classCode))
            {
                Dictionary<string, string> teacher = Teachers.getTeacher(teacherNcode);

                if (teacher != null)
                {
                    string teacherName = teacher["firstName"] + " " + teacher["lastName"];

                    Classes.UpdateClass(classCode, className, startTime, endTime, sessions, teacherName, teacherNcode);
                    MessageBox.Show("کلاس با موفقیت اضافه شد");
                    ClassManageForm_Load(sender, e);
                    btnInfoCall_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("استاد در لیست اساتید وجود ندارد");
                }

            }
            else
            {
                MessageBox.Show("این کلاس وجود ندارد");
            }
        }
    }
}
