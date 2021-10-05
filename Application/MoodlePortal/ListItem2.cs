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
    public partial class ListItem2 : UserControl
    {
        public int idPitanja;
        public int tacanOdgovor1, tacanOdgovor2, tacanOdgovor3, tacanOdgovor4, tacanOdgovor5, tacanOdgovor6;
        public ListItem2()
        {
            InitializeComponent();
            button_delete_file.Click += (s, e) =>
            {
                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                String query = "DELETE FROM pitanje WHERE idPitanja=" + idPitanja;
                try
                {
                    con.Open();
                    MySqlCommand command = new MySqlCommand();
                    MySqlTransaction transaction = con.BeginTransaction();
                    command.Transaction = transaction;
                    command.Connection = con;
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Question deleted");
                    this.Hide();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally {
                    con.Close();
                }
            };
        }

        private string _number_question;
        public string NumberQuestion
        {
            get { return _number_question; }
            set { _number_question = value; label_number_question.Text = value; }
        }

        private string _question;
        public string Question
        {
            get { return _question; }
            set { _question = value; label_question.Text = value; }
        }

        private string _answer1;
        public string Answer
        {
            get { return _answer1; }
            set { _answer1 = value; label_answer1.Text = value; }
        }

        private string _answer2;
        public string Answer2
        {
            get { return _answer2; }
            set { _answer2 = value; label_answer2.Text = value; }
        }

        private string _answer3;
        public string Answer3
        {
            get { return _answer3; }
            set { _answer3 = value; label_answer3.Text = value; }
        }

        private string _answer4;
        public string Answer4
        {
            get { return _answer4; }
            set { _answer4 = value; label_answer4.Text = value; }
        }

        private string _answer5;
        public string Answer5
        {
            get { return _answer5; }
            set { _answer5 = value; label_answer5.Text = value; }
        }

        private string _answer6;
        public string Answer6
        {
            get { return _answer6; }
            set { _answer6 = value; label_answer6.Text = value; }
        }

        private void button_delete_file_Click(object sender, EventArgs e)
        {
            // OVDE TREBA DA SE UKLONI PITANJE IZ BAZE
        }

    }
}
