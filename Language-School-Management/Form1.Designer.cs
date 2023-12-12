namespace Language_School_Management
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DatenTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.students = new System.Windows.Forms.Button();
            this.teachers = new System.Windows.Forms.Button();
            this.classes = new System.Windows.Forms.Button();
            this.scores = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1058, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DatenTime
            // 
            this.DatenTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatenTime.Location = new System.Drawing.Point(13, 22);
            this.DatenTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatenTime.Name = "DatenTime";
            this.DatenTime.Size = new System.Drawing.Size(211, 45);
            this.DatenTime.TabIndex = 1;
            this.DatenTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // students
            // 
            this.students.Location = new System.Drawing.Point(947, 28);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(101, 39);
            this.students.TabIndex = 2;
            this.students.Text = "زبان آموزان";
            this.students.UseVisualStyleBackColor = true;
            this.students.Click += new System.EventHandler(this.students_Click);
            this.students.MouseEnter += new System.EventHandler(this.students_MouseEnter);
            this.students.MouseLeave += new System.EventHandler(this.students_MouseLeave);
            // 
            // teachers
            // 
            this.teachers.Location = new System.Drawing.Point(829, 28);
            this.teachers.Name = "teachers";
            this.teachers.Size = new System.Drawing.Size(101, 39);
            this.teachers.TabIndex = 3;
            this.teachers.Text = "اساتید";
            this.teachers.UseVisualStyleBackColor = true;
            this.teachers.Click += new System.EventHandler(this.teachers_Click);
            // 
            // classes
            // 
            this.classes.Location = new System.Drawing.Point(708, 28);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(101, 39);
            this.classes.TabIndex = 4;
            this.classes.Text = "کلاس ها";
            this.classes.UseVisualStyleBackColor = true;
            this.classes.Click += new System.EventHandler(this.classes_Click);
            // 
            // scores
            // 
            this.scores.Location = new System.Drawing.Point(580, 28);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(109, 39);
            this.scores.TabIndex = 5;
            this.scores.Text = "ثبت نمرات";
            this.scores.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Vazir", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(245, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(266, 30);
            this.Title.TabIndex = 6;
            this.Title.Text = "آموزشگاه زبان های خارجه سروش";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1060, 624);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.classes);
            this.Controls.Add(this.teachers);
            this.Controls.Add(this.students);
            this.Controls.Add(this.DatenTime);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خانه";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DatenTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button students;
        private System.Windows.Forms.Button teachers;
        private System.Windows.Forms.Button classes;
        private System.Windows.Forms.Button scores;
        private System.Windows.Forms.Label Title;
    }
}

