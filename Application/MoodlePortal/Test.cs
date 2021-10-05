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
    public partial class Test : Form
    {
        List<ListItem2> listaPitanja = new List<ListItem2>();
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            label_nameOfTest.Text = Data.test_name;
            ShowQuestions();
        }

        private void button_add_QA_Click(object sender, EventArgs e)
        {
            // OVDE TREBA DODATI PITANJA I ODGOVORE U BAZU ZAJEDNO SA REDNIM BROJEM TACNOG ODGOVORA
            string question = textBox_question.Text;
            string answer1 = textBox_answer1.Text;
            string answer2 = textBox_answer2.Text;
            string answer3 = textBox_answer3.Text;
            string answer4 = textBox_answer4.Text;
            string answer5 = textBox_answer5.Text;
            string answer6 = textBox_answer6.Text;

            int correct_answer1, correct_answer2, correct_answer3, correct_answer4, correct_answer5, correct_answer6;

            if (checkBoxCorrect_answer1.Checked) { correct_answer1 = 1; }    // odgovor sa rednim brojem 1 je tacan
            else { correct_answer1 = 0; }    // odgovor sa rednim brojem 1 nije tacan
            if (checkBoxCorrect_answer2.Checked) { correct_answer2 = 1; }
            else { correct_answer2 = 0; }
            if (checkBoxCorrect_answer3.Checked) { correct_answer3 = 1; }
            else { correct_answer3 = 0; }
            if (checkBoxCorrect_answer4.Checked) { correct_answer4 = 1; }
            else { correct_answer4 = 0; }
            if (checkBoxCorrect_answer5.Checked) { correct_answer5 = 1; }
            else { correct_answer5 = 0; }
            if (checkBoxCorrect_answer6.Checked) { correct_answer6 = 1; }
            else { correct_answer6 = 0; }

            MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
            String query = "INSERT INTO pitanje (idTesta, pitanje, odgovor1, odgovor2, odgovor3, odgovor4, odgovor5, odgovor6, tacanOdgovor1, tacanOdgovor2, tacanOdgovor3, tacanOdgovor4, tacanOdgovor5, tacanOdgovor6) VALUES (" + Data.idTesta + ",'" + question + "',"; 
            // NAKON DODAVANJA, prikazati u panel_main
            if (!answer1.Equals("") && answer1 != null)
            {
                query += "'" + answer1 + "',";
            }
            else query += "NULL,";
            if (!answer2.Equals("") && answer2 != null) {
                query += "'" + answer2 + "',";
            }
            else query += "NULL,";
            if (!answer3.Equals("") && answer3 != null)
            {
                query += "'" + answer3 + "',";
            }
            else query += "NULL,";
            if (!answer4.Equals("") && answer4 != null)
            {
                query += "'" + answer4 + "',";
            }
            else query += "NULL,";
            if (!answer5.Equals("") && answer5 != null)
            {
                query += "'" + answer5 + "',";
            }
            else query += "NULL,";
            if (!answer6.Equals("") && answer6 != null)
            {
                query += "'" + answer6 + "',";
            }
            else query += "NULL,";
            query += "'" + correct_answer1 + "',";
            query += "'" + correct_answer2 + "',";
            query += "'" + correct_answer3 + "',";
            query += "'" + correct_answer4 + "',";
            query += "'" + correct_answer5 + "',";
            query += "'" + correct_answer6 + "')";
            textBox_answer1.Text = "";
            textBox_answer2.Text = "";
            textBox_answer3.Text = "";
            textBox_answer4.Text = "";
            textBox_answer5.Text = "";
            textBox_answer6.Text = "";
            textBox_question.Text = "";
            checkBoxCorrect_answer1.Checked = false;
            checkBoxCorrect_answer2.Checked = false;
            checkBoxCorrect_answer3.Checked = false;
            checkBoxCorrect_answer4.Checked = false;
            checkBoxCorrect_answer5.Checked = false;
            checkBoxCorrect_answer6.Checked = false;
            try
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                MySqlCommand command = new MySqlCommand();
                command.Connection = con;
                command.Transaction = transaction;
                command.CommandText = query;
                command.ExecuteNonQuery();
                transaction.Commit();
                ShowQuestions();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally {
                con.Close();
            }
        }
        private void ShowQuestions() {
            int number = 1;
            flowLayoutPanel2.Controls.Clear();
            listaPitanja.Clear();
            MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
            String query = "SELECT * FROM pitanje WHERE idTesta = " + Data.idTesta;
            try {
                con.Open();
                MySqlCommand command = new MySqlCommand(query,con);
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    ListItem2 li = new ListItem2();
                    int i = Convert.ToInt32(dr[0].ToString());
                    String pitanje = dr[2].ToString();
                    String odgovor1 = dr[3].ToString(); 
                    String odgovor2 = dr[4].ToString();
                    String odgovor3 = dr[5].ToString();
                    String odgovor4 = dr[6].ToString();
                    String odgovor5 = dr[7].ToString();
                    String odgovor6 = dr[8].ToString();
                    int tacanOdgovor1 = Convert.ToInt32(dr[9].ToString());
                    int tacanOdgovor2 = Convert.ToInt32(dr[10].ToString());
                    int tacanOdgovor3 = Convert.ToInt32(dr[11].ToString());
                    int tacanOdgovor4 = Convert.ToInt32(dr[12].ToString());
                    int tacanOdgovor5 = Convert.ToInt32(dr[13].ToString());
                    int tacanOdgovor6 = Convert.ToInt32(dr[14].ToString());
                    li.idPitanja = i;
                    li.Question = pitanje;
                    li.tacanOdgovor1 = tacanOdgovor1;
                    li.tacanOdgovor2 = tacanOdgovor2;
                    li.tacanOdgovor3 = tacanOdgovor3;
                    li.tacanOdgovor4 = tacanOdgovor4;
                    li.tacanOdgovor5 = tacanOdgovor5;
                    li.tacanOdgovor6 = tacanOdgovor6;
                    li.Answer = odgovor1;
                    li.Answer2 = odgovor2;
                    li.Answer3 = odgovor3;
                    li.Answer4 = odgovor4;
                    li.Answer5 = odgovor5;
                    li.Answer6 = odgovor6;
                    li.NumberQuestion = number.ToString();
                    number++;
                    listaPitanja.Add(li);
                    flowLayoutPanel2.Controls.Add(li);
                    
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
        private void GenerateDynamicUserControl()
        {
            /*ListItem2[] listItems = new ListItem2[20];    // velicina ce zavisiti od broja pitanja

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem2();
                listItems[i].NumberQuestion = "Redni broj pitanja";    // vrednost treba promeniti na vrednost iz baze
                listItems[i].Question = "Pitanje";    // vrednost treba promeniti na vrednost iz baze
                listItems[i].Answer = "Odgovor";    // vrednost treba promeniti na vrednost iz baze
                listItems[i].Answer2 = "Odgovor";    // vrednost treba promeniti na vrednost iz baze
                listItems[i].Answer3 = "Odgovor";    // vrednost treba promeniti na vrednost iz baze
                listItems[i].Answer4 = "Odgovor";    // vrednost treba promeniti na vrednost iz baze
                listItems[i].Answer5 = "Odgovor";    // vrednost treba promeniti na vrednost iz baze
                listItems[i].Answer6 = "Odgovor";    // vrednost treba promeniti na vrednost iz baze

                //if (flowLayoutPanel1.Controls.Count > 0) {
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else 
                flowLayoutPanel2.Controls.Add(listItems[i]);*/
            }

       
    }
}

