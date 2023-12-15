using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Language_School_Management
{
    public partial class attendanceForm : Form
    {
        public attendanceForm()
        {
            InitializeComponent();
        }

        private void attendanceForm_Load(object sender, EventArgs e)
        {
            classesDataGridView.Rows.Clear();

            List<Dictionary<string, object>> classes = Classes.GetClasses();

            foreach (Dictionary<string, object> _class in classes)
            {
                classesDataGridView.Rows.Add(_class.Values.ToArray());
            }
        }

        private void classesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                eachClassAttendanceForm classAttendanceForm = new eachClassAttendanceForm(
                    int.Parse(
                        classesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()
                   )
                );

                classAttendanceForm.ShowDialog();

            }
        }
    }
}
