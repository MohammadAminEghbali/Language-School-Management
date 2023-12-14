using System.Collections.Generic;
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

        private void eachClassManageForm_Load(object sender, System.EventArgs e)
        {

            foreach(string st in studntsListBox.Items)
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
                foreach(string st in studentslist)
                {
                    if (st.StartsWith(searchBox.Text))
                    {
                        studntsListBox.Items.Add(st);
                    }
                }
            }
            else
            {
                foreach(string st in studentslist)
                {
                    studntsListBox.Items.Add(st);
                }
            }
        }
    }
}
