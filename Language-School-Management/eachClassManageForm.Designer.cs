namespace Language_School_Management
{
    partial class eachClassManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.studntsListBox = new System.Windows.Forms.ListBox();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.studentFisrtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addStudent = new System.Windows.Forms.Button();
            this.teacherNameKey = new System.Windows.Forms.Label();
            this.teacherNameValue = new System.Windows.Forms.Label();
            this.teacherIDKey = new System.Windows.Forms.Label();
            this.teacherIDValue = new System.Windows.Forms.Label();
            this.classCodeKey = new System.Windows.Forms.Label();
            this.classCodeValue = new System.Windows.Forms.Label();
            this.startTimeKey = new System.Windows.Forms.Label();
            this.startTimeValue = new System.Windows.Forms.Label();
            this.endTimeKey = new System.Windows.Forms.Label();
            this.endTimeVAlue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classProgress = new System.Windows.Forms.ProgressBar();
            this.className = new System.Windows.Forms.Label();
            this.ClassNameKey = new System.Windows.Forms.Label();
            this.sessionCountValue = new System.Windows.Forms.Label();
            this.sessionCountKey = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delInfo2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.boxIDDelete = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ExcelSaveDialog4 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchBox.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(333, 41);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(221, 32);
            this.searchBox.TabIndex = 3;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // studntsListBox
            // 
            this.studntsListBox.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studntsListBox.FormattingEnabled = true;
            this.studntsListBox.HorizontalScrollbar = true;
            this.studntsListBox.ItemHeight = 25;
            this.studntsListBox.Location = new System.Drawing.Point(5, 29);
            this.studntsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studntsListBox.Name = "studntsListBox";
            this.studntsListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.studntsListBox.Size = new System.Drawing.Size(221, 204);
            this.studntsListBox.TabIndex = 1;
            this.studntsListBox.DoubleClick += new System.EventHandler(this.studntsListBox_DoubleClick);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AllowUserToAddRows = false;
            this.studentsDataGridView.AllowUserToDeleteRows = false;
            this.studentsDataGridView.AllowUserToOrderColumns = true;
            this.studentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studentsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentFisrtName,
            this.studentLastName,
            this.fatherName,
            this.nCode,
            this.phone,
            this.parentPhone});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.studentsDataGridView.Location = new System.Drawing.Point(9, 10);
            this.studentsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.studentsDataGridView.RowTemplate.Height = 24;
            this.studentsDataGridView.Size = new System.Drawing.Size(627, 323);
            this.studentsDataGridView.TabIndex = 2;
            this.studentsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentsDataGridView_CellMouseDoubleClick);
            // 
            // studentFisrtName
            // 
            this.studentFisrtName.HeaderText = "نام";
            this.studentFisrtName.Name = "studentFisrtName";
            this.studentFisrtName.Width = 55;
            // 
            // studentLastName
            // 
            this.studentLastName.HeaderText = "نام خانوادگی";
            this.studentLastName.Name = "studentLastName";
            this.studentLastName.Width = 115;
            // 
            // fatherName
            // 
            this.fatherName.HeaderText = "نام پدر";
            this.fatherName.Name = "fatherName";
            this.fatherName.Width = 78;
            // 
            // nCode
            // 
            this.nCode.HeaderText = "کد ملی";
            this.nCode.Name = "nCode";
            this.nCode.Width = 80;
            // 
            // phone
            // 
            this.phone.HeaderText = "تلفن همراه";
            this.phone.Name = "phone";
            this.phone.Width = 98;
            // 
            // parentPhone
            // 
            this.parentPhone.HeaderText = "تلفن والدین";
            this.parentPhone.Name = "parentPhone";
            this.parentPhone.Width = 104;
            // 
            // addStudent
            // 
            this.addStudent.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.Location = new System.Drawing.Point(235, 41);
            this.addStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(85, 32);
            this.addStudent.TabIndex = 4;
            this.addStudent.Text = "افزودن";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // teacherNameKey
            // 
            this.teacherNameKey.AutoSize = true;
            this.teacherNameKey.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.teacherNameKey.Location = new System.Drawing.Point(330, 236);
            this.teacherNameKey.Name = "teacherNameKey";
            this.teacherNameKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.teacherNameKey.Size = new System.Drawing.Size(78, 25);
            this.teacherNameKey.TabIndex = 4;
            this.teacherNameKey.Text = "نام استاد :";
            // 
            // teacherNameValue
            // 
            this.teacherNameValue.AutoSize = true;
            this.teacherNameValue.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.teacherNameValue.Location = new System.Drawing.Point(202, 236);
            this.teacherNameValue.Name = "teacherNameValue";
            this.teacherNameValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.teacherNameValue.Size = new System.Drawing.Size(126, 25);
            this.teacherNameValue.TabIndex = 5;
            this.teacherNameValue.Text = "نام و نام خانوادگی";
            // 
            // teacherIDKey
            // 
            this.teacherIDKey.AutoSize = true;
            this.teacherIDKey.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.teacherIDKey.Location = new System.Drawing.Point(299, 276);
            this.teacherIDKey.Name = "teacherIDKey";
            this.teacherIDKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.teacherIDKey.Size = new System.Drawing.Size(109, 25);
            this.teacherIDKey.TabIndex = 6;
            this.teacherIDKey.Text = "کد ملی استاد : ";
            // 
            // teacherIDValue
            // 
            this.teacherIDValue.AutoSize = true;
            this.teacherIDValue.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.teacherIDValue.Location = new System.Drawing.Point(199, 276);
            this.teacherIDValue.Name = "teacherIDValue";
            this.teacherIDValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.teacherIDValue.Size = new System.Drawing.Size(102, 25);
            this.teacherIDValue.TabIndex = 7;
            this.teacherIDValue.Text = "1123456789";
            // 
            // classCodeKey
            // 
            this.classCodeKey.AutoSize = true;
            this.classCodeKey.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.classCodeKey.Location = new System.Drawing.Point(326, 47);
            this.classCodeKey.Name = "classCodeKey";
            this.classCodeKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classCodeKey.Size = new System.Drawing.Size(82, 25);
            this.classCodeKey.TabIndex = 9;
            this.classCodeKey.Text = "کد کلاس : ";
            // 
            // classCodeValue
            // 
            this.classCodeValue.AutoSize = true;
            this.classCodeValue.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.classCodeValue.Location = new System.Drawing.Point(259, 47);
            this.classCodeValue.Name = "classCodeValue";
            this.classCodeValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classCodeValue.Size = new System.Drawing.Size(69, 25);
            this.classCodeValue.TabIndex = 10;
            this.classCodeValue.Text = "کد کلاس";
            // 
            // startTimeKey
            // 
            this.startTimeKey.AutoSize = true;
            this.startTimeKey.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.startTimeKey.Location = new System.Drawing.Point(307, 116);
            this.startTimeKey.Name = "startTimeKey";
            this.startTimeKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startTimeKey.Size = new System.Drawing.Size(101, 25);
            this.startTimeKey.TabIndex = 11;
            this.startTimeKey.Text = "ساعت شروع :";
            // 
            // startTimeValue
            // 
            this.startTimeValue.AutoSize = true;
            this.startTimeValue.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.startTimeValue.Location = new System.Drawing.Point(251, 116);
            this.startTimeValue.Name = "startTimeValue";
            this.startTimeValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startTimeValue.Size = new System.Drawing.Size(53, 25);
            this.startTimeValue.TabIndex = 12;
            this.startTimeValue.Text = "00:00";
            // 
            // endTimeKey
            // 
            this.endTimeKey.AutoSize = true;
            this.endTimeKey.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.endTimeKey.Location = new System.Drawing.Point(314, 155);
            this.endTimeKey.Name = "endTimeKey";
            this.endTimeKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endTimeKey.Size = new System.Drawing.Size(94, 25);
            this.endTimeKey.TabIndex = 13;
            this.endTimeKey.Text = "ساعت پایان :";
            // 
            // endTimeVAlue
            // 
            this.endTimeVAlue.AutoSize = true;
            this.endTimeVAlue.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.endTimeVAlue.Location = new System.Drawing.Point(251, 155);
            this.endTimeVAlue.Name = "endTimeVAlue";
            this.endTimeVAlue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endTimeVAlue.Size = new System.Drawing.Size(53, 25);
            this.endTimeVAlue.TabIndex = 14;
            this.endTimeVAlue.Text = "00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classProgress);
            this.groupBox1.Controls.Add(this.className);
            this.groupBox1.Controls.Add(this.ClassNameKey);
            this.groupBox1.Controls.Add(this.sessionCountValue);
            this.groupBox1.Controls.Add(this.sessionCountKey);
            this.groupBox1.Controls.Add(this.endTimeVAlue);
            this.groupBox1.Controls.Add(this.teacherNameKey);
            this.groupBox1.Controls.Add(this.endTimeKey);
            this.groupBox1.Controls.Add(this.teacherNameValue);
            this.groupBox1.Controls.Add(this.startTimeValue);
            this.groupBox1.Controls.Add(this.teacherIDKey);
            this.groupBox1.Controls.Add(this.startTimeKey);
            this.groupBox1.Controls.Add(this.teacherIDValue);
            this.groupBox1.Controls.Add(this.classCodeValue);
            this.groupBox1.Controls.Add(this.classCodeKey);
            this.groupBox1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(652, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(414, 323);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات کلاس";
            // 
            // classProgress
            // 
            this.classProgress.Location = new System.Drawing.Point(19, 198);
            this.classProgress.Name = "classProgress";
            this.classProgress.Size = new System.Drawing.Size(235, 23);
            this.classProgress.TabIndex = 19;
            // 
            // className
            // 
            this.className.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.className.Location = new System.Drawing.Point(121, 81);
            this.className.Name = "className";
            this.className.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.className.Size = new System.Drawing.Size(199, 25);
            this.className.TabIndex = 18;
            this.className.Text = "نام کلاس";
            // 
            // ClassNameKey
            // 
            this.ClassNameKey.AutoSize = true;
            this.ClassNameKey.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ClassNameKey.Location = new System.Drawing.Point(327, 81);
            this.ClassNameKey.Name = "ClassNameKey";
            this.ClassNameKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClassNameKey.Size = new System.Drawing.Size(81, 25);
            this.ClassNameKey.TabIndex = 17;
            this.ClassNameKey.Text = "نام کلاس :";
            // 
            // sessionCountValue
            // 
            this.sessionCountValue.AutoSize = true;
            this.sessionCountValue.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sessionCountValue.Location = new System.Drawing.Point(273, 196);
            this.sessionCountValue.Name = "sessionCountValue";
            this.sessionCountValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sessionCountValue.Size = new System.Drawing.Size(21, 25);
            this.sessionCountValue.TabIndex = 16;
            this.sessionCountValue.Text = "0";
            // 
            // sessionCountKey
            // 
            this.sessionCountKey.AutoSize = true;
            this.sessionCountKey.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sessionCountKey.Location = new System.Drawing.Point(300, 196);
            this.sessionCountKey.Name = "sessionCountKey";
            this.sessionCountKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sessionCountKey.Size = new System.Drawing.Size(108, 25);
            this.sessionCountKey.TabIndex = 15;
            this.sessionCountKey.Text = "تعداد جلسات :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.delInfo2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDeleteStudent);
            this.groupBox2.Controls.Add(this.boxIDDelete);
            this.groupBox2.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(652, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(414, 277);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حذف زبان آموز از کلاس";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(152, 136);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(251, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "نکته : این عملیات قابل بازگشت نیست";
            // 
            // delInfo2
            // 
            this.delInfo2.AutoSize = true;
            this.delInfo2.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.delInfo2.Location = new System.Drawing.Point(27, 102);
            this.delInfo2.Name = "delInfo2";
            this.delInfo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delInfo2.Size = new System.Drawing.Size(376, 25);
            this.delInfo2.TabIndex = 18;
            this.delInfo2.Text = "راهنما : کد ملی زبان آموز را وارد کرده و دکمه حذف را بزنید";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(350, 46);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "کد ملی";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(19, 43);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(89, 32);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "حذف";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // boxIDDelete
            // 
            this.boxIDDelete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.boxIDDelete.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIDDelete.Location = new System.Drawing.Point(121, 43);
            this.boxIDDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxIDDelete.Name = "boxIDDelete";
            this.boxIDDelete.Size = new System.Drawing.Size(224, 32);
            this.boxIDDelete.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.searchBox);
            this.groupBox3.Controls.Add(this.studntsListBox);
            this.groupBox3.Controls.Add(this.addStudent);
            this.groupBox3.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(9, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(627, 247);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "افزودن زبان آموز به کلاس";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(258, 89);
            this.label5.MaximumSize = new System.Drawing.Size(380, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(363, 75);
            this.label5.TabIndex = 22;
            this.label5.Text = "راهنما :  لیست زبان آموزانی که در این کلاس ثبت نشده اند در کادر رو به رو قرار دار" +
    "د با وارد کردن کد ملی آن ها و زدن دکمه افزودن آن ها را به این کلاس اضافه کنید";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(559, 45);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "کد ملی";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "خروجی اکسل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eachClassManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1078, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "eachClassManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت کلاس";
            this.Load += new System.EventHandler(this.eachClassManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListBox studntsListBox;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Label teacherNameKey;
        private System.Windows.Forms.Label teacherNameValue;
        private System.Windows.Forms.Label teacherIDKey;
        private System.Windows.Forms.Label teacherIDValue;
        private System.Windows.Forms.Label classCodeKey;
        private System.Windows.Forms.Label classCodeValue;
        private System.Windows.Forms.Label startTimeKey;
        private System.Windows.Forms.Label startTimeValue;
        private System.Windows.Forms.Label endTimeKey;
        private System.Windows.Forms.Label endTimeVAlue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sessionCountValue;
        private System.Windows.Forms.Label sessionCountKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.TextBox boxIDDelete;
        private System.Windows.Forms.Label className;
        private System.Windows.Forms.Label ClassNameKey;
        private System.Windows.Forms.Label delInfo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar classProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFisrtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog ExcelSaveDialog4;
    }
}