using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using OfficeOpenXml;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Language_School_Management
{
    public partial class studentsManageForm : Form
    {
        public studentsManageForm()
        {
            InitializeComponent();
        }
        bool isCorrect;
        bool isCorrect2;
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
            MessageBox.Show("ابتدا کد ملی زبان آموز را وارد کرده و دکمه حذف را بزنید ، این عملیات قابل برگشت نیست پس دقت کنید","راهنما");
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
            if(isCorrect == true)
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
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                }
                for (int i = 1; i <= dataGridView.Rows.Count; i++)
                {
                    for (int j = 1; j <= dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 1, j].Value = dataGridView.Rows[i - 1].Cells[j - 1].Value;
                    }
                }

                FileInfo output = new FileInfo(filePath);
                package.SaveAs(output);
            }
        }

        private void ExportToPdf(DataGridView dataGridView, string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    using (Document document = new Document(pdf))
                    {
                        iText.Layout.Element.Table table = new iText.Layout.Element.Table(dataGridView.ColumnCount);
                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(column.HeaderText)));
                        }
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString())));
                            }
                        }
                        document.Add(table);
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void pdfOutput_Click(object sender, EventArgs e)
        {
            pdfSaveDialog.Title = "Save Pdf File";
            pdfSaveDialog.Filter = "PDF Files|*.pdf";
            pdfSaveDialog.FileName = "Students.pdf";

            DialogResult pdfResult = pdfSaveDialog.ShowDialog();
            if (pdfResult == DialogResult.OK)
            {
                ExportToPdf(dataGridView1,pdfSaveDialog.FileName);
                isCorrect2 = true;
            }
            if(isCorrect2 == true)
            {
                MessageBox.Show("فایل pdf اطلاعات شما با موفقیت ثبت شد", "ذخیره شد");
            }
        }
    }
}
