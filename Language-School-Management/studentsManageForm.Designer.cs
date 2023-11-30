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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFather = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.FatherBox = new System.Windows.Forms.TextBox();
            this.lblLaName = new System.Windows.Forms.Label();
            this.LnameBox = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.FnameBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.boxPhone = new System.Windows.Forms.TextBox();
            this.boxID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.bdayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bdayBox);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.boxID);
            this.groupBox1.Controls.Add(this.boxPhone);
            this.groupBox1.Controls.Add(this.lblPhone);
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
            this.groupBox1.Location = new System.Drawing.Point(730, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(515, 477);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت زبان آموز";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(33, 418);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 36);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(359, 194);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(146, 29);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "آدرس محل سکونت";
            // 
            // lblFather
            // 
            this.lblFather.Location = new System.Drawing.Point(374, 137);
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(131, 29);
            this.lblFather.TabIndex = 6;
            this.lblFather.Text = "نام پدر";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(33, 191);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(305, 32);
            this.AddressBox.TabIndex = 5;
            // 
            // FatherBox
            // 
            this.FatherBox.Location = new System.Drawing.Point(33, 134);
            this.FatherBox.Name = "FatherBox";
            this.FatherBox.Size = new System.Drawing.Size(305, 32);
            this.FatherBox.TabIndex = 4;
            // 
            // lblLaName
            // 
            this.lblLaName.Location = new System.Drawing.Point(401, 85);
            this.lblLaName.Name = "lblLaName";
            this.lblLaName.Size = new System.Drawing.Size(104, 29);
            this.lblLaName.TabIndex = 3;
            this.lblLaName.Text = "نام خانوادگی";
            // 
            // LnameBox
            // 
            this.LnameBox.Location = new System.Drawing.Point(33, 82);
            this.LnameBox.Name = "LnameBox";
            this.LnameBox.Size = new System.Drawing.Size(305, 32);
            this.LnameBox.TabIndex = 2;
            // 
            // lblFname
            // 
            this.lblFname.Location = new System.Drawing.Point(374, 31);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(131, 29);
            this.lblFname.TabIndex = 1;
            this.lblFname.Text = "نام";
            // 
            // FnameBox
            // 
            this.FnameBox.Location = new System.Drawing.Point(33, 31);
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(305, 32);
            this.FnameBox.TabIndex = 0;
            this.FnameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(246, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "پاکسازی";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(359, 253);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(146, 29);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "تلفن همراه";
            // 
            // boxPhone
            // 
            this.boxPhone.Location = new System.Drawing.Point(33, 250);
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(305, 32);
            this.boxPhone.TabIndex = 13;
            // 
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(33, 307);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(305, 32);
            this.boxID.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(359, 310);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(146, 29);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "کد ملی";
            // 
            // bdayBox
            // 
            this.bdayBox.Location = new System.Drawing.Point(33, 363);
            this.bdayBox.Name = "bdayBox";
            this.bdayBox.Size = new System.Drawing.Size(305, 32);
            this.bdayBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(359, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "تاریخ تولد";
            // 
            // studentsManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1266, 783);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "studentsManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت زبان آموزان";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.TextBox boxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bdayBox;
    }
}