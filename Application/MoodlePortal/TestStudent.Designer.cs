namespace MoodlePortal
{
    partial class TestStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_predajTest = new System.Windows.Forms.Button();
            this.panel_pitanja = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button_predajTest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 109);
            this.panel1.TabIndex = 1;
            // 
            // button_predajTest
            // 
            this.button_predajTest.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_predajTest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_predajTest.ForeColor = System.Drawing.Color.White;
            this.button_predajTest.Location = new System.Drawing.Point(329, 42);
            this.button_predajTest.Name = "button_predajTest";
            this.button_predajTest.Size = new System.Drawing.Size(153, 30);
            this.button_predajTest.TabIndex = 0;
            this.button_predajTest.Text = "PREDAJ TEST";
            this.button_predajTest.UseVisualStyleBackColor = false;
            this.button_predajTest.Click += new System.EventHandler(this.button_predajTest_Click);
            // 
            // panel_pitanja
            // 
            this.panel_pitanja.AutoScroll = true;
            this.panel_pitanja.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel_pitanja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pitanja.Location = new System.Drawing.Point(0, 0);
            this.panel_pitanja.Name = "panel_pitanja";
            this.panel_pitanja.Size = new System.Drawing.Size(800, 341);
            this.panel_pitanja.TabIndex = 2;
            // 
            // TestStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_pitanja);
            this.Controls.Add(this.panel1);
            this.Name = "TestStudent";
            this.Text = "TestStudent";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_predajTest;
        private System.Windows.Forms.FlowLayoutPanel panel_pitanja;
    }
}