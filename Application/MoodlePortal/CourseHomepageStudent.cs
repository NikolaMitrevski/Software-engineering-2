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
    public partial class CourseHomepageStudent : Form
    {
        List<ListItem4> listaMaterijala = new List<ListItem4>();
        List<ListItem5> listaTestova = new List<ListItem5>();

        private OpenFileDialog fd = new OpenFileDialog();
        private FileStream fs;

        public CourseHomepageStudent()
        {
            InitializeComponent();
            ShowCurrent();
            fd.InitialDirectory = "c://";
            fd.FileOk += fd_FileOK;
        }

        public void ShowCurrent()
        {
            listaTestova.Clear();
            listaMaterijala.Clear();
            flowLayoutPanel1.Controls.Clear();

            int nedelja = Data.currentWeek;
            int idKursa = Data.idKursa;

            String query;
            MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");

            try
            {
                con.Open();
                query = "SELECT * FROM materijal WHERE idKursa = " + idKursa + " AND nedelja = " + nedelja;
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    int i = Convert.ToInt32(dr[0].ToString());  // id materijala
                    String naziv = dr[4].ToString();

                    ListItem4 li = new ListItem4();
                    li.Title = naziv;
                    li.materialID = i;

                    listaMaterijala.Add(li);
                    flowLayoutPanel1.Controls.Add(li);
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

            try
            {
                con.Open();
                query = "SELECT * FROM test WHERE idKursa = " + idKursa + " AND omogucen = 'enabled'";
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    int i = Convert.ToInt32(dr[0].ToString());  // id testa
                    String naziv = dr[2].ToString();            // naziv testa

                    ListItem5 li = new ListItem5();
                    li.Title = naziv;
                    li.idTesta = i;
                    //li.parent = this;

                    listaTestova.Add(li);
                    flowLayoutPanel1.Controls.Add(li);
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

        private void comboBox_select_week_SelectedIndexChanged(object sender, EventArgs e)
        {
            // KADA SE IZABERE DRUGA NEDELJA IZ COMBOBOX-A, TREBA DA SE PROMENI VIDLJIV MATERIJAL KURSA(azurira se panel_material)
            int current = comboBox_select_week.SelectedIndex;
            Data.currentWeek = current;
            ShowCurrent();
        }

        private void CourseHomepageStudent_Load(object sender, EventArgs e)
        {
            int idKursa = Data.idKursa;

            String query;
            MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");

            try
            {
                con.Open();
                query = "SELECT naziv FROM kurs WHERE idKursa = " + idKursa;
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    String naziv = dr[0].ToString();            // naziv kursa

                    labelNameOfCourse.Text = naziv;
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
