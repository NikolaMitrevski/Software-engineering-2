namespace MoodlePortal
{
    partial class CourseCRUD
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_control = new System.Windows.Forms.Panel();
            this.button_clear_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel_search_professor = new System.Windows.Forms.Panel();
            this.label_search_y = new System.Windows.Forms.Label();
            this.label_search_n = new System.Windows.Forms.Label();
            this.label_search_course = new System.Windows.Forms.Label();
            this.textBox_search_course_name = new System.Windows.Forms.TextBox();
            this.textBox_search_course_year = new System.Windows.Forms.TextBox();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.panel_data = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_userID = new System.Windows.Forms.TextBox();
            this.label_answer1 = new System.Windows.Forms.Label();
            this.textBox_courseID = new System.Windows.Forms.TextBox();
            this.panel_main.SuspendLayout();
            this.panel_control.SuspendLayout();
            this.panel_search_professor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.panel_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_main.Controls.Add(this.panel_control);
            this.panel_main.Controls.Add(this.panel_search_professor);
            this.panel_main.Controls.Add(this.dataGridViewCourse);
            this.panel_main.Controls.Add(this.panel_data);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(938, 475);
            this.panel_main.TabIndex = 1;
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.Color.Black;
            this.panel_control.Controls.Add(this.button_clear_clear);
            this.panel_control.Controls.Add(this.button_delete);
            this.panel_control.Controls.Add(this.button_update);
            this.panel_control.Controls.Add(this.button_add);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_control.Location = new System.Drawing.Point(484, 328);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(454, 147);
            this.panel_control.TabIndex = 9;
            // 
            // button_clear_clear
            // 
            this.button_clear_clear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_clear_clear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clear_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear_clear.Location = new System.Drawing.Point(253, 91);
            this.button_clear_clear.Name = "button_clear_clear";
            this.button_clear_clear.Size = new System.Drawing.Size(91, 31);
            this.button_clear_clear.TabIndex = 8;
            this.button_clear_clear.Text = "CLEAR";
            this.button_clear_clear.UseVisualStyleBackColor = false;
            this.button_clear_clear.Click += new System.EventHandler(this.button_clear_clear_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(253, 41);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(91, 31);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(132, 91);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(91, 31);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(132, 41);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(91, 31);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel_search_professor
            // 
            this.panel_search_professor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_search_professor.Controls.Add(this.label_search_y);
            this.panel_search_professor.Controls.Add(this.label_search_n);
            this.panel_search_professor.Controls.Add(this.label_search_course);
            this.panel_search_professor.Controls.Add(this.textBox_search_course_name);
            this.panel_search_professor.Controls.Add(this.textBox_search_course_year);
            this.panel_search_professor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_search_professor.Location = new System.Drawing.Point(180, 328);
            this.panel_search_professor.Name = "panel_search_professor";
            this.panel_search_professor.Size = new System.Drawing.Size(304, 147);
            this.panel_search_professor.TabIndex = 7;
            // 
            // label_search_y
            // 
            this.label_search_y.AutoSize = true;
            this.label_search_y.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search_y.ForeColor = System.Drawing.Color.White;
            this.label_search_y.Location = new System.Drawing.Point(25, 92);
            this.label_search_y.Name = "label_search_y";
            this.label_search_y.Size = new System.Drawing.Size(40, 17);
            this.label_search_y.TabIndex = 6;
            this.label_search_y.Text = "Year:";
            // 
            // label_search_n
            // 
            this.label_search_n.AutoSize = true;
            this.label_search_n.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search_n.ForeColor = System.Drawing.Color.White;
            this.label_search_n.Location = new System.Drawing.Point(25, 66);
            this.label_search_n.Name = "label_search_n";
            this.label_search_n.Size = new System.Drawing.Size(52, 17);
            this.label_search_n.TabIndex = 5;
            this.label_search_n.Text = "Name:";
            // 
            // label_search_course
            // 
            this.label_search_course.AutoSize = true;
            this.label_search_course.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search_course.ForeColor = System.Drawing.Color.White;
            this.label_search_course.Location = new System.Drawing.Point(12, 37);
            this.label_search_course.Name = "label_search_course";
            this.label_search_course.Size = new System.Drawing.Size(128, 16);
            this.label_search_course.TabIndex = 4;
            this.label_search_course.Text = "Search the course:";
            // 
            // textBox_search_course_name
            // 
            this.textBox_search_course_name.Location = new System.Drawing.Point(131, 65);
            this.textBox_search_course_name.Name = "textBox_search_course_name";
            this.textBox_search_course_name.Size = new System.Drawing.Size(150, 20);
            this.textBox_search_course_name.TabIndex = 3;
            this.textBox_search_course_name.TextChanged += new System.EventHandler(this.textBox_search_course_name_TextChanged);
            // 
            // textBox_search_course_year
            // 
            this.textBox_search_course_year.Location = new System.Drawing.Point(131, 91);
            this.textBox_search_course_year.Name = "textBox_search_course_year";
            this.textBox_search_course_year.Size = new System.Drawing.Size(150, 20);
            this.textBox_search_course_year.TabIndex = 1;
            this.textBox_search_course_year.TextChanged += new System.EventHandler(this.textBox_search_course_year_TextChanged);
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCourse.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCourse.EnableHeadersVisualStyles = false;
            this.dataGridViewCourse.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewCourse.Location = new System.Drawing.Point(180, 0);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCourse.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCourse.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewCourse.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCourse.Size = new System.Drawing.Size(758, 328);
            this.dataGridViewCourse.TabIndex = 3;
            this.dataGridViewCourse.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCourse_RowHeaderMouseClick);
            // 
            // panel_data
            // 
            this.panel_data.AutoScroll = true;
            this.panel_data.Controls.Add(this.label4);
            this.panel_data.Controls.Add(this.textBox_year);
            this.panel_data.Controls.Add(this.label2);
            this.panel_data.Controls.Add(this.textBox_name);
            this.panel_data.Controls.Add(this.label1);
            this.panel_data.Controls.Add(this.textBox_userID);
            this.panel_data.Controls.Add(this.label_answer1);
            this.panel_data.Controls.Add(this.textBox_courseID);
            this.panel_data.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_data.Location = new System.Drawing.Point(0, 0);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(180, 475);
            this.panel_data.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Year:";
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(22, 155);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(107, 20);
            this.textBox_year.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(22, 112);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(107, 20);
            this.textBox_name.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "User ID:";
            // 
            // textBox_userID
            // 
            this.textBox_userID.Location = new System.Drawing.Point(22, 70);
            this.textBox_userID.Name = "textBox_userID";
            this.textBox_userID.Size = new System.Drawing.Size(107, 20);
            this.textBox_userID.TabIndex = 40;
            // 
            // label_answer1
            // 
            this.label_answer1.AutoSize = true;
            this.label_answer1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_answer1.ForeColor = System.Drawing.Color.White;
            this.label_answer1.Location = new System.Drawing.Point(19, 9);
            this.label_answer1.Name = "label_answer1";
            this.label_answer1.Size = new System.Drawing.Size(74, 16);
            this.label_answer1.TabIndex = 39;
            this.label_answer1.Text = "Course ID:";
            // 
            // textBox_courseID
            // 
            this.textBox_courseID.Location = new System.Drawing.Point(22, 28);
            this.textBox_courseID.Name = "textBox_courseID";
            this.textBox_courseID.Size = new System.Drawing.Size(107, 20);
            this.textBox_courseID.TabIndex = 38;
            // 
            // CourseCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 475);
            this.Controls.Add(this.panel_main);
            this.Name = "CourseCRUD";
            this.Text = "CourseCRUD";
            this.Load += new System.EventHandler(this.CourseCRUD_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_control.ResumeLayout(false);
            this.panel_search_professor.ResumeLayout(false);
            this.panel_search_professor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.panel_data.ResumeLayout(false);
            this.panel_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_userID;
        private System.Windows.Forms.Label label_answer1;
        private System.Windows.Forms.TextBox textBox_courseID;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.Panel panel_search_professor;
        private System.Windows.Forms.Label label_search_y;
        private System.Windows.Forms.Label label_search_n;
        private System.Windows.Forms.Label label_search_course;
        private System.Windows.Forms.TextBox textBox_search_course_name;
        private System.Windows.Forms.TextBox textBox_search_course_year;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button button_clear_clear;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
    }
}