namespace Language_School_Management
{
    partial class studentsManageForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblhPhone = new System.Windows.Forms.Label();
            this.boxHphone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.boxPhone = new System.Windows.Forms.TextBox();
            this.lblParentPhone = new System.Windows.Forms.Label();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.boxParentPhone = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFather = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.FatherBox = new System.Windows.Forms.TextBox();
            this.lblLaName = new System.Windows.Forms.Label();
            this.LnameBox = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.FnameBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delInfo2 = new System.Windows.Forms.Label();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.delInfo1 = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.delBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.boxHphoneUpdate = new System.Windows.Forms.TextBox();
            this.boxPhoneUpdate = new System.Windows.Forms.TextBox();
            this.lblHphoneUpdate = new System.Windows.Forms.Label();
            this.lblPhoneUpdate = new System.Windows.Forms.Label();
            this.boxParentPhoneUpdate = new System.Windows.Forms.TextBox();
            this.lblParentPhoneUpdate = new System.Windows.Forms.Label();
            this.boxAddressUpdate = new System.Windows.Forms.TextBox();
            this.lblAddressUpdate = new System.Windows.Forms.Label();
            this.boxFatherUpdate = new System.Windows.Forms.TextBox();
            this.lblFatherUpdate = new System.Windows.Forms.Label();
            this.boxLanameUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateLaname = new System.Windows.Forms.Label();
            this.BoxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.btnInfoCall = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.boxIdUpdate = new System.Windows.Forms.TextBox();
            this.ExcelSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.excelOutput = new System.Windows.Forms.Button();
            this.pdfSaveDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.fatherName,
            this.nCode,
            this.phoneNumber,
            this.homePhone,
            this.parentPhone,
            this.homeAddress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(924, 537);
            this.dataGridView1.TabIndex = 0;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "نام";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.Width = 55;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "نام خانوادگی";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.Width = 115;
            // 
            // fatherName
            // 
            this.fatherName.HeaderText = "نام پدر";
            this.fatherName.MinimumWidth = 6;
            this.fatherName.Name = "fatherName";
            this.fatherName.Width = 78;
            // 
            // nCode
            // 
            this.nCode.HeaderText = "کد ملی";
            this.nCode.MinimumWidth = 6;
            this.nCode.Name = "nCode";
            this.nCode.Width = 80;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "تلفن همراه";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Width = 98;
            // 
            // homePhone
            // 
            this.homePhone.HeaderText = "تلفن منزل";
            this.homePhone.MinimumWidth = 6;
            this.homePhone.Name = "homePhone";
            this.homePhone.Width = 94;
            // 
            // parentPhone
            // 
            this.parentPhone.HeaderText = "تلفن والدین";
            this.parentPhone.MinimumWidth = 6;
            this.parentPhone.Name = "parentPhone";
            this.parentPhone.Width = 104;
            // 
            // homeAddress
            // 
            this.homeAddress.HeaderText = "آدرس منزل";
            this.homeAddress.MinimumWidth = 6;
            this.homeAddress.Name = "homeAddress";
            this.homeAddress.Width = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblhPhone);
            this.groupBox1.Controls.Add(this.boxHphone);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.boxPhone);
            this.groupBox1.Controls.Add(this.lblParentPhone);
            this.groupBox1.Controls.Add(this.IDbox);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.boxParentPhone);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblFather);
            this.groupBox1.Controls.Add(this.AddressBox);
            this.groupBox1.Controls.Add(this.FatherBox);
            this.groupBox1.Controls.Add(this.lblLaName);
            this.groupBox1.Controls.Add(this.LnameBox);
            this.groupBox1.Controls.Add(this.lblFname);
            this.groupBox1.Controls.Add(this.FnameBox);
            this.groupBox1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(973, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(687, 657);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت زبان آموز";
            // 
            // lblhPhone
            // 
            this.lblhPhone.Location = new System.Drawing.Point(479, 522);
            this.lblhPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhPhone.Name = "lblhPhone";
            this.lblhPhone.Size = new System.Drawing.Size(195, 36);
            this.lblhPhone.TabIndex = 14;
            this.lblhPhone.Text = "تلفن ثابت";
            // 
            // boxHphone
            // 
            this.boxHphone.Location = new System.Drawing.Point(44, 518);
            this.boxHphone.Margin = new System.Windows.Forms.Padding(4);
            this.boxHphone.Name = "boxHphone";
            this.boxHphone.Size = new System.Drawing.Size(425, 32);
            this.boxHphone.TabIndex = 15;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(479, 453);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(195, 36);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "تلفن همراه";
            // 
            // boxPhone
            // 
            this.boxPhone.Location = new System.Drawing.Point(44, 449);
            this.boxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(425, 32);
            this.boxPhone.TabIndex = 13;
            // 
            // lblParentPhone
            // 
            this.lblParentPhone.Location = new System.Drawing.Point(479, 308);
            this.lblParentPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParentPhone.Name = "lblParentPhone";
            this.lblParentPhone.Size = new System.Drawing.Size(195, 36);
            this.lblParentPhone.TabIndex = 8;
            this.lblParentPhone.Text = "تلفن والدین";
            // 
            // IDbox
            // 
            this.IDbox.Location = new System.Drawing.Point(44, 382);
            this.IDbox.Margin = new System.Windows.Forms.Padding(4);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(425, 32);
            this.IDbox.TabIndex = 11;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(479, 382);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(195, 36);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "کد ملی";
            // 
            // boxParentPhone
            // 
            this.boxParentPhone.Location = new System.Drawing.Point(44, 308);
            this.boxParentPhone.Margin = new System.Windows.Forms.Padding(4);
            this.boxParentPhone.Name = "boxParentPhone";
            this.boxParentPhone.Size = new System.Drawing.Size(425, 32);
            this.boxParentPhone.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(348, 582);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 44);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "پاکسازی";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(44, 582);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 44);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(479, 239);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(195, 36);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "آدرس محل سکونت";
            // 
            // lblFather
            // 
            this.lblFather.Location = new System.Drawing.Point(499, 169);
            this.lblFather.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(175, 36);
            this.lblFather.TabIndex = 4;
            this.lblFather.Text = "نام پدر";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(44, 235);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(425, 32);
            this.AddressBox.TabIndex = 7;
            // 
            // FatherBox
            // 
            this.FatherBox.Location = new System.Drawing.Point(44, 165);
            this.FatherBox.Margin = new System.Windows.Forms.Padding(4);
            this.FatherBox.Name = "FatherBox";
            this.FatherBox.Size = new System.Drawing.Size(425, 32);
            this.FatherBox.TabIndex = 5;
            // 
            // lblLaName
            // 
            this.lblLaName.Location = new System.Drawing.Point(535, 105);
            this.lblLaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaName.Name = "lblLaName";
            this.lblLaName.Size = new System.Drawing.Size(139, 36);
            this.lblLaName.TabIndex = 2;
            this.lblLaName.Text = "نام خانوادگی";
            // 
            // LnameBox
            // 
            this.LnameBox.Location = new System.Drawing.Point(44, 101);
            this.LnameBox.Margin = new System.Windows.Forms.Padding(4);
            this.LnameBox.Name = "LnameBox";
            this.LnameBox.Size = new System.Drawing.Size(425, 32);
            this.LnameBox.TabIndex = 3;
            // 
            // lblFname
            // 
            this.lblFname.Location = new System.Drawing.Point(499, 38);
            this.lblFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(175, 36);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "نام";
            // 
            // FnameBox
            // 
            this.FnameBox.Location = new System.Drawing.Point(44, 38);
            this.FnameBox.Margin = new System.Windows.Forms.Padding(4);
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(425, 32);
            this.FnameBox.TabIndex = 1;
            this.FnameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.delInfo2);
            this.groupBox2.Controls.Add(this.btnDeleteRecord);
            this.groupBox2.Controls.Add(this.delInfo1);
            this.groupBox2.Controls.Add(this.lblDe);
            this.groupBox2.Controls.Add(this.delBox);
            this.groupBox2.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(973, 704);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(687, 261);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حذف زبان آموز";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(332, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "نکته : این عملیات قابل بازگشت نیست";
            // 
            // delInfo2
            // 
            this.delInfo2.AutoSize = true;
            this.delInfo2.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.delInfo2.Location = new System.Drawing.Point(165, 129);
            this.delInfo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delInfo2.Name = "delInfo2";
            this.delInfo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delInfo2.Size = new System.Drawing.Size(376, 25);
            this.delInfo2.TabIndex = 3;
            this.delInfo2.Text = "راهنما : کد ملی زبان آموز را وارد کرده و دکمه حذف را بزنید";
            this.delInfo2.Click += new System.EventHandler(this.delInfo2_Click);
            this.delInfo2.MouseHover += new System.EventHandler(this.delInfo2_MouseHover);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(29, 57);
            this.btnDeleteRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(120, 39);
            this.btnDeleteRecord.TabIndex = 1;
            this.btnDeleteRecord.Text = "حذف";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // delInfo1
            // 
            this.delInfo1.AutoSize = true;
            this.delInfo1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.delInfo1.Location = new System.Drawing.Point(565, 145);
            this.delInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delInfo1.Name = "delInfo1";
            this.delInfo1.Size = new System.Drawing.Size(0, 25);
            this.delInfo1.TabIndex = 2;
            this.delInfo1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(596, 60);
            this.lblDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(58, 25);
            this.lblDe.TabIndex = 1;
            this.lblDe.Text = "کد ملی";
            // 
            // delBox
            // 
            this.delBox.Location = new System.Drawing.Point(169, 57);
            this.delBox.Margin = new System.Windows.Forms.Padding(4);
            this.delBox.Name = "delBox";
            this.delBox.Size = new System.Drawing.Size(388, 32);
            this.delBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.boxHphoneUpdate);
            this.groupBox3.Controls.Add(this.boxPhoneUpdate);
            this.groupBox3.Controls.Add(this.lblHphoneUpdate);
            this.groupBox3.Controls.Add(this.lblPhoneUpdate);
            this.groupBox3.Controls.Add(this.boxParentPhoneUpdate);
            this.groupBox3.Controls.Add(this.lblParentPhoneUpdate);
            this.groupBox3.Controls.Add(this.boxAddressUpdate);
            this.groupBox3.Controls.Add(this.lblAddressUpdate);
            this.groupBox3.Controls.Add(this.boxFatherUpdate);
            this.groupBox3.Controls.Add(this.lblFatherUpdate);
            this.groupBox3.Controls.Add(this.boxLanameUpdate);
            this.groupBox3.Controls.Add(this.lblUpdateLaname);
            this.groupBox3.Controls.Add(this.BoxNameUpdate);
            this.groupBox3.Controls.Add(this.lblNameUpdate);
            this.groupBox3.Controls.Add(this.btnInfoCall);
            this.groupBox3.Controls.Add(this.lblUpdate);
            this.groupBox3.Controls.Add(this.boxIdUpdate);
            this.groupBox3.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(16, 614);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(937, 351);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ویرایش زبان آموز";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "ویرایش";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // boxHphoneUpdate
            // 
            this.boxHphoneUpdate.Location = new System.Drawing.Point(29, 233);
            this.boxHphoneUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.boxHphoneUpdate.Name = "boxHphoneUpdate";
            this.boxHphoneUpdate.Size = new System.Drawing.Size(263, 32);
            this.boxHphoneUpdate.TabIndex = 16;
            // 
            // boxPhoneUpdate
            // 
            this.boxPhoneUpdate.Location = new System.Drawing.Point(545, 228);
            this.boxPhoneUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.boxPhoneUpdate.Name = "boxPhoneUpdate";
            this.boxPhoneUpdate.Size = new System.Drawing.Size(263, 32);
            this.boxPhoneUpdate.TabIndex = 15;
            // 
            // lblHphoneUpdate
            // 
            this.lblHphoneUpdate.AutoSize = true;
            this.lblHphoneUpdate.Location = new System.Drawing.Point(320, 236);
            this.lblHphoneUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHphoneUpdate.Name = "lblHphoneUpdate";
            this.lblHphoneUpdate.Size = new System.Drawing.Size(78, 25);
            this.lblHphoneUpdate.TabIndex = 14;
            this.lblHphoneUpdate.Text = "تلفن ثابت";
            // 
            // lblPhoneUpdate
            // 
            this.lblPhoneUpdate.AutoSize = true;
            this.lblPhoneUpdate.Location = new System.Drawing.Point(817, 231);
            this.lblPhoneUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneUpdate.Name = "lblPhoneUpdate";
            this.lblPhoneUpdate.Size = new System.Drawing.Size(85, 25);
            this.lblPhoneUpdate.TabIndex = 13;
            this.lblPhoneUpdate.Text = "تلفن همراه";
            // 
            // boxParentPhoneUpdate
            // 
            this.boxParentPhoneUpdate.Location = new System.Drawing.Point(29, 178);
            this.boxParentPhoneUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.boxParentPhoneUpdate.Name = "boxParentPhoneUpdate";
            this.boxParentPhoneUpdate.Size = new System.Drawing.Size(263, 32);
            this.boxParentPhoneUpdate.TabIndex = 12;
            // 
            // lblParentPhoneUpdate
            // 
            this.lblParentPhoneUpdate.AutoSize = true;
            this.lblParentPhoneUpdate.Location = new System.Drawing.Point(304, 182);
            this.lblParentPhoneUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParentPhoneUpdate.Name = "lblParentPhoneUpdate";
            this.lblParentPhoneUpdate.Size = new System.Drawing.Size(90, 25);
            this.lblParentPhoneUpdate.TabIndex = 11;
            this.lblParentPhoneUpdate.Text = "تلفن والدین";
            // 
            // boxAddressUpdate
            // 
            this.boxAddressUpdate.Location = new System.Drawing.Point(545, 175);
            this.boxAddressUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.boxAddressUpdate.Name = "boxAddressUpdate";
            this.boxAddressUpdate.Size = new System.Drawing.Size(263, 32);
            this.boxAddressUpdate.TabIndex = 10;
            // 
            // lblAddressUpdate
            // 
            this.lblAddressUpdate.AutoSize = true;
            this.lblAddressUpdate.Location = new System.Drawing.Point(857, 183);
            this.lblAddressUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressUpdate.Name = "lblAddressUpdate";
            this.lblAddressUpdate.Size = new System.Drawing.Size(50, 25);
            this.lblAddressUpdate.TabIndex = 9;
            this.lblAddressUpdate.Text = "آدرس";
            // 
            // boxFatherUpdate
            // 
            this.boxFatherUpdate.Location = new System.Drawing.Point(29, 63);
            this.boxFatherUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.boxFatherUpdate.Name = "boxFatherUpdate";
            this.boxFatherUpdate.Size = new System.Drawing.Size(263, 32);
            this.boxFatherUpdate.TabIndex = 8;
            // 
            // lblFatherUpdate
            // 
            this.lblFatherUpdate.AutoSize = true;
            this.lblFatherUpdate.Location = new System.Drawing.Point(301, 65);
            this.lblFatherUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFatherUpdate.Name = "lblFatherUpdate";
            this.lblFatherUpdate.Size = new System.Drawing.Size(55, 25);
            this.lblFatherUpdate.TabIndex = 7;
            this.lblFatherUpdate.Text = "نام پدر";
            // 
            // boxLanameUpdate
            // 
            this.boxLanameUpdate.Location = new System.Drawing.Point(29, 122);
            this.boxLanameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.boxLanameUpdate.Name = "boxLanameUpdate";
            this.boxLanameUpdate.Size = new System.Drawing.Size(263, 32);
            this.boxLanameUpdate.TabIndex = 6;
            // 
            // lblUpdateLaname
            // 
            this.lblUpdateLaname.AutoSize = true;
            this.lblUpdateLaname.Location = new System.Drawing.Point(301, 126);
            this.lblUpdateLaname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateLaname.Name = "lblUpdateLaname";
            this.lblUpdateLaname.Size = new System.Drawing.Size(92, 25);
            this.lblUpdateLaname.TabIndex = 5;
            this.lblUpdateLaname.Text = "نام خانوادگی";
            // 
            // BoxNameUpdate
            // 
            this.BoxNameUpdate.Location = new System.Drawing.Point(545, 122);
            this.BoxNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BoxNameUpdate.Name = "BoxNameUpdate";
            this.BoxNameUpdate.Size = new System.Drawing.Size(263, 32);
            this.BoxNameUpdate.TabIndex = 4;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(883, 126);
            this.lblNameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(31, 25);
            this.lblNameUpdate.TabIndex = 3;
            this.lblNameUpdate.Text = "نام";
            // 
            // btnInfoCall
            // 
            this.btnInfoCall.Location = new System.Drawing.Point(383, 60);
            this.btnInfoCall.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfoCall.Name = "btnInfoCall";
            this.btnInfoCall.Size = new System.Drawing.Size(139, 39);
            this.btnInfoCall.TabIndex = 2;
            this.btnInfoCall.Text = "فراخوانی";
            this.btnInfoCall.UseVisualStyleBackColor = true;
            this.btnInfoCall.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(847, 66);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(58, 25);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = "کد ملی";
            // 
            // boxIdUpdate
            // 
            this.boxIdUpdate.Location = new System.Drawing.Point(545, 60);
            this.boxIdUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.boxIdUpdate.Name = "boxIdUpdate";
            this.boxIdUpdate.Size = new System.Drawing.Size(263, 32);
            this.boxIdUpdate.TabIndex = 0;
            // 
            // excelOutput
            // 
            this.excelOutput.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelOutput.Location = new System.Drawing.Point(16, 571);
            this.excelOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excelOutput.Name = "excelOutput";
            this.excelOutput.Size = new System.Drawing.Size(148, 46);
            this.excelOutput.TabIndex = 4;
            this.excelOutput.Text = "خروجی اکسل";
            this.excelOutput.UseVisualStyleBackColor = true;
            this.excelOutput.Click += new System.EventHandler(this.excelOutput_Click);
            // 
            // studentsManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1688, 982);
            this.Controls.Add(this.excelOutput);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "studentsManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت زبان آموزان";
            this.Load += new System.EventHandler(this.studentsManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox FnameBox;
        private System.Windows.Forms.Label lblFather;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox FatherBox;
        private System.Windows.Forms.Label lblLaName;
        private System.Windows.Forms.TextBox LnameBox;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox boxParentPhone;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.TextBox delBox;
        private System.Windows.Forms.Label delInfo1;
        private System.Windows.Forms.Label delInfo2;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblParentPhone;
        private System.Windows.Forms.TextBox boxHphone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox boxPhone;
        private System.Windows.Forms.Label lblhPhone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.TextBox boxIdUpdate;
        private System.Windows.Forms.TextBox BoxNameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Button btnInfoCall;
        private System.Windows.Forms.TextBox boxAddressUpdate;
        private System.Windows.Forms.Label lblAddressUpdate;
        private System.Windows.Forms.TextBox boxFatherUpdate;
        private System.Windows.Forms.Label lblFatherUpdate;
        private System.Windows.Forms.TextBox boxLanameUpdate;
        private System.Windows.Forms.Label lblUpdateLaname;
        private System.Windows.Forms.TextBox boxHphoneUpdate;
        private System.Windows.Forms.TextBox boxPhoneUpdate;
        private System.Windows.Forms.Label lblHphoneUpdate;
        private System.Windows.Forms.Label lblPhoneUpdate;
        private System.Windows.Forms.TextBox boxParentPhoneUpdate;
        private System.Windows.Forms.Label lblParentPhoneUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn homePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAddress;
        private System.Windows.Forms.SaveFileDialog ExcelSaveDialog;
        private System.Windows.Forms.Button excelOutput;
        private System.Windows.Forms.SaveFileDialog pdfSaveDialog;
    }
}