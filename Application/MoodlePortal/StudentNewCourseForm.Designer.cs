namespace MoodlePortal
{
    partial class StudentNewCourseForm
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
            this.button_enroll = new System.Windows.Forms.Button();
            this.label_1 = new System.Windows.Forms.Label();
            this.textBox_course_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_enroll
            // 
            this.button_enroll.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_enroll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_enroll.ForeColor = System.Drawing.Color.White;
            this.button_enroll.Location = new System.Drawing.Point(492, 235);
            this.button_enroll.Margin = new System.Windows.Forms.Padding(4);
            this.button_enroll.Name = "button_enroll";
            this.button_enroll.Size = new System.Drawing.Size(225, 33);
            this.button_enroll.TabIndex = 18;
            this.button_enroll.Text = "ENROLL";
            this.button_enroll.UseVisualStyleBackColor = false;
            this.button_enroll.Click += new System.EventHandler(this.button_enroll_Click);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_1.ForeColor = System.Drawing.Color.White;
            this.label_1.Location = new System.Drawing.Point(536, 115);
            this.label_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(136, 19);
            this.label_1.TabIndex = 13;
            this.label_1.Text = "Enter course ID:";
            // 
            // textBox_course_id
            // 
            this.textBox_course_id.Location = new System.Drawing.Point(492, 159);
            this.textBox_course_id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_course_id.Name = "textBox_course_id";
            this.textBox_course_id.Size = new System.Drawing.Size(224, 22);
            this.textBox_course_id.TabIndex = 19;
            // 
            // StudentNewCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1251, 556);
            this.Controls.Add(this.textBox_course_id);
            this.Controls.Add(this.button_enroll);
            this.Controls.Add(this.label_1);
            this.Name = "StudentNewCourseForm";
            this.Text = "StudentNewCourseForm";
            this.Load += new System.EventHandler(this.StudentNewCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_enroll;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.TextBox textBox_course_id;
    }
}