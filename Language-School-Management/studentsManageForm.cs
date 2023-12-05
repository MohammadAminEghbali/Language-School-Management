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

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                worksheet.Cells[worksheet.Dimension.Address].Style.Numberformat.Format = "@";

                FileInfo output = new FileInfo(filePath);
                package.SaveAs(output);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

    }
}
