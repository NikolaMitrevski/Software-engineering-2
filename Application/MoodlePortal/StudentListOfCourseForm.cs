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
    public partial class StudentListOfCourseForm : Form
    {
        public StudentListOfCourseForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void StudentListOfCourseForm_Load(object sender, EventArgs e)
        {

        }

        /*private void gridView_listOfCourse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // ova metoda je listener za vrstu tabele, vraca se ona vrsta na koju se klikne
            // iz ove metode se podaci prosledjuju u novu formu koja predstavlja taj kurs
            int rowIndex = e.RowIndex;

            if (gridView_listOfCourse.Rows[rowIndex].Cells[0].Value.ToString() != "")
            {
                Data.idKursa = int.Parse(gridView_listOfCourse.Rows[rowIndex].Cells[0].Value.ToString());
                Data.idKorisnika = int.Parse(gridView_listOfCourse.Rows[rowIndex].Cells[1].Value.ToString());
                Data.nazivKursa = gridView_listOfCourse.Rows[rowIndex].Cells[2].Value.ToString();
                Data.godinaKursa = int.Parse(gridView_listOfCourse.Rows[rowIndex].Cells[3].Value.ToString());

                //Form1.openChildForm(new CourseHomepage());
                // OVDE TREBA DA SE ODRADI PRELAZ U FORMU CourseHomepage ali da se ona otvori kao child u odnosu na formu Form1
                StudentMainForm.openChildForm(new StudentCourseForm());
            }
        }*/
        private void LoadData()
        {
            DataTable dt = ShowCourses();
            gridView_listOfCourse.DataSource = dt;

        }
        public DataTable ShowCourses()
        {
            DataTable data = new DataTable();
            MySqlConnection con = new MySqlConnection("server = localhost; database = Moodle; username = root; password = ;");
            int id = Data.id;
            String query = "SELECT `idKursa` AS 'Id kursa', `naziv` AS 'Naziv kursa', `godina` AS Godina, concat(profesor.ime, ' ', profesor.prezime) AS 'Predmetni profesor', `email` AS 'Email profesora' FROM `kurs` INNER JOIN profesor ON profesor.idKorisnika = kurs.idKorisnika WHERE `idKursa` IN (SELECT `idKursa` FROM `upisanikursevi` WHERE `idKorisnika`= " + Data.id + ")";
            
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

        private void gridView_listOfCourse_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            // ova metoda je listener za vrstu tabele, vraca se ona vrsta na koju se klikne
            // iz ove metode se podaci prosledjuju u novu formu koja predstavlja taj kurs
            int rowIndex = e.RowIndex;

            if (gridView_listOfCourse.Rows[rowIndex].Cells[0].Value.ToString() != "")
            {
                Data.idKursa = int.Parse(gridView_listOfCourse.Rows[rowIndex].Cells[0].Value.ToString());
                //Data.idKorisnika = int.Parse(gridView_listOfCourse.Rows[rowIndex].Cells[1].Value.ToString());
                Data.nazivKursa = gridView_listOfCourse.Rows[rowIndex].Cells[1].Value.ToString();
                Data.godinaKursa = int.Parse(gridView_listOfCourse.Rows[rowIndex].Cells[2].Value.ToString());

                //Form1.openChildForm(new CourseHomepage());
                // OVDE TREBA DA SE ODRADI PRELAZ U FORMU CourseHomepage ali da se ona otvori kao child u odnosu na formu Form1
                StudentMainForm.openChildForm(new CourseHomepageStudent());
            }
        }
    }
}
