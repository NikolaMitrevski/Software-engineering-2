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
    public partial class ListItem3 : UserControl
    {
        public int idTesta;
        public Form parent;
        public ListItem3()
        {
            InitializeComponent();
            button1.Click += (s, e) =>
            {
                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");
                String query = "DELETE FROM test WHERE idTesta = " + idTesta;
                try
                {
                    con.Open();
                    MySqlCommand command =new MySqlCommand();
                    MySqlTransaction transaction = con.BeginTransaction();
                    command.Connection = con;
                    command.Transaction = transaction;
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    
                    MessageBox.Show("Test deleted");
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
            label_test_name.Click += (s, e) =>
            {
                Data.idTesta = idTesta;
                Form1.openChildForm(new Test());
            };
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; label_test_name.Text = value; }
        }
    }
}
