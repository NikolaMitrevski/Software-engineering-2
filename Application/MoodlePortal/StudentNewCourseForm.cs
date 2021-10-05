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
    public partial class StudentNewCourseForm : Form
    {
        public StudentNewCourseForm()
        {
            InitializeComponent();
        }

        private void StudentNewCourseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button_enroll_Click(object sender, EventArgs e)
        {
            int idKursa = 0;
            // OVDE TREBA ODRADITI DODAVANJE PODATAKA U TABELI KURS
            try
            {
                idKursa = Convert.ToInt32(textBox_course_id.Text);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            // NE ZABORAVI NA ID KORISNIKA KOJI TREBA DA DODAS TAKODJE U TABELU KURS
            int idKorisnika = Data.id;

            MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
            //String query = "UPDATE `upisanikursevi` SET `idKursa`=" + idKursa + ", `idKorisnika`= " + idKorisnika + " WHERE `idKorisnika`= " + Data.idKorisnika;
            String query = "INSERT INTO `upisanikursevi`(`idKursa`, `idKorisnika`) VALUES ("+idKursa+","+idKorisnika+")";

            MySqlCommand cmd = new MySqlCommand();
            try
            {
                //CheckValues(idKursa, idKorisnika);
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                cmd.Transaction = transaction;
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("New course enrolled succesfully");
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
        }

        public void CheckValues(int idKursa,int idKorisnika)
        {
            //OVDE TREBA DA SE PORVERI DA LI UNETI ID POSTOJI U TABELI KURS TJ DA LI POSTOJI TAJ KURS KOJI STUDENT ZELI DA UPISE
            
            
            
        }
    }
}
