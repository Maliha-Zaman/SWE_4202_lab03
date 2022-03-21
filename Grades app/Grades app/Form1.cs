using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Grade_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_ID.Text != "" && txt_semester.Text != "" && txt_classes.Text != "" && txt_Mid.Text != "" && txt_Final.Text != "" && txt_Quiz1.Text != "" && txt_Quiz2.Text != "" && txt_Quiz3.Text != "" && txt_Quiz4.Text != "")
            {
                string Name = txt_Name.Text;
                int ID = Convert.ToInt32(txt_ID.Text);
                int Semester = Convert.ToInt32(txt_semester.Text);
                double no_of_attended_classes = Convert.ToDouble(txt_classes.Text);
                double Mid_Marks = Convert.ToDouble(txt_Mid.Text);
                double Final_Marks = Convert.ToDouble(txt_Final.Text);
                double Quiz_1 = Convert.ToDouble(txt_Quiz1.Text);
                double Quiz_2 = Convert.ToDouble(txt_Quiz2.Text);
                double Quiz_3 = Convert.ToDouble(txt_Quiz3.Text);
                double Quiz_4 = Convert.ToDouble(txt_Quiz4.Text);
                double Attendance = ((no_of_attended_classes / 28) * 30);
                double[] arr_quiz = { Quiz_1, Quiz_2, Quiz_3, Quiz_4 };
                Array.Sort(arr_quiz);
                double Quiz_Marks = 0;
                for (int i = 1; i < arr_quiz.Length; i++)
                {
                    Quiz_Marks = Quiz_Marks + arr_quiz[i];
                }
                lbl_attendance.Text = "Attendance:" + Math.Round(Attendance, 0) + "/30";
                lbl_Mid_marks.Text = "Mid:" + Mid_Marks + "/75";
                lbl_finalmarks.Text = "Final:" + Final_Marks + "/150";
                lbl_Quizmarks.Text = "Quiz:" + Quiz_Marks + "/45";
                double Total = Attendance + Mid_Marks + Final_Marks + Quiz_Marks;
                lbl_Total.Text = "Total:" + Math.Round(Total, 0) + "/300";
                double percentage = (Total / 300) * 100;
                string Grade = null;
                if (percentage >= 80)
                {
                    Grade = "A+";
                }
                else if (percentage >= 75 && percentage < 80)
                {
                    Grade = "A";

                }
                else if (percentage >= 70 && percentage < 75)
                {
                    Grade = "A-";
                }
                else if (percentage >= 65 && percentage < 70)
                {
                    Grade = "B+";
                }
                else if (percentage >= 60 && percentage < 65)
                {
                    Grade = "B";
                }
                else if (percentage >= 55 && percentage < 60)
                {
                    Grade = "B-";
                }
                else if (percentage >= 50 && percentage < 55)
                {
                    Grade = "C+";
                }
                else if (percentage >= 45 && percentage < 50)
                {
                    Grade = "C";
                }
                else if (percentage >= 40 && percentage < 45)
                {
                    Grade = "D";
                }
                else
                {
                    Grade = "F";
                }
                lbl_Grade.Text = "Grade:" + Grade;
                lbl_sentence.Text = Name  + " obtained "  +  Math.Round(percentage, 0)  +  " % marks. ";
            }
            else
            { MessageBox.Show("Error!");
            }

        }
    }
}
