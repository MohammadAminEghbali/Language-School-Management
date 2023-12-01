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

namespace Language_School_Management
{
    public partial class studentsManageForm : Form
    {
        public studentsManageForm()
        {
            InitializeComponent();
        }
        
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void excelOutput_Click(object sender, EventArgs e)
        {
            
            ExcelSaveDialog.FileName = "Students.xlsx";
            DialogResult ExcelDialog = ExcelSaveDialog.ShowDialog();
            
            if (ExcelDialog == DialogResult.OK)
            {
                SaveToExcel(dataGridView1, ExcelSaveDialog.FileName);
            }
        }

        private void SaveToExcel(DataGridView dataGridView, string filePath)
        {
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
    }
}
