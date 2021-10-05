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
    public partial class StudentScore : Form
    {
        public StudentScore()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = ShowScores();
            gridView_listOfScore.DataSource = dt;
        }
        public DataTable ShowScores()
        {
            DataTable data = new DataTable();
            MySqlConnection con = new MySqlConnection("server = localhost; database = Moodle; username = root; password = ;");
            int id = Data.id;
            
            String query = "select kurs.naziv as 'Ime kursa', test.naziv as 'Naziv Testa', bodovi as 'Broj bodova' from kurs inner join test on test.idKursa = kurs.idKursa inner join ostvarenibodovi on test.idTesta = ostvarenibodovi.idTesta where ostvarenibodovi.idKorisnika = " + id;

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
