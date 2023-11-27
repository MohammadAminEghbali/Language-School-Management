using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_School_Management
{
    public partial class studentsManageForm : Form
    {
        public studentsManageForm()
        {
            InitializeComponent();
        }

        private void studentsManageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Lang_SchoolDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this._Lang_SchoolDataSet.Teachers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
