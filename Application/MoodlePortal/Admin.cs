using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodlePortal
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button_student_Click(object sender, EventArgs e)
        {
            Data.color_button = 1;
            change_color_button();
            openChildForm(new StudentCRUD());
        }

        private void button_proffesor_Click(object sender, EventArgs e)
        {
            Data.color_button = 2;
            change_color_button();
            openChildForm(new ProfessorCRUD());
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            Data.color_button = 3;
            change_color_button();
            openChildForm(new CourseCRUD());
        }

        private void button_sign_out_Click(object sender, EventArgs e)
        {
            //hideSubmenu();
            //this.Close();
            Data.color_button = 4;
            change_color_button();
            Application.Restart();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            label_username.Text = Data.username;    // PROVERITI OVO, DA LI RADI ONO STO TREBA
            label_type.Text = "Admin";
        }

        // DISABLE BUTTON X
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        // za prikazivanje druge forme unutar Form1
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void change_color_button()
        {
            if (Data.color_button == 1)
            {
                // boja pozadine tastera
                button_student.BackColor = Color.White;
                button_proffesor.BackColor = SystemColors.HotTrack;
                button_course.BackColor = SystemColors.HotTrack;
                button_sign_out.BackColor = SystemColors.HotTrack;
                // boja slova tastera
                button_student.ForeColor = SystemColors.HotTrack;
                button_proffesor.ForeColor = Color.White;
                button_course.ForeColor = Color.White;
                button_sign_out.ForeColor = Color.White;
            }
            if (Data.color_button == 2)
            {
                // boja pozadine tastera
                button_student.BackColor = SystemColors.HotTrack;
                button_proffesor.BackColor = Color.White;
                button_course.BackColor = SystemColors.HotTrack;
                button_sign_out.BackColor = SystemColors.HotTrack;
                // boja slova tastera
                button_student.ForeColor = Color.White;
                button_proffesor.ForeColor = SystemColors.HotTrack;
                button_course.ForeColor = Color.White;
                button_sign_out.ForeColor = Color.White;
            }
            if (Data.color_button == 3)
            {
                // boja pozadine tastera
                button_student.BackColor = SystemColors.HotTrack;
                button_proffesor.BackColor = SystemColors.HotTrack;
                button_course.BackColor = Color.White;
                button_sign_out.BackColor = SystemColors.HotTrack;
                // boja slova tastera
                button_student.ForeColor = Color.White;
                button_proffesor.ForeColor = Color.White;
                button_course.ForeColor = SystemColors.HotTrack;
                button_sign_out.ForeColor = Color.White;
            }
            if (Data.color_button == 4)
            {
                // boja pozadine tastera
                button_student.BackColor = SystemColors.HotTrack;
                button_proffesor.BackColor = SystemColors.HotTrack;
                button_course.BackColor = SystemColors.HotTrack;
                button_sign_out.BackColor = Color.White;
                // boja slova tastera
                button_student.ForeColor = Color.White;
                button_proffesor.ForeColor = Color.White;
                button_course.ForeColor = Color.White;
                button_sign_out.ForeColor = SystemColors.HotTrack;
            }
        }
    }
}
