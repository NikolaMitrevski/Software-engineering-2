namespace MoodlePortal
{
    partial class CourseHomepageStudent
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
            this.panel_control = new System.Windows.Forms.Panel();
            this.label_week = new System.Windows.Forms.Label();
            this.comboBox_select_week = new System.Windows.Forms.ComboBox();
            this.panel_material = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNameOfCourse = new System.Windows.Forms.Label();
            this.panel_control.SuspendLayout();
            this.panel_material.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_control.Controls.Add(this.labelNameOfCourse);
            this.panel_control.Controls.Add(this.label_week);
            this.panel_control.Controls.Add(this.comboBox_select_week);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(192, 452);
            this.panel_control.TabIndex = 2;
            // 
            // label_week
            // 
            this.label_week.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_week.AutoSize = true;
            this.label_week.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_week.ForeColor = System.Drawing.Color.White;
            this.label_week.Location = new System.Drawing.Point(5, 81);
            this.label_week.Name = "label_week";
            this.label_week.Size = new System.Drawing.Size(104, 20);
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
            this.comboBox_select_week.Location = new System.Drawing.Point(9, 124);
            this.comboBox_select_week.Name = "comboBox_select_week";
            this.comboBox_select_week.Size = new System.Drawing.Size(170, 21);
            this.comboBox_select_week.TabIndex = 0;
            this.comboBox_select_week.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_week_SelectedIndexChanged);
            // 
            // panel_material
            // 
            this.panel_material.AutoScroll = true;
            this.panel_material.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel_material.Controls.Add(this.flowLayoutPanel1);
            this.panel_material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_material.Location = new System.Drawing.Point(192, 0);
            this.panel_material.Name = "panel_material";
            this.panel_material.Size = new System.Drawing.Size(746, 452);
            this.panel_material.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(743, 437);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelNameOfCourse
            // 
            this.labelNameOfCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameOfCourse.AutoSize = true;
            this.labelNameOfCourse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameOfCourse.ForeColor = System.Drawing.Color.White;
            this.labelNameOfCourse.Location = new System.Drawing.Point(5, 43);
            this.labelNameOfCourse.Name = "labelNameOfCourse";
            this.labelNameOfCourse.Size = new System.Drawing.Size(104, 20);
            this.labelNameOfCourse.TabIndex = 2;
            this.labelNameOfCourse.Text = "Select week:";
            // 
            // CourseHomepageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 452);
            this.Controls.Add(this.panel_material);
            this.Controls.Add(this.panel_control);
            this.Name = "CourseHomepageStudent";
            this.Text = "CourseHomepageStudent";
            this.Load += new System.EventHandler(this.CourseHomepageStudent_Load);
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            this.panel_material.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Label label_week;
        private System.Windows.Forms.ComboBox comboBox_select_week;
        private System.Windows.Forms.Panel panel_material;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelNameOfCourse;
    }
}