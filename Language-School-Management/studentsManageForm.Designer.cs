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
            this.lblRegDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.FullNameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblRegDate);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.AddressBox);
            this.groupBox1.Controls.Add(this.PhoneBox);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.IdBox);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Controls.Add(this.FullNameBox);
            this.groupBox1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(725, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(515, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت زبان آموز";
            // 
            // lblRegDate
            // 
            this.lblRegDate.Location = new System.Drawing.Point(359, 248);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(131, 29);
            this.lblRegDate.TabIndex = 10;
            this.lblRegDate.Text = "تاریخ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 32);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(359, 194);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(131, 29);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "آدرس";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(359, 137);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(131, 29);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "تلفن همراه";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(33, 191);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(305, 32);
            this.AddressBox.TabIndex = 5;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(33, 134);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(305, 32);
            this.PhoneBox.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(386, 85);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(104, 29);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "کد ملی";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(33, 82);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(305, 32);
            this.IdBox.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.Location = new System.Drawing.Point(359, 34);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(131, 29);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "نام و نام خانوادگی";
            // 
            // FullNameBox
            // 
            this.FullNameBox.Location = new System.Drawing.Point(33, 31);
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.Size = new System.Drawing.Size(305, 32);
            this.FullNameBox.TabIndex = 0;
            this.FullNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox FullNameBox;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRegDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}