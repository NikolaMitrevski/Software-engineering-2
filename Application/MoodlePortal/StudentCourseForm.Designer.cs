namespace MoodlePortal
{
    partial class StudentCourseForm
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
            this.panel_material = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_control = new System.Windows.Forms.Panel();
            this.button_take_test = new System.Windows.Forms.Button();
            this.label_select_test = new System.Windows.Forms.Label();
            this.comboBox_select_test = new System.Windows.Forms.ComboBox();
            this.button_see_material = new System.Windows.Forms.Button();
            this.label_week = new System.Windows.Forms.Label();
            this.comboBox_select_week = new System.Windows.Forms.ComboBox();
            this.panel_material.SuspendLayout();
            this.panel_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_material
            // 
            this.panel_material.AutoScroll = true;
            this.panel_material.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel_material.Controls.Add(this.flowLayoutPanel1);
            this.panel_material.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_material.Location = new System.Drawing.Point(256, 0);
            this.panel_material.Margin = new System.Windows.Forms.Padding(4);
            this.panel_material.Name = "panel_material";
            this.panel_material.Size = new System.Drawing.Size(995, 556);
            this.panel_material.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(991, 538);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel_control
            // 
            this.panel_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_control.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_control.Controls.Add(this.button_take_test);
            this.panel_control.Controls.Add(this.label_select_test);
            this.panel_control.Controls.Add(this.comboBox_select_test);
            this.panel_control.Controls.Add(this.button_see_material);
            this.panel_control.Controls.Add(this.label_week);
            this.panel_control.Controls.Add(this.comboBox_select_week);
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Margin = new System.Windows.Forms.Padding(4);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(256, 556);
            this.panel_control.TabIndex = 3;
            // 
            // button_take_test
            // 
            this.button_take_test.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_take_test.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_take_test.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_take_test.ForeColor = System.Drawing.Color.White;
            this.button_take_test.Location = new System.Drawing.Point(21, 246);
            this.button_take_test.Margin = new System.Windows.Forms.Padding(4);
            this.button_take_test.Name = "button_take_test";
            this.button_take_test.Size = new System.Drawing.Size(227, 31);
            this.button_take_test.TabIndex = 16;
            this.button_take_test.Text = "TAKE THE TEST";
            this.button_take_test.UseVisualStyleBackColor = false;
            this.button_take_test.Click += new System.EventHandler(this.button_take_test_Click);
            // 
            // label_select_test
            // 
            this.label_select_test.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_select_test.AutoSize = true;
            this.label_select_test.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_select_test.ForeColor = System.Drawing.Color.White;
            this.label_select_test.Location = new System.Drawing.Point(16, 180);
            this.label_select_test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_select_test.Name = "label_select_test";
            this.label_select_test.Size = new System.Drawing.Size(108, 22);
            this.label_select_test.TabIndex = 15;
            this.label_select_test.Text = "Select test:";
            // 
            // comboBox_select_test
            // 
            this.comboBox_select_test.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_select_test.FormattingEnabled = true;
            this.comboBox_select_test.Location = new System.Drawing.Point(21, 213);
            this.comboBox_select_test.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_select_test.Name = "comboBox_select_test";
            this.comboBox_select_test.Size = new System.Drawing.Size(225, 24);
            this.comboBox_select_test.TabIndex = 14;
            // 
            // button_see_material
            // 
            this.button_see_material.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_see_material.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_see_material.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_see_material.ForeColor = System.Drawing.Color.White;
            this.button_see_material.Location = new System.Drawing.Point(21, 121);
            this.button_see_material.Margin = new System.Windows.Forms.Padding(4);
            this.button_see_material.Name = "button_see_material";
            this.button_see_material.Size = new System.Drawing.Size(227, 31);
            this.button_see_material.TabIndex = 2;
            this.button_see_material.Text = "SEE MATERIAL";
            this.button_see_material.UseVisualStyleBackColor = false;
            this.button_see_material.Click += new System.EventHandler(this.button_see_material_Click);
            // 
            // label_week
            // 
            this.label_week.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_week.AutoSize = true;
            this.label_week.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_week.ForeColor = System.Drawing.Color.White;
            this.label_week.Location = new System.Drawing.Point(16, 54);
            this.label_week.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_week.Name = "label_week";
            this.label_week.Size = new System.Drawing.Size(125, 22);
            this.label_week.TabIndex = 1;
            this.label_week.Text = "Select week:";
            // 
            // comboBox_select_week
            // 
            this.comboBox_select_week.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_select_week.FormattingEnabled = true;
            this.comboBox_select_week.Items.AddRange(new object[] {
            "Week 1",
            "Week 2",
            "Week 3",
            "Week 4",
            "Week 5",
            "Week 6",
            "Week 7",
            "Week 8",
            "Week 9",
            "Week 10",
            "Week 11",
            "Week 12",
            "Week 13",
            "Week 14",
            "Week 15"});
            this.comboBox_select_week.Location = new System.Drawing.Point(21, 87);
            this.comboBox_select_week.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_select_week.Name = "comboBox_select_week";
            this.comboBox_select_week.Size = new System.Drawing.Size(225, 24);
            this.comboBox_select_week.TabIndex = 0;
            this.comboBox_select_week.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_week_SelectedIndexChanged_1);
            // 
            // StudentCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 556);
            this.Controls.Add(this.panel_material);
            this.Controls.Add(this.panel_control);
            this.Name = "StudentCourseForm";
            this.Text = "StudentCourseForm";
            this.Load += new System.EventHandler(this.StudentCourseForm_Load);
            this.panel_material.ResumeLayout(false);
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_material;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button button_take_test;
        private System.Windows.Forms.Label label_select_test;
        private System.Windows.Forms.ComboBox comboBox_select_test;
        private System.Windows.Forms.Button button_see_material;
        private System.Windows.Forms.Label label_week;
        private System.Windows.Forms.ComboBox comboBox_select_week;
    }
}