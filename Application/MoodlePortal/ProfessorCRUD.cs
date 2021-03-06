using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodlePortal
{
    public partial class ProfessorCRUD : Form
    {

        public String gender = "all";
        public String name = "";
        public String surname = "";
        public String department = "";
        public String query = "SELECT profesor.idKorisnika AS 'ID profesora', ime AS Ime, prezime AS Prezime, katedra AS Katedra, pol AS Pol, email AS Email, " +
                              "username AS Username, password AS Password FROM profesor INNER JOIN korisnik ON profesor.idKorisnika = korisnik.idKorisnika WHERE 1=1";
        public String nameExtention = "";
        public String surnameExtention = "";
        public String departmentExtention = "";
        public String genderExtention = "";

        private OpenFileDialog fd = new OpenFileDialog();
        private FileStream fs;
        byte[] buffer = null;

        public ProfessorCRUD()
        {
            InitializeComponent();
            fd.InitialDirectory = "c://";
            fd.FileOk += fd_FileOK;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            String ime = "";
            String prezime = "";
            String katedra = "";
            String pol = "";
            String email = "";
            //fali slika
            String username = "";
            String password = "";


            try
            {

                ime = textBox_firstName.Text;
                prezime = textBox_lastName.Text;
                katedra = textBox_department.Text;
                email = textBox_email.Text;
                pol = comboBox_gender.Text;
                username = textBox_username.Text;
                password = textBox_password.Text;

                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                String query1 = "INSERT INTO korisnik (username, password, type) VALUES ('" + username + "','" + password + "','professor')";
                MySqlCommand cmd1 = new MySqlCommand();
                try
                {
                    //CheckValues(idKursa, nazivKursa, godina);
                    con.Open();
                    MySqlTransaction transaction = con.BeginTransaction();
                    cmd1.Transaction = transaction;
                    cmd1.Connection = con;
                    cmd1.CommandText = query1;
                    cmd1.ExecuteNonQuery();
                    transaction.Commit();

                    //this.Hide();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    con.Close();
                }
                String query = "INSERT INTO profesor (idKorisnika, ime, prezime, katedra, pol, email, slika) VALUES (" + "(SELECT idKorisnika FROM korisnik WHERE username = '" + username + "' AND password = '" + password + "'),'" + ime + "','" + prezime + "','" + katedra + "','" + pol + "','" + email + "',@slika);";

                MySqlCommand cmd = new MySqlCommand();
                MySqlParameter param = cmd.Parameters.Add("@slika", MySqlDbType.LongBlob);
                param.Value = buffer;
                try
                {
                    //CheckValues(idKursa, nazivKursa, godina);
                    con.Open();
                    MySqlTransaction transaction = con.BeginTransaction();
                    cmd.Transaction = transaction;
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();

                    //this.Hide();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    con.Close();
                }

                MessageBox.Show("Uspesno dodat profesor");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            DataTable dt = SelectProfessor();
            dataGridViewProfessor.DataSource = dt;
            buffer = null;

        }


        private void ProfessorCRUD_Load(object sender, EventArgs e)
        {
            DataTable dt = SelectProfessor();
            dataGridViewProfessor.DataSource = dt;

        }







        public DataTable SelectProfessor()
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
                String fullQuery = query + nameExtention + surnameExtention + departmentExtention + genderExtention;
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

        private void textBox_search_professor_fn_TextChanged(object sender, EventArgs e)
        {


            name = textBox_search_professor_fn.Text;
            if (!name.Equals(""))
            {
                nameExtention = " AND ime LIKE '" + name + "%'";
            }
            else nameExtention = "";
            DataTable dt = SelectProfessor();
            dataGridViewProfessor.DataSource = dt;


        }

        private void textBox_search_professor_ln_TextChanged(object sender, EventArgs e)
        {
            surname = textBox_search_professor_ln.Text;
            if (!surname.Equals(""))
            {
                surnameExtention = " AND prezime LIKE '" + surname + "%'";
            }
            else surnameExtention = "";
            DataTable dt = SelectProfessor();
            dataGridViewProfessor.DataSource = dt;
        }

        private void textBox_search_professor_department_TextChanged(object sender, EventArgs e)
        {
            department = textBox_search_professor_department.Text;
            if (!department.Equals(""))
            {
                departmentExtention = " AND katedra LIKE '" + department + "%'";
            }
            else departmentExtention = "";
            DataTable dt = SelectProfessor();
            dataGridViewProfessor.DataSource = dt;
        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
            DataTable dt = SelectProfessor();
            dataGridViewProfessor.DataSource = dt;
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
            DataTable dt = SelectProfessor();
            dataGridViewProfessor.DataSource = dt;
        }

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {
            gender = "all";
            DataTable dt = SelectProfessor();
            dataGridViewProfessor.DataSource = dt;
        }


        private void button_clear_clear_Click(object sender, EventArgs e)
        {
            textBox_search_professor_fn.Text = "";
            textBox_userID.Text = "";
            textBox_firstName.Text = "";
            textBox_lastName.Text = "";
            textBox_department.Text = "";
            comboBox_gender.Text = "";
            textBox_email.Text = "";
            textBox_username.Text = "";
            textBox_password.Text = "";
        }

        private void dataGridViewProfessor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            textBox_userID.Text = dataGridViewProfessor.Rows[rowIndex].Cells[0].Value.ToString();
            textBox_firstName.Text = dataGridViewProfessor.Rows[rowIndex].Cells[1].Value.ToString();
            textBox_lastName.Text = dataGridViewProfessor.Rows[rowIndex].Cells[2].Value.ToString();
            textBox_department.Text = dataGridViewProfessor.Rows[rowIndex].Cells[3].Value.ToString();
            comboBox_gender.Text = dataGridViewProfessor.Rows[rowIndex].Cells[4].Value.ToString();
            textBox_email.Text = dataGridViewProfessor.Rows[rowIndex].Cells[5].Value.ToString();
            textBox_username.Text = dataGridViewProfessor.Rows[rowIndex].Cells[6].Value.ToString();
            textBox_password.Text = dataGridViewProfessor.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int idKorisnika = 0;
            String ime = "";
            String prezime = "";
            String katedra = "";
            //fali slika
            String pol = "";
            String email = "";
            
            String username = "";
            String password = "";


            try
            {
                idKorisnika = int.Parse(textBox_userID.Text);
                ime = textBox_firstName.Text;
                prezime = textBox_lastName.Text;
                katedra = textBox_department.Text;
                email = textBox_email.Text;
                pol = comboBox_gender.Text;
                username = textBox_username.Text;
                password = textBox_password.Text;
               


                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                String query1 = "UPDATE korisnik SET username='" + username + "',password='" + password + "'WHERE idKorisnika='" + idKorisnika + "'";



                MySqlCommand cmd1 = new MySqlCommand();
                try
                {
                    //CheckValues(idKursa, nazivKursa, godina);
                    con.Open();
                    MySqlTransaction transaction = con.BeginTransaction();
                    cmd1.Transaction = transaction;
                    cmd1.Connection = con;
                    cmd1.CommandText = query1;
                    cmd1.ExecuteNonQuery();
                    transaction.Commit();

                    //this.Hide();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    con.Close();
                }


                String query = "UPDATE profesor SET ime='" + ime + "',prezime='" + prezime + "',katedra='" + katedra +   "',email='" + email + "',pol='" + pol + "'";

                MySqlCommand cmd = new MySqlCommand();
                if (buffer != null)
                {
                    query += ", slika = @slika";
                    MySqlParameter param = cmd.Parameters.Add("@slika", MySqlDbType.LongBlob);
                    param.Value = buffer;
                }
                query += " WHERE idKorisnika = '" + idKorisnika + "'";


                try
                {
                    //CheckValues(idKursa, nazivKursa, godina);
                    con.Open();
                    MySqlTransaction transaction = con.BeginTransaction();
                    cmd.Transaction = transaction;
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();


                    //this.Hide();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    con.Close();
                }

                MessageBox.Show("Podaci uspesno azurirani");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            DataTable dt = SelectProfessor();
            dataGridViewProfessor.DataSource = dt;
            buffer = null;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int idKorisnika = 0;
            try
            {
                idKorisnika = int.Parse(textBox_userID.Text);

                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                String query1 = "DELETE FROM korisnik WHERE idKorisnika=" + idKorisnika + ";";
                MySqlCommand cmd1 = new MySqlCommand();
                try
                {
                    //CheckValues(idKursa, nazivKursa, godina);
                    con.Open();
                    MySqlTransaction transaction = con.BeginTransaction();
                    cmd1.Transaction = transaction;
                    cmd1.Connection = con;
                    cmd1.CommandText = query1;
                    cmd1.ExecuteNonQuery();
                    transaction.Commit();

                    //this.Hide();
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

                /*
                String query = "DELETE FROM student WHERE idKorisnika='" + idKorisnika + "';";

                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    //CheckValues(idKursa, nazivKursa, godina);
                    con.Open();
                    MySqlTransaction transaction = con.BeginTransaction();
                    cmd.Transaction = transaction;
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();

                    //this.Hide();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    con.Close();
                }

                MessageBox.Show("Uspesno obrisan student");
                */
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            DataTable dt = SelectProfessor();
            dataGridViewProfessor.DataSource = dt;

        }

        public void Clear()
        {
            

            textBox_userID.Text = "";
            textBox_firstName.Text = "";
            textBox_lastName.Text = "";
            textBox_department.Text = "";
            textBox_email.Text = "";
            comboBox_gender.Text = "";
            textBox_username.Text = "";
            textBox_password.Text = "";


        }

        private void button_update_picture_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
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
