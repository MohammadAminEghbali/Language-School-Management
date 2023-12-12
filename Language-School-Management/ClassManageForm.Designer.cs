namespace Language_School_Management
{
    partial class ClassManageForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classesDataGridView = new System.Windows.Forms.DataGridView();
            this.lblClassName = new System.Windows.Forms.Label();
            this.boxClassName = new System.Windows.Forms.TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.boxStartTime = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.boxEndTime = new System.Windows.Forms.TextBox();
            this.lblSessionCount = new System.Windows.Forms.Label();
            this.boxSessionCount = new System.Windows.Forms.TextBox();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.boxTeacherID = new System.Windows.Forms.TextBox();
            this.lblClassCode = new System.Windows.Forms.Label();
            this.boxClassCode = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxClassDelete = new System.Windows.Forms.TextBox();
            this.lblClassCodeDelete = new System.Windows.Forms.Label();
            this.btnClassDelete = new System.Windows.Forms.Button();
            this.delInfo2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblClassCodeUpdate = new System.Windows.Forms.Label();
            this.boxClassCodeUpdate = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInfoCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblClassNameUpdate = new System.Windows.Forms.Label();
            this.boxClassNameUpdate = new System.Windows.Forms.TextBox();
            this.lblEndTimeUpdate = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSessionCountUpdate = new System.Windows.Forms.Label();
            this.boxSessionCountUpdate = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.excelOutput = new System.Windows.Forms.Button();
            this.ExcelSaveDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.boxClassCode);
            this.groupBox1.Controls.Add(this.lblClassCode);
            this.groupBox1.Controls.Add(this.boxTeacherID);
            this.groupBox1.Controls.Add(this.lblTeacherID);
            this.groupBox1.Controls.Add(this.boxSessionCount);
            this.groupBox1.Controls.Add(this.lblSessionCount);
            this.groupBox1.Controls.Add(this.boxEndTime);
            this.groupBox1.Controls.Add(this.lblEndTime);
            this.groupBox1.Controls.Add(this.boxStartTime);
            this.groupBox1.Controls.Add(this.lblStartTime);
            this.groupBox1.Controls.Add(this.boxClassName);
            this.groupBox1.Controls.Add(this.lblClassName);
            this.groupBox1.Location = new System.Drawing.Point(754, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(440, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت کلاس";
            // 
            // classesDataGridView
            // 
            this.classesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.classesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classesDataGridView.Location = new System.Drawing.Point(13, 13);
            this.classesDataGridView.Name = "classesDataGridView";
            this.classesDataGridView.Size = new System.Drawing.Size(725, 393);
            this.classesDataGridView.TabIndex = 1;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(362, 42);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(72, 25);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "نام کلاس";
            // 
            // boxClassName
            // 
            this.boxClassName.Location = new System.Drawing.Point(20, 39);
            this.boxClassName.Name = "boxClassName";
            this.boxClassName.Size = new System.Drawing.Size(291, 32);
            this.boxClassName.TabIndex = 1;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(342, 96);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(92, 25);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "ساعت شروع";
            // 
            // boxStartTime
            // 
            this.boxStartTime.Location = new System.Drawing.Point(20, 93);
            this.boxStartTime.Name = "boxStartTime";
            this.boxStartTime.Size = new System.Drawing.Size(291, 32);
            this.boxStartTime.TabIndex = 3;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(349, 152);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(85, 25);
            this.lblEndTime.TabIndex = 4;
            this.lblEndTime.Text = "ساعت پایان";
            // 
            // boxEndTime
            // 
            this.boxEndTime.Location = new System.Drawing.Point(20, 149);
            this.boxEndTime.Name = "boxEndTime";
            this.boxEndTime.Size = new System.Drawing.Size(291, 32);
            this.boxEndTime.TabIndex = 5;
            // 
            // lblSessionCount
            // 
            this.lblSessionCount.AutoSize = true;
            this.lblSessionCount.Location = new System.Drawing.Point(335, 205);
            this.lblSessionCount.Name = "lblSessionCount";
            this.lblSessionCount.Size = new System.Drawing.Size(99, 25);
            this.lblSessionCount.TabIndex = 6;
            this.lblSessionCount.Text = "تعداد جلسات";
            // 
            // boxSessionCount
            // 
            this.boxSessionCount.Location = new System.Drawing.Point(20, 202);
            this.boxSessionCount.Name = "boxSessionCount";
            this.boxSessionCount.Size = new System.Drawing.Size(291, 32);
            this.boxSessionCount.TabIndex = 7;
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Location = new System.Drawing.Point(338, 260);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(96, 25);
            this.lblTeacherID.TabIndex = 8;
            this.lblTeacherID.Text = "کد ملی استاد";
            // 
            // boxTeacherID
            // 
            this.boxTeacherID.Location = new System.Drawing.Point(20, 257);
            this.boxTeacherID.Name = "boxTeacherID";
            this.boxTeacherID.Size = new System.Drawing.Size(291, 32);
            this.boxTeacherID.TabIndex = 9;
            // 
            // lblClassCode
            // 
            this.lblClassCode.AutoSize = true;
            this.lblClassCode.Location = new System.Drawing.Point(365, 315);
            this.lblClassCode.Name = "lblClassCode";
            this.lblClassCode.Size = new System.Drawing.Size(69, 25);
            this.lblClassCode.TabIndex = 10;
            this.lblClassCode.Text = "کد کلاس";
            // 
            // boxClassCode
            // 
            this.boxClassCode.Location = new System.Drawing.Point(20, 312);
            this.boxClassCode.Name = "boxClassCode";
            this.boxClassCode.Size = new System.Drawing.Size(291, 32);
            this.boxClassCode.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(20, 378);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 36);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(215, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 36);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "پاکسازی";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.delInfo2);
            this.groupBox2.Controls.Add(this.btnClassDelete);
            this.groupBox2.Controls.Add(this.lblClassCodeDelete);
            this.groupBox2.Controls.Add(this.boxClassDelete);
            this.groupBox2.Location = new System.Drawing.Point(754, 468);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(440, 227);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حذف کلاس";
            // 
            // boxClassDelete
            // 
            this.boxClassDelete.Location = new System.Drawing.Point(126, 51);
            this.boxClassDelete.Name = "boxClassDelete";
            this.boxClassDelete.Size = new System.Drawing.Size(230, 32);
            this.boxClassDelete.TabIndex = 14;
            // 
            // lblClassCodeDelete
            // 
            this.lblClassCodeDelete.AutoSize = true;
            this.lblClassCodeDelete.Location = new System.Drawing.Point(362, 54);
            this.lblClassCodeDelete.Name = "lblClassCodeDelete";
            this.lblClassCodeDelete.Size = new System.Drawing.Size(69, 25);
            this.lblClassCodeDelete.TabIndex = 14;
            this.lblClassCodeDelete.Text = "کد کلاس";
            // 
            // btnClassDelete
            // 
            this.btnClassDelete.Location = new System.Drawing.Point(20, 51);
            this.btnClassDelete.Name = "btnClassDelete";
            this.btnClassDelete.Size = new System.Drawing.Size(96, 32);
            this.btnClassDelete.TabIndex = 14;
            this.btnClassDelete.Text = "حذف";
            this.btnClassDelete.UseVisualStyleBackColor = true;
            // 
            // delInfo2
            // 
            this.delInfo2.AutoSize = true;
            this.delInfo2.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.delInfo2.Location = new System.Drawing.Point(100, 107);
            this.delInfo2.Name = "delInfo2";
            this.delInfo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delInfo2.Size = new System.Drawing.Size(326, 25);
            this.delInfo2.TabIndex = 4;
            this.delInfo2.Text = "راهنما : کد کلاس را وارد کرده و دکمه حذف را بزنید";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(175, 142);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "نکته : این عملیات قابل بازگشت نیست";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(26, 180);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(400, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "منظور از کد کلاس همان کد یکتایی است که هنگام ثبت وارد کردید";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.boxSessionCountUpdate);
            this.groupBox3.Controls.Add(this.lblSessionCountUpdate);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.lblEndTimeUpdate);
            this.groupBox3.Controls.Add(this.boxClassNameUpdate);
            this.groupBox3.Controls.Add(this.lblClassNameUpdate);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnInfoCall);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.boxClassCodeUpdate);
            this.groupBox3.Controls.Add(this.lblClassCodeUpdate);
            this.groupBox3.Location = new System.Drawing.Point(13, 450);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(725, 245);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ویرایش کلاس";
            // 
            // lblClassCodeUpdate
            // 
            this.lblClassCodeUpdate.AutoSize = true;
            this.lblClassCodeUpdate.Location = new System.Drawing.Point(645, 44);
            this.lblClassCodeUpdate.Name = "lblClassCodeUpdate";
            this.lblClassCodeUpdate.Size = new System.Drawing.Size(69, 25);
            this.lblClassCodeUpdate.TabIndex = 14;
            this.lblClassCodeUpdate.Text = "کد کلاس";
            // 
            // boxClassCodeUpdate
            // 
            this.boxClassCodeUpdate.Location = new System.Drawing.Point(375, 41);
            this.boxClassCodeUpdate.Name = "boxClassCodeUpdate";
            this.boxClassCodeUpdate.Size = new System.Drawing.Size(227, 32);
            this.boxClassCodeUpdate.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(16, 191);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 36);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnInfoCall
            // 
            this.btnInfoCall.Location = new System.Drawing.Point(118, 191);
            this.btnInfoCall.Name = "btnInfoCall";
            this.btnInfoCall.Size = new System.Drawing.Size(96, 36);
            this.btnInfoCall.TabIndex = 15;
            this.btnInfoCall.Text = "فراخوانی";
            this.btnInfoCall.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "ساعت شروع";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 32);
            this.textBox1.TabIndex = 17;
            // 
            // lblClassNameUpdate
            // 
            this.lblClassNameUpdate.AutoSize = true;
            this.lblClassNameUpdate.Location = new System.Drawing.Point(645, 90);
            this.lblClassNameUpdate.Name = "lblClassNameUpdate";
            this.lblClassNameUpdate.Size = new System.Drawing.Size(72, 25);
            this.lblClassNameUpdate.TabIndex = 14;
            this.lblClassNameUpdate.Text = "نام کلاس";
            // 
            // boxClassNameUpdate
            // 
            this.boxClassNameUpdate.Location = new System.Drawing.Point(375, 87);
            this.boxClassNameUpdate.Name = "boxClassNameUpdate";
            this.boxClassNameUpdate.Size = new System.Drawing.Size(227, 32);
            this.boxClassNameUpdate.TabIndex = 18;
            // 
            // lblEndTimeUpdate
            // 
            this.lblEndTimeUpdate.AutoSize = true;
            this.lblEndTimeUpdate.Location = new System.Drawing.Point(270, 90);
            this.lblEndTimeUpdate.Name = "lblEndTimeUpdate";
            this.lblEndTimeUpdate.Size = new System.Drawing.Size(85, 25);
            this.lblEndTimeUpdate.TabIndex = 19;
            this.lblEndTimeUpdate.Text = "ساعت پایان";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 32);
            this.textBox2.TabIndex = 20;
            // 
            // lblSessionCountUpdate
            // 
            this.lblSessionCountUpdate.AutoSize = true;
            this.lblSessionCountUpdate.Location = new System.Drawing.Point(256, 136);
            this.lblSessionCountUpdate.Name = "lblSessionCountUpdate";
            this.lblSessionCountUpdate.Size = new System.Drawing.Size(99, 25);
            this.lblSessionCountUpdate.TabIndex = 21;
            this.lblSessionCountUpdate.Text = "تعداد جلسات";
            // 
            // boxSessionCountUpdate
            // 
            this.boxSessionCountUpdate.Location = new System.Drawing.Point(16, 133);
            this.boxSessionCountUpdate.Name = "boxSessionCountUpdate";
            this.boxSessionCountUpdate.Size = new System.Drawing.Size(227, 32);
            this.boxSessionCountUpdate.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(375, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 32);
            this.textBox4.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "کد ملی استاد";
            // 
            // excelOutput
            // 
            this.excelOutput.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelOutput.Location = new System.Drawing.Point(14, 411);
            this.excelOutput.Margin = new System.Windows.Forms.Padding(2);
            this.excelOutput.Name = "excelOutput";
            this.excelOutput.Size = new System.Drawing.Size(111, 37);
            this.excelOutput.TabIndex = 5;
            this.excelOutput.Text = "خروجی اکسل";
            this.excelOutput.UseVisualStyleBackColor = true;
            this.excelOutput.Click += new System.EventHandler(this.excelOutput_Click);
            // 
            // ClassManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1206, 707);
            this.Controls.Add(this.excelOutput);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.classesDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ClassManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کلاس ها";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView classesDataGridView;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox boxClassName;
        private System.Windows.Forms.TextBox boxStartTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox boxClassCode;
        private System.Windows.Forms.Label lblClassCode;
        private System.Windows.Forms.TextBox boxTeacherID;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.TextBox boxSessionCount;
        private System.Windows.Forms.Label lblSessionCount;
        private System.Windows.Forms.TextBox boxEndTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClassDelete;
        private System.Windows.Forms.Label lblClassCodeDelete;
        private System.Windows.Forms.TextBox boxClassDelete;
        private System.Windows.Forms.Label delInfo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInfoCall;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox boxClassCodeUpdate;
        private System.Windows.Forms.Label lblClassCodeUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxClassNameUpdate;
        private System.Windows.Forms.Label lblClassNameUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox boxSessionCountUpdate;
        private System.Windows.Forms.Label lblSessionCountUpdate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblEndTimeUpdate;
        private System.Windows.Forms.Button excelOutput;
        private System.Windows.Forms.SaveFileDialog ExcelSaveDialog3;
    }
}