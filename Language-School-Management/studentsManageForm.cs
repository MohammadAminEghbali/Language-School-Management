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
            
            List<Dictionary<string, object>> students = Database.getStudents();

            foreach (Dictionary<string, object> student in students)
            {
                dataGridView1.Rows.Add(student.Values.ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
