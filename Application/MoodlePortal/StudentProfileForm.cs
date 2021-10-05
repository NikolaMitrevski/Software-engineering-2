using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MoodlePortal
{
    public partial class StudentProfileForm : Form
    {
        public StudentProfileForm()
        {
            InitializeComponent();
        }

        private void StudentProfileForm_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; database = Moodle; username = root; password = ;");
            int id = Data.id;
            String query = "SELECT `ime`, `prezime`, `brojIndeksa`, `godinaUpisa`, `godinaStudija`, `smer`, `email` FROM `student` WHERE `idKorisnika`= " + id;
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    String x = dr[0].ToString();
                    String y = dr[1].ToString();
                    String z = dr[2].ToString();
                    String m = dr[3].ToString();
                    String n = dr[4].ToString();
                    String p = dr[5].ToString();
                    String q = dr[6].ToString();

                    label_ime.Text = x;
                    label_prezime.Text = y;
                    label_indeks.Text = z;
                    label_godina_upisa.Text = m;
                    label_godina_studija.Text = n;
                    label_smer.Text = p;
                    label_email.Text = q;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                con.Close();
            }
            String query1 = "SELECT slika FROM profesor WHERE idKorisnika= " + id + " AND slika IS NOT NULL";
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query1, con);
                MySqlDataReader dr = command.ExecuteReader();
                if (dr.Read())

                {

                    var len = dr.GetBytes(0, 0, null, 0, 0);
                    byte[] slika = new byte[len];
                    dr.GetBytes(0, 0, slika, 0, slika.Length);

                    MemoryStream ms = new MemoryStream(slika);
                    Bitmap bm = new Bitmap(ms, false);
                    profile_image.Image = bm;

                }
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
