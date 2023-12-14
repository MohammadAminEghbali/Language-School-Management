using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
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
        private void eachClassManageForm_Load(object sender, System.EventArgs e)
        {

            foreach (string st in studntsListBox.Items)
            {
                studentslist.Add(st);
            }
            var a = new AutoCompleteStringCollection();
            a.AddRange(studentslist.ToArray());

            //searchBox.AutoCompleteCustomSource = a;
            //searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

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

        private void excelOutput_Click(object sender, System.EventArgs e)
        {
            ExcelSaveDialog4.Title = "Save Excel File";
            ExcelSaveDialog4.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
            ExcelSaveDialog4.FileName = "Classes.xlsx";
            DialogResult ExcelDialog = ExcelSaveDialog4.ShowDialog();

            if (ExcelDialog == DialogResult.OK)
            {
                SaveToExcel(ClassDataGridView, ExcelSaveDialog4.FileName);
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
