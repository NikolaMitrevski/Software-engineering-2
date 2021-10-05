namespace MoodlePortal
{
    partial class ProfessorCRUD
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
            this.panel_select_gender_search_student = new System.Windows.Forms.Panel();
            this.label_gender = new System.Windows.Forms.Label();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.panel_search_student = new System.Windows.Forms.Panel();
            this.label_search_department = new System.Windows.Forms.Label();
            this.label_search_ln = new System.Windows.Forms.Label();
            this.label_search_fn = new System.Windows.Forms.Label();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox_search_professor_fn = new System.Windows.Forms.TextBox();
            this.textBox_search_professor_department = new System.Windows.Forms.TextBox();
            this.textBox_search_professor_ln = new System.Windows.Forms.TextBox();
            this.dataGridViewProfessor = new System.Windows.Forms.DataGridView();
            this.panel_data = new System.Windows.Forms.Panel();
            this.button_update_picture = new System.Windows.Forms.Button();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_department = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_answer1 = new System.Windows.Forms.Label();
            this.textBox_userID = new System.Windows.Forms.TextBox();
            this.panel_main.SuspendLayout();
            this.panel_control.SuspendLayout();
            this.panel_select_gender_search_student.SuspendLayout();
            this.panel_search_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessor)).BeginInit();
            this.panel_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_main.Controls.Add(this.panel_control);
            this.panel_main.Controls.Add(this.panel_select_gender_search_student);
            this.panel_main.Controls.Add(this.panel_search_student);
            this.panel_main.Controls.Add(this.dataGridViewProfessor);
            this.panel_main.Controls.Add(this.panel_data);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(938, 492);
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
            this.panel_control.Location = new System.Drawing.Point(594, 328);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(344, 164);
            this.panel_control.TabIndex = 8;
            // 
            // button_clear_clear
            // 
            this.button_clear_clear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_clear_clear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clear_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear_clear.Location = new System.Drawing.Point(199, 91);
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
            this.button_delete.Location = new System.Drawing.Point(199, 41);
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
            this.button_update.Location = new System.Drawing.Point(78, 91);
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
            this.button_add.Location = new System.Drawing.Point(78, 41);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(91, 31);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel_select_gender_search_student
            // 
            this.panel_select_gender_search_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_select_gender_search_student.Controls.Add(this.label_gender);
            this.panel_select_gender_search_student.Controls.Add(this.radioButton_all);
            this.panel_select_gender_search_student.Controls.Add(this.radioButton_female);
            this.panel_select_gender_search_student.Controls.Add(this.radioButton_male);
            this.panel_select_gender_search_student.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_select_gender_search_student.ForeColor = System.Drawing.Color.Black;
            this.panel_select_gender_search_student.Location = new System.Drawing.Point(484, 328);
            this.panel_select_gender_search_student.Name = "panel_select_gender_search_student";
            this.panel_select_gender_search_student.Size = new System.Drawing.Size(110, 164);
            this.panel_select_gender_search_student.TabIndex = 7;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_gender.ForeColor = System.Drawing.Color.White;
            this.label_gender.Location = new System.Drawing.Point(14, 29);
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
            this.radioButton_all.Location = new System.Drawing.Point(39, 110);
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
            this.radioButton_female.Location = new System.Drawing.Point(39, 84);
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
            this.radioButton_male.Location = new System.Drawing.Point(39, 60);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(47, 17);
            this.radioButton_male.TabIndex = 0;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            this.radioButton_male.CheckedChanged += new System.EventHandler(this.radioButton_male_CheckedChanged);
            // 
            // panel_search_student
            // 
            this.panel_search_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_search_student.Controls.Add(this.label_search_department);
            this.panel_search_student.Controls.Add(this.label_search_ln);
            this.panel_search_student.Controls.Add(this.label_search_fn);
            this.panel_search_student.Controls.Add(this.label_search);
            this.panel_search_student.Controls.Add(this.textBox_search_professor_fn);
            this.panel_search_student.Controls.Add(this.textBox_search_professor_department);
            this.panel_search_student.Controls.Add(this.textBox_search_professor_ln);
            this.panel_search_student.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_search_student.Location = new System.Drawing.Point(180, 328);
            this.panel_search_student.Name = "panel_search_student";
            this.panel_search_student.Size = new System.Drawing.Size(304, 164);
            this.panel_search_student.TabIndex = 6;
            // 
            // label_search_department
            // 
            this.label_search_department.AutoSize = true;
            this.label_search_department.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search_department.ForeColor = System.Drawing.Color.White;
            this.label_search_department.Location = new System.Drawing.Point(25, 108);
            this.label_search_department.Name = "label_search_department";
            this.label_search_department.Size = new System.Drawing.Size(91, 17);
            this.label_search_department.TabIndex = 7;
            this.label_search_department.Text = "Department:";
            // 
            // label_search_ln
            // 
            this.label_search_ln.AutoSize = true;
            this.label_search_ln.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search_ln.ForeColor = System.Drawing.Color.White;
            this.label_search_ln.Location = new System.Drawing.Point(25, 82);
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
            this.label_search_fn.Location = new System.Drawing.Point(25, 56);
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
            this.label_search.Location = new System.Drawing.Point(12, 27);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(144, 16);
            this.label_search.TabIndex = 4;
            this.label_search.Text = "Search the professor:";
            // 
            // textBox_search_professor_fn
            // 
            this.textBox_search_professor_fn.Location = new System.Drawing.Point(131, 55);
            this.textBox_search_professor_fn.Name = "textBox_search_professor_fn";
            this.textBox_search_professor_fn.Size = new System.Drawing.Size(150, 20);
            this.textBox_search_professor_fn.TabIndex = 3;
            this.textBox_search_professor_fn.TextChanged += new System.EventHandler(this.textBox_search_professor_fn_TextChanged);
            // 
            // textBox_search_professor_department
            // 
            this.textBox_search_professor_department.Location = new System.Drawing.Point(131, 107);
            this.textBox_search_professor_department.Name = "textBox_search_professor_department";
            this.textBox_search_professor_department.Size = new System.Drawing.Size(150, 20);
            this.textBox_search_professor_department.TabIndex = 2;
            this.textBox_search_professor_department.TextChanged += new System.EventHandler(this.textBox_search_professor_department_TextChanged);
            // 
            // textBox_search_professor_ln
            // 
            this.textBox_search_professor_ln.Location = new System.Drawing.Point(131, 81);
            this.textBox_search_professor_ln.Name = "textBox_search_professor_ln";
            this.textBox_search_professor_ln.Size = new System.Drawing.Size(150, 20);
            this.textBox_search_professor_ln.TabIndex = 1;
            this.textBox_search_professor_ln.TextChanged += new System.EventHandler(this.textBox_search_professor_ln_TextChanged);
            // 
            // dataGridViewProfessor
            // 
            this.dataGridViewProfessor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProfessor.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewProfessor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfessor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProfessor.EnableHeadersVisualStyles = false;
            this.dataGridViewProfessor.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewProfessor.Location = new System.Drawing.Point(180, 0);
            this.dataGridViewProfessor.Name = "dataGridViewProfessor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfessor.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProfessor.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewProfessor.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProfessor.Size = new System.Drawing.Size(758, 328);
            this.dataGridViewProfessor.TabIndex = 2;
            this.dataGridViewProfessor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProfessor_RowHeaderMouseClick);
            // 
            // panel_data
            // 
            this.panel_data.AutoScroll = true;
            this.panel_data.Controls.Add(this.button_update_picture);
            this.panel_data.Controls.Add(this.comboBox_gender);
            this.panel_data.Controls.Add(this.Gender);
            this.panel_data.Controls.Add(this.label11);
            this.panel_data.Controls.Add(this.label12);
            this.panel_data.Controls.Add(this.textBox_email);
            this.panel_data.Controls.Add(this.label8);
            this.panel_data.Controls.Add(this.textBox_department);
            this.panel_data.Controls.Add(this.label9);
            this.panel_data.Controls.Add(this.textBox_lastName);
            this.panel_data.Controls.Add(this.label4);
            this.panel_data.Controls.Add(this.textBox_firstName);
            this.panel_data.Controls.Add(this.label2);
            this.panel_data.Controls.Add(this.textBox_password);
            this.panel_data.Controls.Add(this.label1);
            this.panel_data.Controls.Add(this.textBox_username);
            this.panel_data.Controls.Add(this.label_answer1);
            this.panel_data.Controls.Add(this.textBox_userID);
            this.panel_data.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_data.Location = new System.Drawing.Point(0, 0);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(180, 492);
            this.panel_data.TabIndex = 1;
            // 
            // button_update_picture
            // 
            this.button_update_picture.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_update_picture.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_update_picture.ForeColor = System.Drawing.Color.White;
            this.button_update_picture.Location = new System.Drawing.Point(19, 326);
            this.button_update_picture.Name = "button_update_picture";
            this.button_update_picture.Size = new System.Drawing.Size(107, 23);
            this.button_update_picture.TabIndex = 87;
            this.button_update_picture.Text = "UPDATE";
            this.button_update_picture.UseVisualStyleBackColor = false;
            this.button_update_picture.Click += new System.EventHandler(this.button_update_picture_Click);
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(19, 369);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(107, 21);
            this.comboBox_gender.TabIndex = 86;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gender.ForeColor = System.Drawing.Color.White;
            this.Gender.Location = new System.Drawing.Point(16, 350);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(61, 16);
            this.Gender.TabIndex = 85;
            this.Gender.Text = "Gender:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 84;
            this.label11.Text = "Picture:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 83;
            this.label12.Text = "Email:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(19, 282);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(107, 20);
            this.textBox_email.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 75;
            this.label8.Text = "Department:";
            // 
            // textBox_department
            // 
            this.textBox_department.Location = new System.Drawing.Point(19, 240);
            this.textBox_department.Name = "textBox_department";
            this.textBox_department.Size = new System.Drawing.Size(107, 20);
            this.textBox_department.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 73;
            this.label9.Text = "Last name:";
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(19, 198);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(107, 20);
            this.textBox_lastName.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "First name:";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(19, 155);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(107, 20);
            this.textBox_firstName.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Password:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(19, 112);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(107, 20);
            this.textBox_password.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Username:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(19, 70);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(107, 20);
            this.textBox_username.TabIndex = 66;
            // 
            // label_answer1
            // 
            this.label_answer1.AutoSize = true;
            this.label_answer1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_answer1.ForeColor = System.Drawing.Color.White;
            this.label_answer1.Location = new System.Drawing.Point(16, 9);
            this.label_answer1.Name = "label_answer1";
            this.label_answer1.Size = new System.Drawing.Size(56, 16);
            this.label_answer1.TabIndex = 65;
            this.label_answer1.Text = "User ID:";
            // 
            // textBox_userID
            // 
            this.textBox_userID.Location = new System.Drawing.Point(19, 28);
            this.textBox_userID.Name = "textBox_userID";
            this.textBox_userID.ReadOnly = true;
            this.textBox_userID.Size = new System.Drawing.Size(107, 20);
            this.textBox_userID.TabIndex = 64;
            // 
            // ProfessorCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 492);
            this.Controls.Add(this.panel_main);
            this.Name = "ProfessorCRUD";
            this.Text = "ProfessorCRUD";
            this.Load += new System.EventHandler(this.ProfessorCRUD_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_control.ResumeLayout(false);
            this.panel_select_gender_search_student.ResumeLayout(false);
            this.panel_select_gender_search_student.PerformLayout();
            this.panel_search_student.ResumeLayout(false);
            this.panel_search_student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessor)).EndInit();
            this.panel_data.ResumeLayout(false);
            this.panel_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_data;
        private System.Windows.Forms.DataGridView dataGridViewProfessor;
        private System.Windows.Forms.Panel panel_search_student;
        private System.Windows.Forms.Label label_search_department;
        private System.Windows.Forms.Label label_search_ln;
        private System.Windows.Forms.Label label_search_fn;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox_search_professor_fn;
        private System.Windows.Forms.TextBox textBox_search_professor_department;
        private System.Windows.Forms.TextBox textBox_search_professor_ln;
        private System.Windows.Forms.Panel panel_select_gender_search_student;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button button_clear_clear;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update_picture;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_department;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_answer1;
        private System.Windows.Forms.TextBox textBox_userID;
    }
}