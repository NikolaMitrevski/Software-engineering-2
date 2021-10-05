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
    public partial class TestStudent : Form
    {
        List<ListItem6> listaPitanja = new List<ListItem6>();
        int pitanjeID = 0;

        private OpenFileDialog fd = new OpenFileDialog();
        private FileStream fs;

        public TestStudent()
        {
            InitializeComponent();
            ShowCurrent();
            fd.InitialDirectory = "c://";
            fd.FileOk += fd_FileOK;
        }

        public void ShowCurrent()
        {
            listaPitanja.Clear();
            panel_pitanja.Controls.Clear();

            //int idKursa = Data.idKursa;
            int idTesta = Data.idTesta;

            String query;
            MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");

            try
            {
                con.Open();
                query = "SELECT * FROM pitanje WHERE idTesta = " + idTesta;
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    pitanjeID = pitanjeID + 1;
                    String pitanje = dr[2].ToString();
                    String odgovor1 = dr[3].ToString();
                    String odgovor2 = dr[4].ToString();
                    String odgovor3 = dr[5].ToString();
                    String odgovor4 = dr[6].ToString();
                    String odgovor5 = dr[7].ToString();
                    String odgovor6 = dr[8].ToString();
                    String tacanOdgovor1 = dr[9].ToString();
                    String tacanOdgovor2 = dr[10].ToString();
                    String tacanOdgovor3 = dr[11].ToString();
                    String tacanOdgovor4 = dr[12].ToString();
                    String tacanOdgovor5 = dr[13].ToString();
                    String tacanOdgovor6 = dr[14].ToString();

                    ListItem6 li = new ListItem6();
                    li.QuestionID = pitanjeID.ToString();
                    li.Question = pitanje;
                    li.Answer1 = odgovor1;
                    li.Answer2 = odgovor2;
                    li.Answer3 = odgovor3;
                    li.Answer4 = odgovor4;
                    li.Answer5 = odgovor5;
                    li.Answer6 = odgovor6;
                    li.CorrectAnswer1 = tacanOdgovor1;
                    li.CorrectAnswer2 = tacanOdgovor2;
                    li.CorrectAnswer3 = tacanOdgovor3;
                    li.CorrectAnswer4 = tacanOdgovor4;
                    li.CorrectAnswer5 = tacanOdgovor5;
                    li.CorrectAnswer6 = tacanOdgovor6;

                    listaPitanja.Add(li);
                    panel_pitanja.Controls.Add(li);
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

        private void fd_FileOK(Object sender, EventArgs e)
        {
            if ((fs = (FileStream)fd.OpenFile()) != null)
            {
                byte[] buffer;
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

        private void button_predajTest_Click(object sender, EventArgs e)
        {
            //button_predajTest.Text = ListItem6.counter.ToString();
            int idTesta = Data.idTesta;
            int idStudenta = Data.id;//Data.idKorisnika;
            int ostvareniBodovi = ListItem6.counter;
            
            if(ostvareniBodovi < 0) { ostvareniBodovi = 0; }

            String query = "SELECT idTesta, idKorisnika FROM ostvarenibodovi WHERE idTesta = " + idTesta + " AND idKorisnika = " + idStudenta;
            String query2 = "INSERT INTO ostvarenibodovi (idTesta, idKorisnika, bodovi) VALUES ('" + idTesta + "','" + idStudenta + "','" + ostvareniBodovi + "')";
            String query3 = "UPDATE ostvarenibodovi SET bodovi='" + ostvareniBodovi + "' WHERE idTesta = " + idTesta + " AND idKorisnika = " + idStudenta;

            MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    query = query3;
                }
                else
                {
                    query = query2;
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

            MySqlCommand cmd = new MySqlCommand();
            try
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                cmd.Transaction = transaction;
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
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

            // kada se doda u bazu rezultat testa, counter se vraca na vrednost 0, jer je u pitanju staticka promenljiva
            ListItem6.counter = 0;
            this.Close();
            openChildForm(new StudentListOfCourseForm());

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
    }
}
