﻿namespace Language_School_Management
{
    partial class teachersManageForm
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
            this.TeachersdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTeachName = new System.Windows.Forms.Label();
            this.boxTeachName = new System.Windows.Forms.TextBox();
            this.boxTeachLname = new System.Windows.Forms.TextBox();
            this.lblTeachLname = new System.Windows.Forms.Label();
            this.lblTeachFatherName = new System.Windows.Forms.Label();
            this.boxTeachFathName = new System.Windows.Forms.TextBox();
            this.lblTeachID = new System.Windows.Forms.Label();
            this.boxTeachID = new System.Windows.Forms.TextBox();
            this.boxTeachPhone = new System.Windows.Forms.TextBox();
            this.lblTeachPhone = new System.Windows.Forms.Label();
            this.boxTeachDocument = new System.Windows.Forms.TextBox();
            this.lblTeachDocumnet = new System.Windows.Forms.Label();
            this.boxTeachAddress = new System.Windows.Forms.TextBox();
            this.lblTeachAddress = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BoxTeachIDdel = new System.Windows.Forms.TextBox();
            this.lblTeachIDdel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTeachDel = new System.Windows.Forms.Button();
            this.btnExcelOutput = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTeachIdUpdate = new System.Windows.Forms.Label();
            this.boxTeachIDUpdate = new System.Windows.Forms.TextBox();
            this.lblTeachFathNameUpdate = new System.Windows.Forms.Label();
            this.boxFathUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.boxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblFnameUpdate = new System.Windows.Forms.Label();
            this.boxFnameUpdate = new System.Windows.Forms.TextBox();
            this.lblPhoneUpdate = new System.Windows.Forms.Label();
            this.boxAddressUpdate = new System.Windows.Forms.TextBox();
            this.boxPhoneUpdate = new System.Windows.Forms.TextBox();
            this.lblAddressUpdate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCallInfo = new System.Windows.Forms.Button();
            this.ExcelSaveDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeachersdataGridView
            // 
            this.TeachersdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TeachersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersdataGridView.Location = new System.Drawing.Point(12, 12);
            this.TeachersdataGridView.Name = "TeachersdataGridView";
            this.TeachersdataGridView.Size = new System.Drawing.Size(689, 419);
            this.TeachersdataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTeachAddress);
            this.groupBox1.Controls.Add(this.boxTeachAddress);
            this.groupBox1.Controls.Add(this.lblTeachDocumnet);
            this.groupBox1.Controls.Add(this.boxTeachDocument);
            this.groupBox1.Controls.Add(this.lblTeachPhone);
            this.groupBox1.Controls.Add(this.boxTeachPhone);
            this.groupBox1.Controls.Add(this.boxTeachID);
            this.groupBox1.Controls.Add(this.lblTeachID);
            this.groupBox1.Controls.Add(this.boxTeachFathName);
            this.groupBox1.Controls.Add(this.lblTeachFatherName);
            this.groupBox1.Controls.Add(this.lblTeachLname);
            this.groupBox1.Controls.Add(this.boxTeachLname);
            this.groupBox1.Controls.Add(this.boxTeachName);
            this.groupBox1.Controls.Add(this.lblTeachName);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Location = new System.Drawing.Point(719, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(470, 498);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت استاد";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(39, 420);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 39);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(245, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 39);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "پاکسازی";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTeachName
            // 
            this.lblTeachName.AutoSize = true;
            this.lblTeachName.Location = new System.Drawing.Point(433, 39);
            this.lblTeachName.Name = "lblTeachName";
            this.lblTeachName.Size = new System.Drawing.Size(31, 25);
            this.lblTeachName.TabIndex = 2;
            this.lblTeachName.Text = "نام";
            // 
            // boxTeachName
            // 
            this.boxTeachName.Location = new System.Drawing.Point(39, 36);
            this.boxTeachName.Name = "boxTeachName";
            this.boxTeachName.Size = new System.Drawing.Size(304, 32);
            this.boxTeachName.TabIndex = 3;
            // 
            // boxTeachLname
            // 
            this.boxTeachLname.Location = new System.Drawing.Point(39, 88);
            this.boxTeachLname.Name = "boxTeachLname";
            this.boxTeachLname.Size = new System.Drawing.Size(304, 32);
            this.boxTeachLname.TabIndex = 4;
            // 
            // lblTeachLname
            // 
            this.lblTeachLname.AutoSize = true;
            this.lblTeachLname.Location = new System.Drawing.Point(372, 91);
            this.lblTeachLname.Name = "lblTeachLname";
            this.lblTeachLname.Size = new System.Drawing.Size(92, 25);
            this.lblTeachLname.TabIndex = 5;
            this.lblTeachLname.Text = "نام خانوادگی";
            // 
            // lblTeachFatherName
            // 
            this.lblTeachFatherName.AutoSize = true;
            this.lblTeachFatherName.Location = new System.Drawing.Point(409, 143);
            this.lblTeachFatherName.Name = "lblTeachFatherName";
            this.lblTeachFatherName.Size = new System.Drawing.Size(55, 25);
            this.lblTeachFatherName.TabIndex = 6;
            this.lblTeachFatherName.Text = "نام پدر";
            // 
            // boxTeachFathName
            // 
            this.boxTeachFathName.Location = new System.Drawing.Point(39, 140);
            this.boxTeachFathName.Name = "boxTeachFathName";
            this.boxTeachFathName.Size = new System.Drawing.Size(304, 32);
            this.boxTeachFathName.TabIndex = 7;
            // 
            // lblTeachID
            // 
            this.lblTeachID.AutoSize = true;
            this.lblTeachID.Location = new System.Drawing.Point(406, 196);
            this.lblTeachID.Name = "lblTeachID";
            this.lblTeachID.Size = new System.Drawing.Size(58, 25);
            this.lblTeachID.TabIndex = 8;
            this.lblTeachID.Text = "کد ملی";
            // 
            // boxTeachID
            // 
            this.boxTeachID.Location = new System.Drawing.Point(39, 193);
            this.boxTeachID.Name = "boxTeachID";
            this.boxTeachID.Size = new System.Drawing.Size(304, 32);
            this.boxTeachID.TabIndex = 9;
            // 
            // boxTeachPhone
            // 
            this.boxTeachPhone.Location = new System.Drawing.Point(39, 246);
            this.boxTeachPhone.Name = "boxTeachPhone";
            this.boxTeachPhone.Size = new System.Drawing.Size(304, 32);
            this.boxTeachPhone.TabIndex = 10;
            // 
            // lblTeachPhone
            // 
            this.lblTeachPhone.AutoSize = true;
            this.lblTeachPhone.Location = new System.Drawing.Point(379, 249);
            this.lblTeachPhone.Name = "lblTeachPhone";
            this.lblTeachPhone.Size = new System.Drawing.Size(85, 25);
            this.lblTeachPhone.TabIndex = 11;
            this.lblTeachPhone.Text = "تلفن همراه";
            // 
            // boxTeachDocument
            // 
            this.boxTeachDocument.Location = new System.Drawing.Point(39, 300);
            this.boxTeachDocument.Name = "boxTeachDocument";
            this.boxTeachDocument.Size = new System.Drawing.Size(304, 32);
            this.boxTeachDocument.TabIndex = 12;
            // 
            // lblTeachDocumnet
            // 
            this.lblTeachDocumnet.AutoSize = true;
            this.lblTeachDocumnet.Location = new System.Drawing.Point(358, 303);
            this.lblTeachDocumnet.Name = "lblTeachDocumnet";
            this.lblTeachDocumnet.Size = new System.Drawing.Size(106, 25);
            this.lblTeachDocumnet.TabIndex = 13;
            this.lblTeachDocumnet.Text = "مدرک تحصیلی";
            // 
            // boxTeachAddress
            // 
            this.boxTeachAddress.Location = new System.Drawing.Point(39, 355);
            this.boxTeachAddress.Name = "boxTeachAddress";
            this.boxTeachAddress.Size = new System.Drawing.Size(304, 32);
            this.boxTeachAddress.TabIndex = 14;
            // 
            // lblTeachAddress
            // 
            this.lblTeachAddress.AutoSize = true;
            this.lblTeachAddress.Location = new System.Drawing.Point(414, 358);
            this.lblTeachAddress.Name = "lblTeachAddress";
            this.lblTeachAddress.Size = new System.Drawing.Size(50, 25);
            this.lblTeachAddress.TabIndex = 15;
            this.lblTeachAddress.Text = "آدرس";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTeachDel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTeachIDdel);
            this.groupBox2.Controls.Add(this.BoxTeachIDdel);
            this.groupBox2.Location = new System.Drawing.Point(719, 517);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(470, 211);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حذف استاد";
            // 
            // BoxTeachIDdel
            // 
            this.BoxTeachIDdel.Location = new System.Drawing.Point(129, 50);
            this.BoxTeachIDdel.Name = "BoxTeachIDdel";
            this.BoxTeachIDdel.Size = new System.Drawing.Size(247, 32);
            this.BoxTeachIDdel.TabIndex = 16;
            // 
            // lblTeachIDdel
            // 
            this.lblTeachIDdel.AutoSize = true;
            this.lblTeachIDdel.Location = new System.Drawing.Point(397, 53);
            this.lblTeachIDdel.Name = "lblTeachIDdel";
            this.lblTeachIDdel.Size = new System.Drawing.Size(58, 25);
            this.lblTeachIDdel.TabIndex = 16;
            this.lblTeachIDdel.Text = "کد ملی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(98, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "راهنما : کد ملی استاد را وارد کرده و دکمه حذف را بزنید ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(200, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "نکته : این عملیات قابل بازگشت نیست ";
            // 
            // btnTeachDel
            // 
            this.btnTeachDel.Location = new System.Drawing.Point(22, 50);
            this.btnTeachDel.Name = "btnTeachDel";
            this.btnTeachDel.Size = new System.Drawing.Size(101, 32);
            this.btnTeachDel.TabIndex = 16;
            this.btnTeachDel.Text = "حذف";
            this.btnTeachDel.UseVisualStyleBackColor = true;
            // 
            // btnExcelOutput
            // 
            this.btnExcelOutput.Location = new System.Drawing.Point(12, 437);
            this.btnExcelOutput.Name = "btnExcelOutput";
            this.btnExcelOutput.Size = new System.Drawing.Size(107, 35);
            this.btnExcelOutput.TabIndex = 16;
            this.btnExcelOutput.Text = "خروجی اکسل";
            this.btnExcelOutput.UseVisualStyleBackColor = true;
            this.btnExcelOutput.Click += new System.EventHandler(this.btnExcelOutput_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCallInfo);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblAddressUpdate);
            this.groupBox3.Controls.Add(this.boxPhoneUpdate);
            this.groupBox3.Controls.Add(this.lblPhoneUpdate);
            this.groupBox3.Controls.Add(this.boxAddressUpdate);
            this.groupBox3.Controls.Add(this.lblFnameUpdate);
            this.groupBox3.Controls.Add(this.boxFnameUpdate);
            this.groupBox3.Controls.Add(this.lblNameUpdate);
            this.groupBox3.Controls.Add(this.boxNameUpdate);
            this.groupBox3.Controls.Add(this.lblTeachFathNameUpdate);
            this.groupBox3.Controls.Add(this.boxFathUpdate);
            this.groupBox3.Controls.Add(this.lblTeachIdUpdate);
            this.groupBox3.Controls.Add(this.boxTeachIDUpdate);
            this.groupBox3.Location = new System.Drawing.Point(13, 478);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(688, 250);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "حذف استاد";
            // 
            // lblTeachIdUpdate
            // 
            this.lblTeachIdUpdate.AutoSize = true;
            this.lblTeachIdUpdate.Location = new System.Drawing.Point(614, 42);
            this.lblTeachIdUpdate.Name = "lblTeachIdUpdate";
            this.lblTeachIdUpdate.Size = new System.Drawing.Size(58, 25);
            this.lblTeachIdUpdate.TabIndex = 19;
            this.lblTeachIdUpdate.Text = "کد ملی";
            // 
            // boxTeachIDUpdate
            // 
            this.boxTeachIDUpdate.Location = new System.Drawing.Point(412, 39);
            this.boxTeachIDUpdate.Name = "boxTeachIDUpdate";
            this.boxTeachIDUpdate.Size = new System.Drawing.Size(196, 32);
            this.boxTeachIDUpdate.TabIndex = 20;
            // 
            // lblTeachFathNameUpdate
            // 
            this.lblTeachFathNameUpdate.AutoSize = true;
            this.lblTeachFathNameUpdate.Location = new System.Drawing.Point(617, 91);
            this.lblTeachFathNameUpdate.Name = "lblTeachFathNameUpdate";
            this.lblTeachFathNameUpdate.Size = new System.Drawing.Size(55, 25);
            this.lblTeachFathNameUpdate.TabIndex = 21;
            this.lblTeachFathNameUpdate.Text = "نام پدر";
            // 
            // boxFathUpdate
            // 
            this.boxFathUpdate.Location = new System.Drawing.Point(412, 88);
            this.boxFathUpdate.Name = "boxFathUpdate";
            this.boxFathUpdate.Size = new System.Drawing.Size(196, 32);
            this.boxFathUpdate.TabIndex = 22;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(641, 139);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(31, 25);
            this.lblNameUpdate.TabIndex = 23;
            this.lblNameUpdate.Text = "نام";
            // 
            // boxNameUpdate
            // 
            this.boxNameUpdate.Location = new System.Drawing.Point(412, 136);
            this.boxNameUpdate.Name = "boxNameUpdate";
            this.boxNameUpdate.Size = new System.Drawing.Size(196, 32);
            this.boxNameUpdate.TabIndex = 24;
            // 
            // lblFnameUpdate
            // 
            this.lblFnameUpdate.AutoSize = true;
            this.lblFnameUpdate.Location = new System.Drawing.Point(252, 42);
            this.lblFnameUpdate.Name = "lblFnameUpdate";
            this.lblFnameUpdate.Size = new System.Drawing.Size(92, 25);
            this.lblFnameUpdate.TabIndex = 25;
            this.lblFnameUpdate.Text = "نام خانوادگی";
            // 
            // boxFnameUpdate
            // 
            this.boxFnameUpdate.Location = new System.Drawing.Point(21, 39);
            this.boxFnameUpdate.Name = "boxFnameUpdate";
            this.boxFnameUpdate.Size = new System.Drawing.Size(206, 32);
            this.boxFnameUpdate.TabIndex = 26;
            // 
            // lblPhoneUpdate
            // 
            this.lblPhoneUpdate.AutoSize = true;
            this.lblPhoneUpdate.Location = new System.Drawing.Point(259, 93);
            this.lblPhoneUpdate.Name = "lblPhoneUpdate";
            this.lblPhoneUpdate.Size = new System.Drawing.Size(85, 25);
            this.lblPhoneUpdate.TabIndex = 27;
            this.lblPhoneUpdate.Text = "تلفن همراه";
            // 
            // boxAddressUpdate
            // 
            this.boxAddressUpdate.Location = new System.Drawing.Point(412, 185);
            this.boxAddressUpdate.Name = "boxAddressUpdate";
            this.boxAddressUpdate.Size = new System.Drawing.Size(196, 32);
            this.boxAddressUpdate.TabIndex = 28;
            // 
            // boxPhoneUpdate
            // 
            this.boxPhoneUpdate.Location = new System.Drawing.Point(21, 90);
            this.boxPhoneUpdate.Name = "boxPhoneUpdate";
            this.boxPhoneUpdate.Size = new System.Drawing.Size(206, 32);
            this.boxPhoneUpdate.TabIndex = 29;
            // 
            // lblAddressUpdate
            // 
            this.lblAddressUpdate.AutoSize = true;
            this.lblAddressUpdate.Location = new System.Drawing.Point(622, 188);
            this.lblAddressUpdate.Name = "lblAddressUpdate";
            this.lblAddressUpdate.Size = new System.Drawing.Size(50, 25);
            this.lblAddressUpdate.TabIndex = 30;
            this.lblAddressUpdate.Text = "آدرس";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 32);
            this.textBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "مدرک تحصیلی";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(126, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 32);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCallInfo
            // 
            this.btnCallInfo.Location = new System.Drawing.Point(238, 200);
            this.btnCallInfo.Name = "btnCallInfo";
            this.btnCallInfo.Size = new System.Drawing.Size(101, 32);
            this.btnCallInfo.TabIndex = 33;
            this.btnCallInfo.Text = "فراخوانی";
            this.btnCallInfo.UseVisualStyleBackColor = true;
            // 
            // teachersManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1204, 740);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExcelOutput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TeachersdataGridView);
            this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "teachersManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت اساتید";
            ((System.ComponentModel.ISupportInitialize)(this.TeachersdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TeachersdataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTeachLname;
        private System.Windows.Forms.TextBox boxTeachLname;
        private System.Windows.Forms.TextBox boxTeachName;
        private System.Windows.Forms.Label lblTeachName;
        private System.Windows.Forms.TextBox boxTeachFathName;
        private System.Windows.Forms.Label lblTeachFatherName;
        private System.Windows.Forms.Label lblTeachDocumnet;
        private System.Windows.Forms.TextBox boxTeachDocument;
        private System.Windows.Forms.Label lblTeachPhone;
        private System.Windows.Forms.TextBox boxTeachPhone;
        private System.Windows.Forms.TextBox boxTeachID;
        private System.Windows.Forms.Label lblTeachID;
        private System.Windows.Forms.Label lblTeachAddress;
        private System.Windows.Forms.TextBox boxTeachAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTeachIDdel;
        private System.Windows.Forms.TextBox BoxTeachIDdel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTeachDel;
        private System.Windows.Forms.Button btnExcelOutput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTeachIdUpdate;
        private System.Windows.Forms.TextBox boxTeachIDUpdate;
        private System.Windows.Forms.Label lblTeachFathNameUpdate;
        private System.Windows.Forms.TextBox boxFathUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox boxNameUpdate;
        private System.Windows.Forms.Label lblFnameUpdate;
        private System.Windows.Forms.TextBox boxFnameUpdate;
        private System.Windows.Forms.Label lblPhoneUpdate;
        private System.Windows.Forms.TextBox boxAddressUpdate;
        private System.Windows.Forms.Label lblAddressUpdate;
        private System.Windows.Forms.TextBox boxPhoneUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCallInfo;
        private System.Windows.Forms.SaveFileDialog ExcelSaveDialog2;
    }
}