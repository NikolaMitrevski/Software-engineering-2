using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodlePortal
{
    public partial class CourseCRUD : Form
    {
        public String name = "";
        public String year = "";
        public String nameExtention = "";
        public String yearExtention = "";
        public String query = "SELECT idKursa AS 'ID kursa', idKorisnika AS 'ID nastavnika', naziv AS 'Naziv kursa', godina AS Godina FROM kurs WHERE 1=1";

        private OpenFileDialog fd = new OpenFileDialog();
        private FileStream fs;
        byte[] buffer = null;

        public CourseCRUD()
        {
            InitializeComponent();
            fd.InitialDirectory = "c://";
            fd.FileOk += fd_FileOK;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //int korisnikID = 0;
            //String kursIme = "";
            //int kursGodina = 0;

            Random generator = new Random();
            int kursID = 0;

            try
            {
                kursID = generator.Next(10000, 100000);
                //kursID = int.Parse(textBox_courseID.Text);
                //korisnikID = int.Parse(textBox_userID.Text);
                //kursIme = textBox_name.Text;
                //kursGodina = int.Parse(textBox_year.Text);

                //MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                //String query1 = "INSERT INTO kurs (idKursa, idKorisnika, naziv, godina) VALUES (" + kursID + "," + korisnikID + ",'" + kursIme + "'," + kursGodina + ")";
                //MySqlCommand cmd1 = new MySqlCommand();

                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                String query1 = "INSERT INTO kurs (idKursa) VALUES (" + kursID + ")";
                MySqlCommand cmd1 = new MySqlCommand();

                try
                {
                    con.Open();
                    MySqlTransaction transaction = con.BeginTransaction();
                    cmd1.Transaction = transaction;
                    cmd1.Connection = con;
                    cmd1.CommandText = query1;
                    cmd1.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    con.Close();
                }
                MessageBox.Show("Kurs je uspesno dodat.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            DataTable dt = SelectCourse();
            dataGridViewCourse.DataSource = dt;
            buffer = null;
        }

        private void CourseCRUD_Load(object sender, EventArgs e)
        {
            DataTable dt = SelectCourse();
            dataGridViewCourse.DataSource = dt;
        }

        public DataTable SelectCourse()
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; database = moodle; username = root; password = ;");
            DataTable data = new DataTable();

            try
            {
                String fullQuery = query + nameExtention + yearExtention;
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

        private void textBox_search_course_name_TextChanged(object sender, EventArgs e)
        {
            name = textBox_search_course_name.Text;
            if (!name.Equals(""))
            {
                nameExtention = " AND naziv LIKE '" + name + "%'";
            }
            else
            {
                nameExtention = "";
            }

            DataTable dt = SelectCourse();
            dataGridViewCourse.DataSource = dt;
        }

        private void textBox_search_course_year_TextChanged(object sender, EventArgs e)
        {
            year = textBox_search_course_year.Text;
            if (!year.Equals(""))
            {
                yearExtention = " AND godina LIKE '" + year + "%'";
            }
            else
            {
                yearExtention = "";
            }

            DataTable dt = SelectCourse();
            dataGridViewCourse.DataSource = dt;
        }

        private void button_clear_clear_Click(object sender, EventArgs e)
        {
            textBox_courseID.Text = "";
            textBox_userID.Text = "";
            textBox_name.Text = "";
            textBox_year.Text = "";
            textBox_search_course_name.Text = "";
            textBox_search_course_year.Text = "";
        }

        private void dataGridViewCourse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            textBox_courseID.Text = dataGridViewCourse.Rows[rowIndex].Cells[0].Value.ToString();
            textBox_userID.Text = dataGridViewCourse.Rows[rowIndex].Cells[1].Value.ToString();
            textBox_name.Text = dataGridViewCourse.Rows[rowIndex].Cells[2].Value.ToString();
            textBox_year.Text = dataGridViewCourse.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            String kursID = "";
            String korisnikID = "";
            String kursIme = "";
            String kursGodina = "";

            try { 
                kursID = textBox_courseID.Text;
                korisnikID = textBox_userID.Text;
                kursIme = textBox_name.Text;
                kursGodina = textBox_year.Text;

                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                String query1 = "UPDATE kurs SET idKursa='" + kursID + "',idKorisnika='" + korisnikID + "',naziv='" + kursIme + "',godina='" + kursGodina + "'WHERE idKursa='" + kursID + "'";

                MySqlCommand cmd1 = new MySqlCommand();

                try
                {
                    con.Open();
                    MySqlTransaction transaction = con.BeginTransaction();
                    cmd1.Transaction = transaction;
                    cmd1.Connection = con;
                    cmd1.CommandText = query1;
                    cmd1.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    con.Close();
                }
                MessageBox.Show("Podaci o kursu su uspesno azurirani.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            DataTable dt = SelectCourse();
            dataGridViewCourse.DataSource = dt;
            buffer = null;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int idKursa = 0;

            try
            {
                idKursa = int.Parse(textBox_courseID.Text);

                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                String query1 = "DELETE FROM kurs WHERE idKursa=" + idKursa + ";";
                MySqlCommand cmd1 = new MySqlCommand();

                try
                {
                    con.Open();
                    MySqlTransaction transaction = con.BeginTransaction();
                    cmd1.Transaction = transaction;
                    cmd1.Connection = con;
                    cmd1.CommandText = query1;
                    cmd1.ExecuteNonQuery();
                    transaction.Commit();

                    Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            DataTable dt = SelectCourse();
            dataGridViewCourse.DataSource = dt;
        }

        public void Clear()
        {
            textBox_courseID.Text = "";
            textBox_userID.Text = "";
            textBox_name.Text = "";
            textBox_year.Text = "";
        }

        private void fd_FileOK(Object sender, EventArgs e) //prepisana iz CourseHomepage.cs
        {
            if ((fs = (FileStream)fd.OpenFile()) != null)
            {
                buffer = new byte[fs.Length];

                fs.ReadAsync(buffer, 0, (int)fs.Length);
                String name = fs.Name;

                String[] n = name.Split('\\');
                String fileName = n[n.Length - 1];
                String[] ext = fileName.Split('.');
                String fileExtention = ext[ext.Length - 1];
                String fileSavename = ext[0];
            }
            else MessageBox.Show("No file chosen");
        }

    }
}
