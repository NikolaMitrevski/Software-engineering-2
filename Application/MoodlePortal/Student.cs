using MySql.Data.MySqlClient;
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
    public partial class Student : Form
    {
        public String gender = "all";
        public String name = "";
        public String surname = "";
        public int index;
        public String query = "SELECT brojIndeksa AS 'Broj indeksa', ime AS Ime, prezime AS Prezime, smer AS Smer, godinaUpisa AS 'Godina upisa', " +
                              "godinaStudija AS 'Godina studija', email AS Email, pol AS Pol FROM student WHERE 1=1";
        public String nameExtention = "";
        public String surnameExtention = "";
        public String indexExtention = "";
        public String genderExtention = "";
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            DataTable dt = SelectStudent();
            dataGridViewStudent.DataSource = dt;

        }
        public DataTable SelectStudent()
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; database = Moodle; username = root; password = ;");
            DataTable data = new DataTable();

            try
            {
                if (gender.Equals("male"))
                {
                    genderExtention = " AND pol = 'M' OR pol = 'Male'";
                }
                else if (gender.Equals("female"))
                {
                    genderExtention = " AND pol = 'F' OR pol = 'Female'";
                }
                else genderExtention = "";
                String fullQuery = query + nameExtention + surnameExtention + indexExtention + genderExtention;
                MySqlCommand cmd = new MySqlCommand(fullQuery, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(data);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                conn.Close();
            }

            return data;
        }
        private void textBox_search_student_fn_TextChanged(object sender, EventArgs e)
        {


            name = textBox_search_student_fn.Text;
            if (!name.Equals(""))
            {
                nameExtention = " AND ime LIKE '" + name + "%'";
            }
            else nameExtention = "";
            DataTable dt = SelectStudent();
            dataGridViewStudent.DataSource = dt;


        }

        private void textBox_search_student_ln_TextChanged(object sender, EventArgs e)
        {

            surname = textBox_search_student_ln.Text;
            if (!surname.Equals(""))
            {
                surnameExtention = " AND prezime LIKE '" + surname + "%'";
            }
            else surnameExtention = "";
            DataTable dt = SelectStudent();
            dataGridViewStudent.DataSource = dt;
        }

        private void textBox_search_student_In_TextChanged(object sender, EventArgs e) //pretraga po indeksu
        {

            String ind = textBox_search_student_In.Text;
            if (!ind.Equals(""))
            {
                try
                {
                    index = Convert.ToInt32(ind);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else index = -1;
            if (index > 0)
            {
                indexExtention = " AND brojIndeksa =" + index;
            }
            else indexExtention = "";
            DataTable dt = SelectStudent();
            dataGridViewStudent.DataSource = dt;


        }

        private void button_clear_search_Click(object sender, EventArgs e)
        {
            textBox_search_student_fn.Text = "";
            textBox_search_student_ln.Text = "";
            textBox_search_student_In.Text = "";
        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
            DataTable dt = SelectStudent();
            dataGridViewStudent.DataSource = dt;
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
            DataTable dt = SelectStudent();
            dataGridViewStudent.DataSource = dt;
        }

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {
            gender = "all";
            DataTable dt = SelectStudent();
            dataGridViewStudent.DataSource = dt;
        }
    }
}
