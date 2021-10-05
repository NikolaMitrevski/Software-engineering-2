namespace MoodlePortal
{
    partial class Student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.textBox_search_student_ln = new System.Windows.Forms.TextBox();
            this.textBox_search_student_In = new System.Windows.Forms.TextBox();
            this.textBox_search_student_fn = new System.Windows.Forms.TextBox();
            this.panel_search_student = new System.Windows.Forms.Panel();
            this.button_clear_search = new System.Windows.Forms.Button();
            this.label_search_ni = new System.Windows.Forms.Label();
            this.label_search_ln = new System.Windows.Forms.Label();
            this.label_search_fn = new System.Windows.Forms.Label();
            this.label_search = new System.Windows.Forms.Label();
            this.panel_select_course_search_student = new System.Windows.Forms.Panel();
            this.label_gender = new System.Windows.Forms.Label();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.panel_search_student.SuspendLayout();
            this.panel_select_course_search_student.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStudent.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewStudent.EnableHeadersVisualStyles = false;
            this.dataGridViewStudent.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewStudent.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewStudent.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudent.Size = new System.Drawing.Size(938, 328);
            this.dataGridViewStudent.TabIndex = 0;
            // 
            // textBox_search_student_ln
            // 
            this.textBox_search_student_ln.Location = new System.Drawing.Point(131, 66);
            this.textBox_search_student_ln.Name = "textBox_search_student_ln";
            this.textBox_search_student_ln.Size = new System.Drawing.Size(150, 20);
            this.textBox_search_student_ln.TabIndex = 1;
            this.textBox_search_student_ln.TextChanged += new System.EventHandler(this.textBox_search_student_ln_TextChanged);
            // 
            // textBox_search_student_In
            // 
            this.textBox_search_student_In.Location = new System.Drawing.Point(131, 92);
            this.textBox_search_student_In.Name = "textBox_search_student_In";
            this.textBox_search_student_In.Size = new System.Drawing.Size(150, 20);
            this.textBox_search_student_In.TabIndex = 2;
            this.textBox_search_student_In.TextChanged += new System.EventHandler(this.textBox_search_student_In_TextChanged);
            // 
            // textBox_search_student_fn
            // 
            this.textBox_search_student_fn.Location = new System.Drawing.Point(131, 40);
            this.textBox_search_student_fn.Name = "textBox_search_student_fn";
            this.textBox_search_student_fn.Size = new System.Drawing.Size(150, 20);
            this.textBox_search_student_fn.TabIndex = 3;
            this.textBox_search_student_fn.TextChanged += new System.EventHandler(this.textBox_search_student_fn_TextChanged);
            // 
            // panel_search_student
            // 
            this.panel_search_student.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_search_student.Controls.Add(this.button_clear_search);
            this.panel_search_student.Controls.Add(this.label_search_ni);
            this.panel_search_student.Controls.Add(this.label_search_ln);
            this.panel_search_student.Controls.Add(this.label_search_fn);
            this.panel_search_student.Controls.Add(this.label_search);
            this.panel_search_student.Controls.Add(this.textBox_search_student_fn);
            this.panel_search_student.Controls.Add(this.textBox_search_student_In);
            this.panel_search_student.Controls.Add(this.textBox_search_student_ln);
            this.panel_search_student.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_search_student.Location = new System.Drawing.Point(0, 328);
            this.panel_search_student.Name = "panel_search_student";
            this.panel_search_student.Size = new System.Drawing.Size(304, 171);
            this.panel_search_student.TabIndex = 4;
            // 
            // button_clear_search
            // 
            this.button_clear_search.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_clear_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clear_search.ForeColor = System.Drawing.Color.White;
            this.button_clear_search.Location = new System.Drawing.Point(103, 126);
            this.button_clear_search.Name = "button_clear_search";
            this.button_clear_search.Size = new System.Drawing.Size(91, 31);
            this.button_clear_search.TabIndex = 8;
            this.button_clear_search.Text = "CLEAR";
            this.button_clear_search.UseVisualStyleBackColor = false;
            this.button_clear_search.Click += new System.EventHandler(this.button_clear_search_Click);
            // 
            // label_search_ni
            // 
            this.label_search_ni.AutoSize = true;
            this.label_search_ni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search_ni.ForeColor = System.Drawing.Color.White;
            this.label_search_ni.Location = new System.Drawing.Point(25, 93);
            this.label_search_ni.Name = "label_search_ni";
            this.label_search_ni.Size = new System.Drawing.Size(100, 17);
            this.label_search_ni.TabIndex = 7;
            this.label_search_ni.Text = "Index number:";
            // 
            // label_search_ln
            // 
            this.label_search_ln.AutoSize = true;
            this.label_search_ln.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search_ln.ForeColor = System.Drawing.Color.White;
            this.label_search_ln.Location = new System.Drawing.Point(25, 67);
            this.label_search_ln.Name = "label_search_ln";
            this.label_search_ln.Size = new System.Drawing.Size(79, 17);
            this.label_search_ln.TabIndex = 6;
            this.label_search_ln.Text = "Last name:";
            // 
            // label_search_fn
            // 
            this.label_search_fn.AutoSize = true;
            this.label_search_fn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search_fn.ForeColor = System.Drawing.Color.White;
            this.label_search_fn.Location = new System.Drawing.Point(25, 41);
            this.label_search_fn.Name = "label_search_fn";
            this.label_search_fn.Size = new System.Drawing.Size(77, 17);
            this.label_search_fn.TabIndex = 5;
            this.label_search_fn.Text = "First name:";
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search.ForeColor = System.Drawing.Color.White;
            this.label_search.Location = new System.Drawing.Point(12, 12);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(132, 16);
            this.label_search.TabIndex = 4;
            this.label_search.Text = "Search the student:";
            // 
            // panel_select_course_search_student
            // 
            this.panel_select_course_search_student.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_select_course_search_student.Controls.Add(this.label_gender);
            this.panel_select_course_search_student.Controls.Add(this.radioButton_all);
            this.panel_select_course_search_student.Controls.Add(this.radioButton_female);
            this.panel_select_course_search_student.Controls.Add(this.radioButton_male);
            this.panel_select_course_search_student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_select_course_search_student.ForeColor = System.Drawing.Color.Black;
            this.panel_select_course_search_student.Location = new System.Drawing.Point(304, 328);
            this.panel_select_course_search_student.Name = "panel_select_course_search_student";
            this.panel_select_course_search_student.Size = new System.Drawing.Size(634, 171);
            this.panel_select_course_search_student.TabIndex = 5;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_gender.ForeColor = System.Drawing.Color.White;
            this.label_gender.Location = new System.Drawing.Point(6, 12);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(61, 16);
            this.label_gender.TabIndex = 9;
            this.label_gender.Text = "Gender:";
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Checked = true;
            this.radioButton_all.ForeColor = System.Drawing.Color.White;
            this.radioButton_all.Location = new System.Drawing.Point(31, 93);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(35, 17);
            this.radioButton_all.TabIndex = 2;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "all";
            this.radioButton_all.UseVisualStyleBackColor = true;
            this.radioButton_all.CheckedChanged += new System.EventHandler(this.radioButton_all_CheckedChanged);
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.ForeColor = System.Drawing.Color.White;
            this.radioButton_female.Location = new System.Drawing.Point(31, 67);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(56, 17);
            this.radioButton_female.TabIndex = 1;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            this.radioButton_female.CheckedChanged += new System.EventHandler(this.radioButton_female_CheckedChanged);
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.ForeColor = System.Drawing.Color.White;
            this.radioButton_male.Location = new System.Drawing.Point(31, 43);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(47, 17);
            this.radioButton_male.TabIndex = 0;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            this.radioButton_male.CheckedChanged += new System.EventHandler(this.radioButton_male_CheckedChanged);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 499);
            this.Controls.Add(this.panel_select_course_search_student);
            this.Controls.Add(this.panel_search_student);
            this.Controls.Add(this.dataGridViewStudent);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.panel_search_student.ResumeLayout(false);
            this.panel_search_student.PerformLayout();
            this.panel_select_course_search_student.ResumeLayout(false);
            this.panel_select_course_search_student.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.TextBox textBox_search_student_ln;
        private System.Windows.Forms.TextBox textBox_search_student_In;
        private System.Windows.Forms.TextBox textBox_search_student_fn;
        private System.Windows.Forms.Panel panel_search_student;
        private System.Windows.Forms.Label label_search_ni;
        private System.Windows.Forms.Label label_search_ln;
        private System.Windows.Forms.Label label_search_fn;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button button_clear_search;
        private System.Windows.Forms.Panel panel_select_course_search_student;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label label_gender;
    }
}