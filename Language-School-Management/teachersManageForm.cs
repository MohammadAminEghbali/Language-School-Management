using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace Language_School_Management
{
    public partial class teachersManageForm : Form
    {
        public teachersManageForm()
        {
            InitializeComponent();
        }
        bool isCorrect2;
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

            if( ExcelDialog == DialogResult.OK )
            {
                SaveToExcel(TeachersdataGridView, ExcelSaveDialog2.FileName);
                isCorrect2 = true;
            }
            if(isCorrect2 == true)
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
    }
}
