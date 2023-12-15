namespace Language_School_Management
{
    partial class attendanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendanceForm));
            this.classesDataGridView = new System.Windows.Forms.DataGridView();
            this.classCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // classesDataGridView
            // 
            this.classesDataGridView.AllowUserToAddRows = false;
            this.classesDataGridView.AllowUserToDeleteRows = false;
            this.classesDataGridView.AllowUserToOrderColumns = true;
            this.classesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.classesDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.classesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classCode,
            this.className,
            this.startTime,
            this.endTime,
            this.sessions,
            this.teacherName,
            this.teacherNcode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.classesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.classesDataGridView.Name = "classesDataGridView";
            this.classesDataGridView.ReadOnly = true;
            this.classesDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classesDataGridView.Size = new System.Drawing.Size(1020, 379);
            this.classesDataGridView.TabIndex = 19;
            this.classesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classesDataGridView_CellDoubleClick);
            // 
            // classCode
            // 
            this.classCode.HeaderText = "کد کلاس";
            this.classCode.Name = "classCode";
            this.classCode.ReadOnly = true;
            this.classCode.Width = 90;
            // 
            // className
            // 
            this.className.HeaderText = "نام کلاس";
            this.className.Name = "className";
            this.className.ReadOnly = true;
            this.className.Width = 91;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "ساعت شروع";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Width = 107;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "ساعت پایان";
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            this.endTime.Width = 102;
            // 
            // sessions
            // 
            this.sessions.HeaderText = "تعداد جلسات";
            this.sessions.Name = "sessions";
            this.sessions.ReadOnly = true;
            this.sessions.Width = 111;
            // 
            // teacherName
            // 
            this.teacherName.HeaderText = "نام استاد";
            this.teacherName.Name = "teacherName";
            this.teacherName.ReadOnly = true;
            this.teacherName.Width = 88;
            // 
            // teacherNcode
            // 
            this.teacherNcode.HeaderText = "کد ملی استاد";
            this.teacherNcode.Name = "teacherNcode";
            this.teacherNcode.ReadOnly = true;
            this.teacherNcode.Width = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(201, 409);
            this.label1.MaximumSize = new System.Drawing.Size(850, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(836, 50);
            this.label1.TabIndex = 20;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // attendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1044, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "attendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "حضور و غیاب";
            this.Load += new System.EventHandler(this.attendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView classesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn classCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn className;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNcode;
        private System.Windows.Forms.Label label1;
    }
}