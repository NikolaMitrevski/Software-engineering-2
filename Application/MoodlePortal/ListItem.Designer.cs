namespace MoodlePortal
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_material_name = new System.Windows.Forms.Label();
            this.button_delete_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_material_name
            // 
            this.label_material_name.AutoSize = true;
            this.label_material_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_material_name.ForeColor = System.Drawing.Color.White;
            this.label_material_name.Location = new System.Drawing.Point(42, 56);
            this.label_material_name.Name = "label_material_name";
            this.label_material_name.Size = new System.Drawing.Size(162, 20);
            this.label_material_name.TabIndex = 0;
            this.label_material_name.Text = "label_material_name";
            // 
            // button_delete_file
            // 
            this.button_delete_file.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_delete_file.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete_file.ForeColor = System.Drawing.Color.White;
            this.button_delete_file.Location = new System.Drawing.Point(577, 55);
            this.button_delete_file.Name = "button_delete_file";
            this.button_delete_file.Size = new System.Drawing.Size(91, 25);
            this.button_delete_file.TabIndex = 1;
            this.button_delete_file.Text = "DELETE";
            this.button_delete_file.UseVisualStyleBackColor = false;
            
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.button_delete_file);
            this.Controls.Add(this.label_material_name);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(712, 133);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_material_name;
        private System.Windows.Forms.Button button_delete_file;
    }
}
