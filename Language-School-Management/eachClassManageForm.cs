using System.Collections.Generic;
using System.Linq;
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

        private void classInfo()
        {
            Dictionary<string, object> _class = Classes.GetClass(classCode);


            classCodeValue.Text = classCode.ToString();
            className.Text = (string)_class["className"];
            startTimeValue.Text = (string)_class["startTime"];
            endTimeVAlue.Text = (string)_class["endTime"];
            sessionCountValue.Text = _class["sessions"].ToString();
            teacherNameValue.Text = (string)_class["teacherName"];
            teacherIDValue.Text = (string)_class["teacherNcode"];

        }

        private void eachClassManageForm_Load(object sender, System.EventArgs e)
        {
            classInfo();
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

        private void studntsListBox_DoubleClick(object sender, System.EventArgs e)
        {
            if (studntsListBox.SelectedItem != null)
            {
                string student = studntsListBox.SelectedItem.ToString();
                string[] strings = student.Split('-');
                searchBox.Text = strings.Last().Trim();

                studntsListBox.Items.Clear();
                foreach (string st in studentslist)
                {
                    studntsListBox.Items.Add(st);
                }
            }
        }
    }
}
