namespace MoodlePortal
{
    partial class NewCourse
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
            this.cmbbox_idCourse = new System.Windows.Forms.ComboBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.textBox_name_course = new System.Windows.Forms.TextBox();
            this.textBox_year_course = new System.Windows.Forms.TextBox();
            this.button_create_course = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbbox_idCourse
            // 
            this.cmbbox_idCourse.FormattingEnabled = true;
            this.cmbbox_idCourse.Location = new System.Drawing.Point(57, 80);
            this.cmbbox_idCourse.Name = "cmbbox_idCourse";
            this.cmbbox_idCourse.Size = new System.Drawing.Size(169, 21);
            this.cmbbox_idCourse.TabIndex = 1;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_1.ForeColor = System.Drawing.Color.White;
            this.label_1.Location = new System.Drawing.Point(54, 49);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(72, 16);
            this.label_1.TabIndex = 6;
            this.label_1.Text = "ID course:";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_2.ForeColor = System.Drawing.Color.White;
            this.label_2.Location = new System.Drawing.Point(54, 117);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(98, 16);
            this.label_2.TabIndex = 7;
            this.label_2.Text = "Course name:";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_3.ForeColor = System.Drawing.Color.White;
            this.label_3.Location = new System.Drawing.Point(54, 189);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(105, 16);
            this.label_3.TabIndex = 8;
            this.label_3.Text = "Year of course:";
            // 
            // textBox_name_course
            // 
            this.textBox_name_course.Location = new System.Drawing.Point(57, 150);
            this.textBox_name_course.Name = "textBox_name_course";
            this.textBox_name_course.Size = new System.Drawing.Size(169, 20);
            this.textBox_name_course.TabIndex = 9;
            // 
            // textBox_year_course
            // 
            this.textBox_year_course.Location = new System.Drawing.Point(57, 222);
            this.textBox_year_course.Name = "textBox_year_course";
            this.textBox_year_course.Size = new System.Drawing.Size(169, 20);
            this.textBox_year_course.TabIndex = 10;
            // 
            // button_create_course
            // 
            this.button_create_course.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_create_course.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_create_course.ForeColor = System.Drawing.Color.White;
            this.button_create_course.Location = new System.Drawing.Point(57, 287);
            this.button_create_course.Name = "button_create_course";
            this.button_create_course.Size = new System.Drawing.Size(169, 27);
            this.button_create_course.TabIndex = 11;
            this.button_create_course.Text = "CREATE COURSE";
            this.button_create_course.UseVisualStyleBackColor = false;
            this.button_create_course.Click += new System.EventHandler(this.button_create_course_Click);
            // 
            // NewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(938, 452);
            this.Controls.Add(this.button_create_course);
            this.Controls.Add(this.textBox_year_course);
            this.Controls.Add(this.textBox_name_course);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.cmbbox_idCourse);
            this.Name = "NewCourse";
            this.Text = "NewCourse";
            this.Load += new System.EventHandler(this.NewCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbox_idCourse;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.TextBox textBox_name_course;
        private System.Windows.Forms.TextBox textBox_year_course;
        private System.Windows.Forms.Button button_create_course;
    }
}