using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MoodlePortal
{
    public partial class StudentScoreForProffesore : UserControl
    {
        public string select_test;
        public StudentScoreForProffesore()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            DataTable dt = ShowScores();
            gridView_listOfScore.DataSource = dt;
        }
        public DataTable ShowScores()
        {
            DataTable data = new DataTable();
            MySqlConnection con = new MySqlConnection("server = localhost; database = Moodle; username = root; password = ;");

            //String query = "select kurs.naziv as 'Ime kursa', test.naziv as 'Naziv Testa', bodovi as 'Broj bodova' from kurs inner join test on test.idKursa = kurs.idKursa " +
            //"inner join ostvarenibodovi on test.idTesta = ostvarenibodovi.idTesta where kurs.idKursa = " + Data.idKursa + " AND test.naziv = '" + select_test + "'";

            String query = "select kurs.naziv as 'Ime kursa', test.naziv as 'Naziv testa', ime as 'Ime studenta', prezime AS 'Prezime studenta', brojIndeksa AS 'Broj indeksa', bodovi as 'Broj bodova' from kurs inner join test on test.idKursa = kurs.idKursa " +
                "inner join ostvarenibodovi on test.idTesta = ostvarenibodovi.idTesta inner join student on student.idKorisnika = ostvarenibodovi.idKorisnika where kurs.idKursa = " + Data.idKursa + " AND test.naziv = '" + select_test + "'";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(data);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                con.Close();
            }
            return data;
        }
    }
}
