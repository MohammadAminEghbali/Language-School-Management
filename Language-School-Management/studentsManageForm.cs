using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Language_School_Management
{
    public partial class studentsManageForm : Form
    {
        public studentsManageForm()
        {
            InitializeComponent();
        }
        bool isCorrect;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FnameBox.Clear();
            LnameBox.Clear();
            FatherBox.Clear();
            AddressBox.Clear();
            boxParentPhone.Clear();
            IDbox.Clear();
            boxPhone.Clear();
            boxHphone.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void delInfo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ابتدا کد ملی زبان آموز را وارد کرده و دکمه حذف را بزنید ، این عملیات قابل برگشت نیست پس دقت کنید", "راهنما");
        }

        private void delInfo2_MouseHover(object sender, EventArgs e)
        {

        }

        private void studentsManageForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            List<Dictionary<string, object>> students = Database.getStudents();

            foreach (Dictionary<string, object> student in students)
            {
                dataGridView1.Rows.Add(student.Values.ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void excelOutput_Click(object sender, EventArgs e)
        {
            ExcelSaveDialog.Title = "Save Excel File";
            ExcelSaveDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
            ExcelSaveDialog.FileName = "Students.xlsx";
            DialogResult ExcelDialog = ExcelSaveDialog.ShowDialog();


            if (ExcelDialog == DialogResult.OK)
            {
                SaveToExcel(dataGridView1, ExcelSaveDialog.FileName);
                isCorrect = true;
            }
            if (isCorrect == true)
            {
                MessageBox.Show("فایل اکسل اطلاعات شما با موفقیت ذخیره شد", "ذخیره شد");
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
            string fname = FnameBox.Text;
            string lname = LnameBox.Text;
            string fathername = FatherBox.Text;
            string address = AddressBox.Text;
            string parentphone = boxParentPhone.Text;
            string nCode = IDbox.Text;
            string phone = boxPhone.Text;
            string homephone = boxHphone.Text;

            if (fname == "")
            {
                MessageBox.Show("نام نمیتواند خالی باشد");
                return;
            }

            if (lname == "")
            {
                MessageBox.Show("نام خانوادگی نمیتواند خالی باشد");
                return;
            }

            if (fathername == "")
            {
                MessageBox.Show("نام پدر نمیتواند خالی باشد");
                return;
            }

            if (address == "")
            {
                MessageBox.Show("ادرس نمیتواند خالی باشد");
                return;
            }

            if (parentphone == "" || parentphone.Length < 11)
            {
                MessageBox.Show("شماره والدین نمیتواند خالی یا کمتر از 11 رقم باشد");
                return;
            }

            if (nCode == "" || nCode.Length < 10)
            {
                MessageBox.Show("کد ملی نمیتواند خالی یا کمتر از 10 رقم باشد");
                return;
            }

            if (phone == "" || phone.Length < 11)
            {
                MessageBox.Show("شماره تلفن همراه نمیتواند خالی یا کمتر از 11 رقم باشد");
                return;
            }

            if (homephone == "" || homephone.Length < 11)
            {
                MessageBox.Show("شماره تماس خانه نمیتواند خالی یا کمتر از 11 رقم باشد");
                return;
            }

            if (!Database.isStudentExists(nCode))
            {
                Database.AddStudent(fname, lname, fathername, nCode, phone, homephone, parentphone, address);

                MessageBox.Show("زبان آموز با موفقیت اضافه شد");
                studentsManageForm_Load(sender, e);
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("زبان آموز با این کد ملی از قبل وجود دارد");
            }

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            string nCode = delBox.Text;
            if (nCode == "" || nCode.Length < 10)
            {
                MessageBox.Show("کد ملی نمیتواند خالی یا کمتر از 10 رقم باشد");
                return;
            }

            if (Database.isStudentExists(nCode))
            {
                DialogResult result = MessageBox.Show(
                    "شما درحال حذف کردن یک زبان آموز هستید\nآیا از انجام این کار مطمئن هستید؟",
                    "عملیات غیر قابل بازگشت",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign
                    );

                if (result == DialogResult.Yes)
                {
                    Database.delStudent(nCode);
                    MessageBox.Show("زبان آموز باموفقیت حذف گردید");

                    studentsManageForm_Load(sender, e);
                    delBox.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("عملیات لغو شد");
                }

            }
            else
            {
                MessageBox.Show("زبان آموز با این کد ملی وجود ندارد");
            }
        }
    }
}
