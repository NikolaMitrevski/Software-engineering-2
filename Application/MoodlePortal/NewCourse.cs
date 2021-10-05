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
    public partial class NewCourse : Form
    {
        public NewCourse()
        {
            InitializeComponent();
        }
        public void CheckValues(int id, String naziv, int godina) {
            if (id < 1)
            {
                throw new MissingValueException1("NON VALID ID CHOSEN");
            }
            else if (naziv.Equals("") || naziv == null)
            {
                throw new MissingValueException1("PLEASE ENTER COURSE NAME");
            }
            else if (godina < 1 || godina>4) { 
                throw new MissingValueException1("NON VALID YEAR ENTERED");
            }
        }
        private void button_create_course_Click(object sender, EventArgs e)
        {
            int idKursa = 0;
            int godina = -1;
            String nazivKursa = "";
            // OVDE TREBA ODRADITI DODAVANJE PODATAKA U TABELI KURS
            try
            {
                idKursa = int.Parse(cmbbox_idCourse.Text);
                nazivKursa = textBox_name_course.Text;
                godina = int.Parse(textBox_year_course.Text);
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
            // NE ZABORAVI NA ID KORISNIKA KOJI TREBA DA DODAS TAKODJE U TABELU KURS
            int idKorisnika = Data.id;

            MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
            String query = "UPDATE kurs SET naziv='" + nazivKursa + "' , godina = " + godina + ", idKorisnika = " + idKorisnika + " WHERE idKursa = " + idKursa;
            
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                CheckValues(idKursa, nazivKursa, godina);
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                cmd.Transaction = transaction;
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("New course made succesfully");
                //this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally {
                con.Close();
            }
        }

        private void NewCourse_Load(object sender, EventArgs e)
        {
            // OVDE TREBA DA SE ODRADI PRVO DODAVANJE SLOBODNIH ID KURSEVA U COMBO BOX
            // PRVO PRONADJI BROJ SLOBODNIH ID KURSEVA
            // I ONDA UREDI KOD ISPOD, KOJI TI RADI DODAVANJE STAVKI U COMBO BOX
            
            List<int> slobodniId = new List<int>();
            MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
            String query = "SELECT idKursa FROM kurs WHERE idKorisnika IS NULL";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    cmbbox_idCourse.Items.Add(dr[0].ToString());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally {
                con.Close();
            }

            
        }
    }
    public class MissingValueException1 : Exception {
        public MissingValueException1(String message):base(message){}
    }
}
