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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username = textBox_username.Text;
            String password = textBox_password.Text;
            MySqlConnection con = new MySqlConnection("server = localhost; database = Moodle; username = root; password = ;");
            try
            {
                con.Open();
                String query = "SELECT idKorisnika, type FROM korisnik WHERE username = '" + username + "' AND password = '" + password + "'";
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    int id = Convert.ToInt32(dr[0].ToString());
                    String type = dr[1].ToString();
                    Data.username = username;
                    Data.id = id;
                    Data.type = type;
                    if (type.Equals("professor"))
                    {
                        Form1 f = new Form1();
                        f.Show();
                        this.Hide();
                        //MessageBox.Show("Uspesno ulogovan profesor"); 
                    }
                    else if (type.Equals("student"))
                    {
                        StudentMainForm student = new StudentMainForm();
                        student.Show();
                        this.Hide();
                        //ovde pises kod koji otvara prvi prozor koji student vidi
                        //MessageBox.Show("Uspesno ulogovan student");
                    }
                    else
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                        //MessageBox.Show("Uspesno ulogovan administrator");
                    }
                }
                else MessageBox.Show("Neispravan username ili password"); //ne znam da li ovo moze nekako bolje da se predstavi na klijentskoj strani ali ne moras da se smaras sa porukama mnogo
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

        
    }
}
