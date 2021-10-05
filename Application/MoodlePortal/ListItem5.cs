using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodlePortal
{
    public partial class ListItem5 : UserControl
    {
        public int idTesta;
        //public Form parent;
        private string _title;

        public ListItem5()
        {
            InitializeComponent();

            label_test_name.Click += (s, e) =>
            {
                Data.idTesta = idTesta;
                StudentMainForm.openChildForm(new TestStudent());
            };
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; label_test_name.Text = value; }
        }
    }
}
