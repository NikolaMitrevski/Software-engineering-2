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
    public partial class ListItem4 : UserControl
    {
        public int materialID;
        private string _title;

        public ListItem4()
        {
            InitializeComponent();

            label_material_name.Click += (s, e) =>
            {
                MySqlConnection con = new MySqlConnection("server = localhost; username = root; password = ; database = moodle");

                String name = "";
                String ext = "";
                String fullname = "";

                try
                {
                    String query = "SELECT nazivMaterijala, tip FROM materijal WHERE idMaterijala = " + materialID;
                    con.Open();
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlDataReader dr = command.ExecuteReader();

                    dr.Read();
                    name = dr[0].ToString();
                    ext = dr[1].ToString();

                    fullname = name + "." + ext;
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
                    String query = "SELECT sadrzaj FROM materijal WHERE idMaterijala = " + materialID;
                    con.Open();
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlDataReader dr = command.ExecuteReader();
                    dr.Read();

                    var len = dr.GetBytes(0, 0, null, 0, 0);
                    byte[] blob = new byte[len];
                    dr.GetBytes(0, 0, blob, 0, blob.Length);

                    MessageBox.Show("Material downloaded successfuly");
                    System.IO.File.WriteAllBytes(fullname, blob);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    con.Close();
                }
            };
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; label_material_name.Text = value; }
        }
    }
}
