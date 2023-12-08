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
        bool isCorrect, isEditing;

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

            List<Dictionary<string, object>> students = Students.getStudents();

            foreach (Dictionary<string, object> student in students)
            {
                dataGridView1.Rows.Add(student.Values.ToArray());
            }
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
                MessageBox.Show("نام نمیتواند خالی باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lname == "")
            {
                MessageBox.Show("نام خانوادگی نمیتواند خالی باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fathername == "")
            {
                MessageBox.Show("نام پدر نمیتواند خالی باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (address == "")
            {
                MessageBox.Show("آدرس نمیتواند خالی باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (parentphone == "" || parentphone.Length < 11)
            {
                MessageBox.Show("شماره والدین نمیتواند خالی یا کمتر از 11 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nCode == "" || nCode.Length < 10)
            {
                MessageBox.Show("کد ملی نمیتواند خالی یا کمتر از 10 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phone == "" || phone.Length < 11)
            {
                MessageBox.Show("شماره تلفن همراه نمیتواند خالی یا کمتر از 11 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (homephone == "" || homephone.Length < 11)
            {
                MessageBox.Show("شماره تماس خانه نمیتواند خالی یا کمتر از 11 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Students.isStudentExists(nCode))
            {
                Students.AddStudent(fname, lname, fathername, nCode, phone, homephone, parentphone, address);

                MessageBox.Show("زبان آموز با موفقیت اضافه شد", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                studentsManageForm_Load(sender, e);
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("زبان آموز با این کد ملی از قبل وجود دارد", "زبان آموز تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            string nCode = delBox.Text;
            if (nCode == "" || nCode.Length < 10)
            {
                MessageBox.Show("کد ملی نمیتواند خالی یا کمتر از 10 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Students.isStudentExists(nCode))
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
                    Students.delStudent(nCode);
                    MessageBox.Show("زبان آموز باموفقیت حذف گردید", "عملیت موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    studentsManageForm_Load(sender, e);
                    delBox.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("عملیات لغو شد", "لغو عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("زبان آموز با این کد ملی وجود ندارد", "زبان آموز ثبت نشده", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInfoCall_Click(object sender, EventArgs e)
        {
            string nCode = boxIdUpdate.Text;

            if (isEditing)
            {
                BoxNameUpdate.Text = "";
                BoxNameUpdate.Enabled = false;

                boxLanameUpdate.Text = "";
                boxLanameUpdate.Enabled = false;

                boxFatherUpdate.Text = "";
                boxFatherUpdate.Enabled = false;

                boxAddressUpdate.Text = "";
                boxAddressUpdate.Enabled = false;

                boxPhoneUpdate.Text = "";
                boxPhoneUpdate.Enabled = false;

                boxParentPhoneUpdate.Text = "";
                boxParentPhoneUpdate.Enabled = false;

                boxHphoneUpdate.Text = "";
                boxHphoneUpdate.Enabled = false;

                editbtn.Enabled = false;

                boxIdUpdate.Enabled = true;
                btnInfoCall.Text = "فراخوانی";
                isEditing = false;
            }
            else
            {

                if (nCode == "" || nCode.Length < 10)
                {
                    MessageBox.Show("کد ملی نمیتواند خالی یا کمتر از 10 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Students.isStudentExists(nCode))
                {
                    Dictionary<string, string> student = Students.getStudent(nCode);

                    BoxNameUpdate.Text = student["firstName"];
                    BoxNameUpdate.Enabled = true;

                    boxLanameUpdate.Text = student["lastName"];
                    boxLanameUpdate.Enabled = true;

                    boxFatherUpdate.Text = student["fatherName"];
                    boxFatherUpdate.Enabled = true;

                    boxAddressUpdate.Text = student["homeAddress"];
                    boxAddressUpdate.Enabled = true;

                    boxPhoneUpdate.Text = student["phoneNumber"];
                    boxPhoneUpdate.Enabled = true;

                    boxParentPhoneUpdate.Text = student["parentPhone"];
                    boxParentPhoneUpdate.Enabled = true;

                    boxHphoneUpdate.Text = student["homePhone"];
                    boxHphoneUpdate.Enabled = true;

                    editbtn.Enabled = true;

                    boxIdUpdate.Enabled = false;

                    btnInfoCall.Text = "لفو";

                    isEditing = true;

                }
                else
                {
                    MessageBox.Show("زبان آموز با این کد ملی وجود ندارد", "زبان آموز ثبت نشده", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            string fname = BoxNameUpdate.Text;
            string lname = boxLanameUpdate.Text;
            string fathername = boxFatherUpdate.Text;
            string address = boxAddressUpdate.Text;
            string parentphone = boxParentPhoneUpdate.Text;
            string nCode = boxIdUpdate.Text;
            string phone = boxPhoneUpdate.Text;
            string homephone = boxHphoneUpdate.Text;

            if (fname == "")
            {
                MessageBox.Show("نام نمیتواند خالی باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lname == "")
            {
                MessageBox.Show("نام خانوادگی نمیتواند خالی باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fathername == "")
            {
                MessageBox.Show("نام پدر نمیتواند خالی باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (address == "")
            {
                MessageBox.Show("آدرس نمیتواند خالی باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phone == "" || phone.Length < 11)
            {
                MessageBox.Show("شماره تلفن همراه نمیتواند خالی یا کمتر از 11 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (parentphone == "" || parentphone.Length < 11)
            {
                MessageBox.Show("شماره والدین نمیتواند خالی یا کمتر از 11 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (homephone == "" || homephone.Length < 11)
            {
                MessageBox.Show("شماره تماس خانه نمیتواند خالی یا کمتر از 11 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nCode == "" || nCode.Length < 10)
            {
                MessageBox.Show("کد ملی نمیتواند خالی یا کمتر از 10 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Students.updateStudent(nCode, fname, lname, fathername, phone, homephone, parentphone, address);

            MessageBox.Show("اطلاعات زبان آموز با موفقیت ویراش شد", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

            boxIdUpdate.Text = "";

            studentsManageForm_Load(sender, e);
            btnInfoCall_Click(sender, e);
        }
    }
}
