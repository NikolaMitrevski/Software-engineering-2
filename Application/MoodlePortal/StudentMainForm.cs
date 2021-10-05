﻿using System;
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
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
            customizeDesign();


        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            label_username.Text = Data.username;
            label_type.Text = Data.type;
            Data.panel = panel_main;
        }

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

        private void button_profile_Click(object sender, EventArgs e)
        {
            Data.color_button = 2;
            change_color_button();
            openChildForm(new StudentProfileForm());
        }


        private void change_color_button()
        {
            if (Data.color_button == 1)
            {
                // boja pozadine tastera
                button_course.BackColor = Color.White;
                button_profile.BackColor = SystemColors.HotTrack;
                button2.BackColor = SystemColors.HotTrack;
                button1.BackColor = SystemColors.HotTrack;
                button_list_of_course.BackColor = SystemColors.HotTrack;
                button_new_course.BackColor = SystemColors.HotTrack;
                // boja slova tastera
                button_course.ForeColor = SystemColors.HotTrack;
                button_profile.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button1.ForeColor = Color.White;
                button_list_of_course.ForeColor = Color.White;
                button_new_course.ForeColor = Color.White;
            }
            if (Data.color_button == 2)
            {
                hideSubmenu();
                //
                button_course.BackColor = SystemColors.HotTrack;
                button_profile.BackColor = Color.White;
                button2.BackColor = SystemColors.HotTrack;
                button1.BackColor = SystemColors.HotTrack;
                // boja slova tastera
                button_course.ForeColor = Color.White;
                button_profile.ForeColor = SystemColors.HotTrack;
                button2.ForeColor = Color.White;
                button1.ForeColor = Color.White;
            }
            if (Data.color_button == 3)
            {
                hideSubmenu();
                //
                button_course.BackColor = SystemColors.HotTrack;
                button_profile.BackColor = SystemColors.HotTrack;
                button2.BackColor = Color.White;
                button1.BackColor = SystemColors.HotTrack;
                // boja slova tastera
                button_course.ForeColor = Color.White;
                button_profile.ForeColor = Color.White;
                button2.ForeColor = SystemColors.HotTrack;
                button1.ForeColor = Color.White;
            }
            if (Data.color_button == 4)
            {
                hideSubmenu();
                //
                button_course.BackColor = SystemColors.HotTrack;
                button_profile.BackColor = SystemColors.HotTrack;
                button2.BackColor = SystemColors.HotTrack;
                button1.BackColor = Color.White;
                // boja slova tastera
                button_course.ForeColor = Color.White;
                button_profile.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button1.ForeColor = SystemColors.HotTrack;
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
                //
                button2.BackColor = SystemColors.HotTrack;
                button2.ForeColor = Color.White;
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
                //
                button2.BackColor = SystemColors.HotTrack;
                button2.ForeColor = Color.White;
            }
            if (Data.color_button == 7)
            {
                button_course.BackColor = SystemColors.HotTrack;
                button_course.ForeColor = Color.White;
                //
                button_list_of_course.BackColor = SystemColors.HotTrack;
                button_list_of_course.ForeColor = Color.White;
                //
                button_new_course.BackColor = SystemColors.HotTrack;
                button_new_course.ForeColor = Color.White;
                //
                button2.BackColor = Color.White;
                button2.ForeColor = SystemColors.HotTrack;
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

        /*private void button_sign_out_Click(object sender, EventArgs e)
        {
            Data.color_button = 4;
            change_color_button();
            hideSubmenu();
            this.Close();
            Application.Restart();
        }*/

        

        private void button1_Click(object sender, EventArgs e)
        {
            //OVO JE SIGN OUT BUTTON
            
            Data.color_button = 4;
            change_color_button();
            hideSubmenu();
            this.Close();
            Application.Restart();
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

        private void button_new_course_Click(object sender, EventArgs e)
        {
            Data.color_button = 5;
            openChildForm(new NewCourse());
            //hideSubmenu();
            change_color_button();
        }

        /*private void button_list_of_course_Click(object sender, EventArgs e)
        {
            Data.color_button = 6;
            openChildForm(new StudentCourseForm());
            //hideSubmenu();
            change_color_button();
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            //OVO JE SCORE BUTTON
            //OTVARANJE LISTE KURSEVA
            Data.color_button = 7;
            openChildForm(new StudentScore());
            //hideSubmenu();
            change_color_button();
        }

        private void button_list_of_course_Click_1(object sender, EventArgs e)
        {
            //OTVARANJE LISTE KURSEVA
            Data.color_button = 6;
            openChildForm(new StudentListOfCourseForm());
            //hideSubmenu();
            change_color_button();
        }

        private void button_new_course_Click_1(object sender, EventArgs e)
        {
            //UPISIVANJE NOVOG KURSA
            Data.color_button = 5;
            openChildForm(new StudentNewCourseForm());
            //hideSubmenu();
            change_color_button();
        }
    }
}
