using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Language_School_Management
{
    public partial class teachersManageForm : Form
    {
        public teachersManageForm()
        {
            InitializeComponent();
        }
        bool isCorrect2, isEditing;

        private void btnClear_Click(object sender, EventArgs e)
        {
            boxTeachName.Clear();
            boxTeachLname.Clear();
            boxTeachFathName.Clear();
            boxTeachID.Clear();
            boxTeachPhone.Clear();
            boxTeachDocument.Clear();
            boxTeachAddress.Clear();
        }

        private void btnExcelOutput_Click(object sender, EventArgs e)
        {
            ExcelSaveDialog2.Title = "Save Excel File";
            ExcelSaveDialog2.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
            ExcelSaveDialog2.FileName = "Teachers.xlsx";

            DialogResult ExcelDialog = ExcelSaveDialog2.ShowDialog();

            if (ExcelDialog == DialogResult.OK)
            {
                SaveToExcel(TeachersdataGridView, ExcelSaveDialog2.FileName);
                isCorrect2 = true;
            }
            if (isCorrect2 == true)
            {
                MessageBox.Show("فایل اکسل اطلاعات شما با موفقیت ذخیره شد", "ذخیره شد",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void teachersManageForm_Load(object sender, EventArgs e)
        {
            TeachersdataGridView.Rows.Clear();

            List<Dictionary<string, object>> teachers = Teachers.getTeachers();

            foreach (Dictionary<string, object> teacher in teachers)
            {
                TeachersdataGridView.Rows.Add(teacher.Values.ToArray());
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fname = boxTeachName.Text;
            string lname = boxTeachLname.Text;
            string fathername = boxTeachFathName.Text;
            string address = boxTeachAddress.Text;
            string nCode = boxTeachID.Text;
            string phone = boxTeachPhone.Text;
            string certificate = boxTeachDocument.Text;

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

            if (certificate == "")
            {
                MessageBox.Show("مدرک تحصیلی نمیتواند خالی باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (address == "")
            {
                MessageBox.Show("آدرس نمیتواند خالی باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!Teachers.isTeacherExists(nCode))
            {
                Teachers.AddTeacher(fname, lname, fathername, nCode, certificate, phone, address);

                MessageBox.Show("استاد با موفقیت اضافه شد", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                teachersManageForm_Load(sender, e);
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("استادی با این کد ملی از قبل وجود دارد", "استاد تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTeachDel_Click(object sender, EventArgs e)
        {
            string nCode = BoxTeachIDdel.Text;

            if (nCode == "" || nCode.Length < 10)
            {
                MessageBox.Show("کد ملی نمیتواند خالی یا کمتر از 10 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Teachers.isTeacherExists(nCode))
            {
                DialogResult result = MessageBox.Show(
                    "شما درحال حذف کردن یک استاد هستید\nآیا از انجام این کار مطمئن هستید؟",
                    "عملیات غیر قابل بازگشت",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign
                    );

                if (result == DialogResult.Yes)
                {
                    Teachers.delTeacher(nCode);
                    MessageBox.Show("استاد با موفقیت حذف گردید", "عملیت موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    teachersManageForm_Load(sender, e);
                    BoxTeachIDdel.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("عملیات لغو شد", "لغو عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("استادی با این کد ملی وجود ندارد", "استاد ثبت نشده", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fname = boxNameUpdate.Text;
            string lname = boxLnameUpdate.Text;
            string fathername = boxFathUpdate.Text;
            string address = boxAddressUpdate.Text;
            string nCode = boxTeachIDUpdate.Text;
            string phone = boxPhoneUpdate.Text;
            string certificate = boxCertificate.Text;

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

            if (phone == "" || phone.Length < 11)
            {
                MessageBox.Show("شماره تلفن همراه نمیتواند خالی یا کمتر از 11 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (address == "")
            {
                MessageBox.Show("آدرس نمیتواند خالی باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (certificate == "")
            {
                MessageBox.Show("مدرک تحصیلی", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nCode == "" || nCode.Length < 10)
            {
                MessageBox.Show("کد ملی نمیتواند خالی یا کمتر از 10 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Teachers.updateTeacher(nCode, fname, lname, fathername, certificate, phone, address);

            MessageBox.Show("اطلاعات استاد با موفقیت ویراش شد", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

            boxTeachIDUpdate.Text = "";

            teachersManageForm_Load(sender, e);
            btnCallInfo_Click(sender, e);
        }

        private void btnCallInfo_Click(object sender, EventArgs e)
        {
            string nCode = boxTeachIDUpdate.Text;

            if (isEditing)
            {
                boxNameUpdate.Text = "";
                boxNameUpdate.Enabled = false;

                boxLnameUpdate.Text = "";
                boxLnameUpdate.Enabled = false;

                boxFathUpdate.Text = "";
                boxFathUpdate.Enabled = false;

                boxPhoneUpdate.Text = "";
                boxPhoneUpdate.Enabled = false;

                boxAddressUpdate.Text = "";
                boxAddressUpdate.Enabled = false;

                boxCertificate.Text = "";
                boxCertificate.Enabled = false;

                btnUpdate.Enabled = false;

                boxTeachIDUpdate.Enabled = true;
                btnCallInfo.Text = "فراخوانی";
                isEditing = false;
            }
            else
            {

                if (nCode == "" || nCode.Length < 10)
                {
                    MessageBox.Show("کد ملی نمیتواند خالی یا کمتر از 10 رقم باشد", "مقدار نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Teachers.isTeacherExists(nCode))
                {
                    Dictionary<string, string> student = Teachers.getTeacher(nCode);

                    boxNameUpdate.Text = student["firstName"];
                    boxNameUpdate.Enabled = true;

                    boxLnameUpdate.Text = student["lastName"];
                    boxLnameUpdate.Enabled = true;

                    boxFathUpdate.Text = student["fatherName"];
                    boxFathUpdate.Enabled = true;

                    boxAddressUpdate.Text = student["homeAddress"];
                    boxAddressUpdate.Enabled = true;

                    boxPhoneUpdate.Text = student["phoneNumber"];
                    boxPhoneUpdate.Enabled = true;

                    boxCertificate.Text = student["certificate"];
                    boxCertificate.Enabled = true;

                    btnUpdate.Enabled = true;

                    boxTeachIDUpdate.Enabled = false;

                    btnCallInfo.Text = "لفو";

                    isEditing = true;

                }
                else
                {
                    MessageBox.Show("استادی با این کد ملی وجود ندارد", "استاد ثبت نشده", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}
