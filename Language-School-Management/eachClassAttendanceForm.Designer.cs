namespace Language_School_Management
{
    partial class eachClassAttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.studentFisrtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.sessionNumber = new System.Windows.Forms.NumericUpDown();
            this.sessionDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AllowUserToAddRows = false;
            this.studentsDataGridView.AllowUserToDeleteRows = false;
            this.studentsDataGridView.AllowUserToOrderColumns = true;
            this.studentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studentsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentFisrtName,
            this.studentLastName,
            this.fatherName,
            this.nCode,
            this.status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.studentsDataGridView.Location = new System.Drawing.Point(11, 11);
            this.studentsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.studentsDataGridView.RowTemplate.Height = 24;
            this.studentsDataGridView.Size = new System.Drawing.Size(627, 323);
            this.studentsDataGridView.TabIndex = 3;
            // 
            // studentFisrtName
            // 
            this.studentFisrtName.HeaderText = "نام";
            this.studentFisrtName.Name = "studentFisrtName";
            this.studentFisrtName.ReadOnly = true;
            this.studentFisrtName.Width = 55;
            // 
            // studentLastName
            // 
            this.studentLastName.HeaderText = "نام خانوادگی";
            this.studentLastName.Name = "studentLastName";
            this.studentLastName.ReadOnly = true;
            this.studentLastName.Width = 115;
            // 
            // fatherName
            // 
            this.fatherName.HeaderText = "نام پدر";
            this.fatherName.Name = "fatherName";
            this.fatherName.ReadOnly = true;
            this.fatherName.Width = 78;
            // 
            // nCode
            // 
            this.nCode.HeaderText = "کد ملی";
            this.nCode.Name = "nCode";
            this.nCode.ReadOnly = true;
            this.nCode.Width = 80;
            // 
            // status
            // 
            this.status.HeaderText = "حضور";
            this.status.Name = "status";
            this.status.Width = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(968, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "جلسه:";
            // 
            // sessionNumber
            // 
            this.sessionNumber.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionNumber.Location = new System.Drawing.Point(762, 18);
            this.sessionNumber.Name = "sessionNumber";
            this.sessionNumber.Size = new System.Drawing.Size(200, 32);
            this.sessionNumber.TabIndex = 5;
            this.sessionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sessionNumber.ValueChanged += new System.EventHandler(this.sessionNumber_ValueChanged);
            // 
            // sessionDate
            // 
            this.sessionDate.CustomFormat = "yyyy/MM/dd";
            this.sessionDate.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sessionDate.Location = new System.Drawing.Point(762, 75);
            this.sessionDate.Name = "sessionDate";
            this.sessionDate.Size = new System.Drawing.Size(200, 32);
            this.sessionDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(968, 75);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "تاریخ";
            // 
            // updateBtn
            // 
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(762, 140);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(103, 41);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "به روز رسانی";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Enabled = false;
            this.addBtn.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(871, 140);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(103, 41);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "ثبت";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // eachClassAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 481);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sessionDate);
            this.Controls.Add(this.sessionNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentsDataGridView);
            this.Name = "eachClassAttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست حضور و غیاب کلاس";
            this.Load += new System.EventHandler(this.eachClassAttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFisrtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sessionNumber;
        private System.Windows.Forms.DateTimePicker sessionDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
    }
}