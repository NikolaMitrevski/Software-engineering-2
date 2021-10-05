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
    public partial class ListItem6 : UserControl
    {
        private string questionID;
        private string question;
        private string answer1, answer2, answer3, answer4, answer5, answer6;

        private string correctAnswer1, correctAnswer2, correctAnswer3, correctAnswer4, correctAnswer5, correctAnswer6;
        
        public static int counter = 0;

        public bool state1 = true;
        public bool state2 = true;
        public bool state3 = true;
        public bool state4 = true;
        public bool state5 = true;
        public bool state6 = true;

        public ListItem6()
        {
            InitializeComponent();
        }

        public string QuestionID
        {
            get { return questionID; }
            set { questionID = value; label_number_question.Text = value; }
        }
        public string Question
        {
            get { return question; }
            set { question = value; label_question.Text = value;}
        }
        public string Answer1
        {
            get { return answer1; }
            set { answer1 = value; checkBox1.Text = value; if (answer1 == "") checkBox1.Visible = false; }
        }
        public string Answer2
        {
            get { return answer2; }
            set { answer2 = value; checkBox2.Text = value; if (answer2 == "") checkBox2.Visible = false; }
        }
        public string Answer3
        {
            get { return answer3; }
            set { answer3 = value; checkBox3.Text = value; if (answer3 == "") checkBox3.Visible = false; }
        }
        public string Answer4
        {
            get { return answer4; }
            set { answer4 = value; checkBox4.Text = value; if (answer4 == "") checkBox4.Visible = false; }
        }
        public string Answer5
        {
            get { return answer5; }
            set { answer5 = value; checkBox5.Text = value; if (answer5 == "") checkBox5.Visible = false; }
        }
        public string Answer6
        {
            get { return answer6; }
            set { answer6 = value; checkBox6.Text = value; if (answer6 == "") checkBox6.Visible = false; }
        }
        public string CorrectAnswer1
        {
            get { return correctAnswer1; }
            set { correctAnswer1 = value; }
        }
        public string CorrectAnswer2
        {
            get { return correctAnswer2; }
            set { correctAnswer2 = value; }
        }
        public string CorrectAnswer3
        {
            get { return correctAnswer3; }
            set { correctAnswer3 = value; }
        }
        public string CorrectAnswer4
        {
            get { return correctAnswer4; }
            set { correctAnswer4 = value; }
        }
        public string CorrectAnswer5
        {
            get { return correctAnswer5; }
            set { correctAnswer5 = value; }
        }
        public string CorrectAnswer6
        {
            get { return correctAnswer6; }
            set { correctAnswer6 = value; }
        }
        
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if ((correctAnswer1 == "1") && state1)
            {
                state1 = false;
                counter++;
            }
            else if ((correctAnswer1 == "1") && (state1 == false))
            {
                state1 = true;
                counter--;
            }
            else if ((correctAnswer1 == "0") && state1)
            {
                state1 = false;
                counter--;
            }
            else if ((correctAnswer1 == "0") && (state1 == false))
            {
                state1 = true;
                counter++;
            }
        }
        private void checkBox2_Click(object sender, EventArgs e)
        {
            if ((correctAnswer2 == "1") && state2)
            {
                state2 = false;
                counter++;
            }
            else if ((correctAnswer2 == "1") && (state2 == false))
            {
                state2 = true;
                counter--;
            }
            else if ((correctAnswer2 == "0") && state2)
            {
                state2 = false;
                counter--;
            }
            else if ((correctAnswer2 == "0") && (state2 == false))
            {
                state2 = true;
                counter++;
            }
        }
        private void checkBox3_Click(object sender, EventArgs e)
        {
            if ((correctAnswer3 == "1") && state3)
            {
                state3 = false;
                counter++;
            }
            else if ((correctAnswer3 == "1") && (state3 == false))
            {
                state3 = true;
                counter--;
            }
            else if ((correctAnswer3 == "0") && state3)
            {
                state3 = false;
                counter--;
            }
            else if ((correctAnswer3 == "0") && (state3 == false))
            {
                state3 = true;
                counter++;
            }
        }
        private void checkBox4_Click(object sender, EventArgs e)
        {
            if ((correctAnswer4 == "1") && state4)
            {
                state4 = false;
                counter++;
            }
            else if ((correctAnswer4 == "1") && (state4 == false))
            {
                state4 = true;
                counter--;
            }
            else if ((correctAnswer4 == "0") && state4)
            {
                state4 = false;
                counter--;
            }
            else if ((correctAnswer4 == "0") && (state4 == false))
            {
                state4 = true;
                counter++;
            }
        }
        private void checkBox5_Click(object sender, EventArgs e)
        {
            if ((correctAnswer5 == "1") && state5)
            {
                state5 = false;
                counter++;
            }
            else if ((correctAnswer5 == "1") && (state5 == false))
            {
                state5 = true;
                counter--;
            }
            else if ((correctAnswer5 == "0") && state5)
            {
                state5 = false;
                counter--;
            }
            else if ((correctAnswer5 == "0") && (state5 == false))
            {
                state5 = true;
                counter++;
            }
        }
        private void checkBox6_Click(object sender, EventArgs e)
        {
            if ((correctAnswer6 == "1") && state6)
            {
                state6 = false;
                counter++;
            }
            else if ((correctAnswer6 == "1") && (state6 == false))
            {
                state6 = true;
                counter--;
            }
            else if ((correctAnswer6 == "0") && state6)
            {
                state6 = false;
                counter--;
            }
            else if ((correctAnswer6 == "0") && (state6 == false))
            {
                state6 = true;
                counter++;
            }
        }
    }
}
