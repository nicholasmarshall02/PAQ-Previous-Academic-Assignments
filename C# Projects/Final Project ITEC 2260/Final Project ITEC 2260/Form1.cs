using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final_Project_ITEC_2260
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            int cnt = 0;

            //List to hold question numbers of incorrect answers
            List<int> incorrect = new List<int>();

            //Array to store correct answers
            string[] correctAnswers = { };

            //Array to store answers
            string[] answers = { };

            //Read the files and store answers in arrays
            System.IO.StreamReader correctFile = new System.IO.StreamReader("C:/Users/Administrator/Desktop/Final Project ITEC 2260/Final Project ITEC 2260/bin/Debug/correctAnswers.txt");
            System.IO.StreamReader answerFile = new System.IO.StreamReader("C:/Users/Administrator/Desktop/Final Project ITEC 2260/Final Project ITEC 2260/bin/Debug/answers.txt");

            if ((line = correctFile.ReadLine()) != null)
                correctAnswers = line.Split(' ');

            if ((line = answerFile.ReadLine()) != null)
                answers = line.Split(' ');

            //Compare answers and compute the score
            for (int i = 0; i < 20; i++)
            {
                if (correctAnswers.Count() > i && answers.Count() > i)
                {
                    if (String.Compare(correctAnswers[i], answers[i]) == 0)
                        cnt++;
                    else
                        incorrect.Add(i + 1);
                }
            }
            //Print Result
            if (cnt >= 15)
                MessageBox.Show("\n\n Result: PASS");
            else
                MessageBox.Show("\n\n Result: FAIL");

            //Printing score
            MessageBox.Show("\n Total number of Correct Answers: " + cnt);
            MessageBox.Show("\n Total number of Incorrect Answers: " + (20 - cnt));

            MessageBox.Show("\n Question numbers that were incorrect answers: ");
            //Printing incorrectly answered question numbers
            foreach (int qno in incorrect)
                MessageBox.Show(" " + qno + " ");

            //Closing Files
            correctFile.Close();
            answerFile.Close();

        }
    }
}
