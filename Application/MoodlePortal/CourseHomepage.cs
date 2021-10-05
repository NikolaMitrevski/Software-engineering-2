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
    public partial class CourseHomepage : Form
    {
        List<ListItem> listaMaterijala = new List<ListItem>();
        List<ListItem3> listaTestova = new List<ListItem3>();

        private OpenFileDialog fd = new OpenFileDialog();
        private FileStream fs;

        public CourseHomepage()
        {
            InitializeComponent();
            ShowCurrent();
            fd.InitialDirectory = "c://";
            fd.FileOk += fd_FileOK;
        }

        private void CourseHomepage_Load(object sender, EventArgs e)
        {
            //GenerateDynamicUserControl();

        }
        public void ShowCurrent() {
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
                while (dr.Read()) {
                    int i = Convert.ToInt32(dr[0].ToString());
                    String naziv = dr[4].ToString();
                    ListItem li = new ListItem();
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
            finally {
                con.Close();
                
                
            }
            try
            {
                con.Open();
                query = "SELECT * FROM test WHERE idKursa = " + idKursa;
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    int i = Convert.ToInt32(dr[0].ToString());
                    String naziv = dr[2].ToString();
                    ListItem3 li = new ListItem3();
                    li.Title = naziv;
                    li.idTesta = i;
                    li.parent = this;
                    listaTestova.Add(li);
                    comboBox_select_test.Items.Add(naziv);
                    flowLayoutPanel1.Controls.Add(li);
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
        private void UploadMaterial(String name, String ext, byte[] buffer)
        {
            String query = "INSERT INTO materijal (idKursa, nedelja, sadrzaj, nazivMaterijala, tip) " +

                "VALUES (" + Data.idKursa + "," + Data.currentWeek + ", @sadrzaj ,'" + name + "','" + ext + "')";
            MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand();
                MySqlParameter param = command.Parameters.Add("@sadrzaj", MySqlDbType.LongBlob);
                param.Value = buffer;
                MySqlTransaction transaction = con.BeginTransaction();
                command.Connection = con;
                command.Transaction = transaction;
                command.CommandText = query;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                con.Close();
                ShowCurrent();
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

                UploadMaterial(fileSavename, fileExtention, buffer);
            }
            else MessageBox.Show("No file chosen");
        }
        private void button_upload_file_Click(object sender, EventArgs e)
        {
            // OVDE TREBA DA SE ODRADI DODAVANJE FILE-A U BAZU KLIKOM NA DUGME 
            // NAKON DODAVANJA U BAZU TREBA DA SE PRIKAZE DODAT MATERIJAL U DELU panel_material
            if (comboBox_select_week.SelectedIndex > -1)
            {
                fd.ShowDialog();
            }
            else MessageBox.Show("Please select a course week you wish to add new material to");

        }

        private void comboBox_select_week_SelectedIndexChanged(object sender, EventArgs e)
        {
            // KADA SE IZABERE DRUGA NEDELJA IZ COMBOBOX-A, TREBA DA SE PROMENI VIDLJIV MATERIJAL KURSA(azurira se panel_material)

            int current = comboBox_select_week.SelectedIndex;

            Data.currentWeek = current;
            ShowCurrent();
        }

        private void GenerateDynamicUserControl()
        {
            /*// ZA MATERIJAL
            ListItem[] listItems = new ListItem[20];    // velicina ce zavisiti od broja materijala u nedelji

            for(int i=0;i<listItems.Length;i++)
            {
                listItems[i] = new ListItem(); 
                listItems[i].Title = "Naziv materijala";    // ovde trebaju da idu nazivi materijala
                //if (flowLayoutPanel1.Controls.Count > 0) {
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else 
                flowLayoutPanel1.Controls.Add(listItems[i]);
            }*/

            /*// ZA TEST
            ListItem3[] listItems3 = new ListItem3[5];    // velicina ce zavisiti od broja materijala u nedelji

            for (int i = 0; i < listItems3.Length; i++)
            {
                listItems3[i] = new ListItem3();
                listItems3[i].Title = "Naziv testa";    // ovde trebaju da idu nazivi materijala
                //if (flowLayoutPanel1.Controls.Count > 0) {
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else 
                flowLayoutPanel1.Controls.Add(listItems3[i]);
            }*/


        }

        private void button_create_test_Click(object sender, EventArgs e)
        {
            String ime = textBox_test_name.Text;
            
            // OVDE JE PRVO POTREBNO U KODU KREIRATI TEST
            if ( ime.Equals("")|| ime==null ) {
                MessageBox.Show("Please enter a test name");
            }
            else {
                Data.test_name = textBox_test_name.Text;
                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                
                try
                {
                    con.Open();
                    String query = "INSERT INTO test (idKursa, naziv, omogucen) VALUES (" + Data.idKursa + ",'" + textBox_test_name.Text + "', 'disabled')";
                    MySqlCommand command = new MySqlCommand();
                    MySqlTransaction transaction= con.BeginTransaction();
                    command.Connection = con;
                    command.Transaction = transaction;
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally {
                    con.Close();
                }
                try
                {
                    con.Open();
                    String query = "SELECT max(idTesta) FROM test WHERE idKursa =" + Data.idKursa;
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlDataReader dr = command.ExecuteReader();
                    dr.Read();
                    int i = Convert.ToInt32(dr[0].ToString());
                    Data.idTesta = i;
                    Form1.openChildForm(new Test());
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally {
                    con.Close();
                }

            }
            // NAKON KREIRANJA, PRELAZI SE U FORMU GDE SE DODAJU PITANJA I ODGOVORI
            
        }

        private void button_enable_test_Click(object sender, EventArgs e)
        {
            // OVDE TREBA DA SE AKTIVIRA TEST
            if (comboBox_select_test.SelectedIndex >= 0)
            {
                string select_test = comboBox_select_test.Text; // aktviranje se radi prema imenu testa 
                int idZaIzmenu = 0;
                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                try
                {
                    con.Open();
                    String query = "SELECT idTesta FROM test WHERE naziv = '" + select_test + "'";
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlDataReader dr = command.ExecuteReader();
                    dr.Read();
                    idZaIzmenu = Convert.ToInt32(dr[0].ToString());
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
                    String query = "UPDATE test SET omogucen = 'enabled' WHERE idTesta = " + idZaIzmenu;
                    MySqlCommand command = new MySqlCommand();
                    MySqlTransaction transaction = con.BeginTransaction();
                    command.Connection = con;
                    command.Transaction = transaction;
                    command.CommandText = query;
                    command.ExecuteNonQuery();
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
            }
        }

        private void button_diseable_test_Click(object sender, EventArgs e)
        {
            // OVDE TREBA DA SE DEAKTIVIRA TEST
            if (comboBox_select_test.SelectedIndex >= 0)
            {
                string select_test = comboBox_select_test.Text; // deaktiviranje se radi prema imenu testa 
                int idZaIzmenu = 0;
                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                try
                {
                    con.Open();
                    String query = "SELECT idTesta FROM test WHERE naziv = '" + select_test + "'";
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlDataReader dr = command.ExecuteReader();
                    dr.Read();
                    idZaIzmenu = Convert.ToInt32(dr[0].ToString());
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
                    String query = "UPDATE test SET omogucen = 'disabled' WHERE idTesta=" + idZaIzmenu;
                    MySqlCommand command = new MySqlCommand();
                    MySqlTransaction transaction = con.BeginTransaction();
                    command.Connection = con;
                    command.Transaction = transaction;
                    command.CommandText = query;
                    command.ExecuteNonQuery();
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
            }
        }

        private void button_results_Click(object sender, EventArgs e)
        {
            string select_test = comboBox_select_test.Text;

            flowLayoutPanel1.Controls.Clear();
            StudentScoreForProffesore ss = new StudentScoreForProffesore();

            ss.select_test = select_test;

            ss.LoadData();

            flowLayoutPanel1.Controls.Add(ss);
        }
    }
}
