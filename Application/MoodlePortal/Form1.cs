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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_username.Text = Data.username;
            label_type.Text = Data.type;
            Data.panel = panel_main;
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

        private void customizeDesign()
        {
            panel_course.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_course.Visible == true)
                panel_course.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            Data.color_button = 1;
            change_color_button();
            showSubmenu(panel_course);
        }

        #region CourseSubmenu
        private void button_new_course_Click(object sender, EventArgs e)
        {
            Data.color_button = 5;
            openChildForm(new NewCourse());
            //hideSubmenu();
            change_color_button();
        }

        private void button_list_of_course_Click(object sender, EventArgs e)
        {
            Data.color_button = 6;
            openChildForm(new ListOfCourse());
            //hideSubmenu();
            change_color_button();
        }
        #endregion CourseSubmenu

        private void button_profile_Click(object sender, EventArgs e)
        {
            Data.color_button = 2;
            change_color_button();
            openChildForm(new Profile());
            //hideSubmenu();
        }

        private void button_student_Click(object sender, EventArgs e)
        {
            Data.color_button = 3;
            change_color_button();
            openChildForm(new Student());
            //hideSubmenu();
        }

        private void button_sign_out_Click(object sender, EventArgs e)
        {
            Data.color_button = 4;
            change_color_button();
            //hideSubmenu();
            //this.Close();
            Application.Restart();
        }

        private void change_color_button()
        {
            if (Data.color_button == 1)
            {
                // boja pozadine tastera
                button_course.BackColor = Color.White;
                button_profile.BackColor = SystemColors.HotTrack;
                button_student.BackColor = SystemColors.HotTrack;
                button_sign_out.BackColor = SystemColors.HotTrack;
                button_list_of_course.BackColor = SystemColors.HotTrack;
                button_new_course.BackColor = SystemColors.HotTrack;
                // boja slova tastera
                button_course.ForeColor = SystemColors.HotTrack;
                button_profile.ForeColor = Color.White;
                button_student.ForeColor = Color.White;
                button_sign_out.ForeColor = Color.White;
                button_list_of_course.ForeColor = Color.White;
                button_new_course.ForeColor = Color.White;
            }
            if (Data.color_button == 2)
            {
                hideSubmenu();
                //
                button_course.BackColor = SystemColors.HotTrack;
                button_profile.BackColor = Color.White;
                button_student.BackColor = SystemColors.HotTrack;
                button_sign_out.BackColor = SystemColors.HotTrack;
                // boja slova tastera
                button_course.ForeColor = Color.White;
                button_profile.ForeColor = SystemColors.HotTrack;
                button_student.ForeColor = Color.White;
                button_sign_out.ForeColor = Color.White;
            }
            if (Data.color_button == 3)
            {
                hideSubmenu();
                //
                button_course.BackColor = SystemColors.HotTrack;
                button_profile.BackColor = SystemColors.HotTrack;
                button_student.BackColor = Color.White;
                button_sign_out.BackColor = SystemColors.HotTrack;
                // boja slova tastera
                button_course.ForeColor = Color.White;
                button_profile.ForeColor = Color.White;
                button_student.ForeColor = SystemColors.HotTrack;
                button_sign_out.ForeColor = Color.White;
            }
            if (Data.color_button == 4)
            {
                hideSubmenu();
                //
                button_course.BackColor = SystemColors.HotTrack;
                button_profile.BackColor = SystemColors.HotTrack;
                button_student.BackColor = SystemColors.HotTrack;
                button_sign_out.BackColor = Color.White;
                // boja slova tastera
                button_course.ForeColor = Color.White;
                button_profile.ForeColor = Color.White;
                button_student.ForeColor = Color.White;
                button_sign_out.ForeColor = SystemColors.HotTrack;
            }
            if (Data.color_button == 5)
            {
                button_course.BackColor = SystemColors.HotTrack;
                button_course.ForeColor = Color.White;
                //
                button_new_course.BackColor = Color.White;
                button_new_course.ForeColor = SystemColors.HotTrack;
                //
                button_list_of_course.BackColor = SystemColors.HotTrack;
                button_list_of_course.ForeColor = Color.White;
            }
            if (Data.color_button == 6)
            {
                button_course.BackColor = SystemColors.HotTrack;
                button_course.ForeColor = Color.White;
                //
                button_list_of_course.BackColor = Color.White;
                button_list_of_course.ForeColor = SystemColors.HotTrack;
                //
                button_new_course.BackColor = SystemColors.HotTrack;
                button_new_course.ForeColor = Color.White;
            }
        }

        // za prikazivanje druge forme unutar Form1
        private static Form activeForm = null;
        public static void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Data.panel.Controls.Add(childForm);
            Data.panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}