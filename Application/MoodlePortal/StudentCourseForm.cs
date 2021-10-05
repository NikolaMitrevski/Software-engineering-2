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
    public partial class StudentCourseForm : Form
    {
        public StudentCourseForm()
        {
            InitializeComponent();
            //ShowCurrent();
        }

        private void StudentCourseForm_Load(object sender, EventArgs e)
        {

        }

        /*public void ShowCurrent()
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
            finally
            {
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
            finally
            {
                con.Close();
            }
        }*/

        /*private void comboBox_select_week_SelectedIndexChanged(object sender, EventArgs e)
        {
            // KADA SE IZABERE DRUGA NEDELJA IZ COMBOBOX-A, TREBA DA SE PROMENI VIDLJIV MATERIJAL KURSA(azurira se panel_material)

            int current = comboBox_select_week.SelectedIndex;
            Data.currentWeek = current;
            //ShowCurrent();
        }*/

        private void button_see_material_Click(object sender, EventArgs e)
        {
            // OVDE TREBA DA SE ODRADI DA SE VIDI MATERIJAL IZ IZABRANE NEDELJE
        }

        private void button_take_test_Click(object sender, EventArgs e)
        {
            //OVDE TREBA DA SE PRISTUPI IZRADI IZABRANOG TESTA
        }

        private void comboBox_select_week_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // KADA SE IZABERE DRUGA NEDELJA IZ COMBOBOX-A, TREBA DA SE PROMENI VIDLJIV MATERIJAL KURSA(azurira se panel_material)

            int current = comboBox_select_week.SelectedIndex;
            Data.currentWeek = current;
            //ShowCurrent();
        }
    }
}
