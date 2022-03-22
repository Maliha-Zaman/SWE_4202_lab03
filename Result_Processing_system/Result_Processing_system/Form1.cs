using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result_Processing_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            using (var reader = new System.IO.StreamReader(@"E:\SWE4201MarkSheet.csv"))
            {
                InitializeListBoxValues();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    Student dummy_student = new Student();
                    try
                    {
                        dummy_student.id = Convert.ToInt32(values[0]);
                    }
                    catch
                    {
                        dummy_student.id = 0;
                    }
                    try

                    {
                        dummy_student.name = values[1];
                    }
                    catch
                    {
                        dummy_student.name = "0";
                    }

                    try
                    {
                        dummy_student.attendance = Convert.ToInt32(values[2]);
                    }
                    catch
                    {
                        dummy_student.attendance = 0;
                    }
                    try
                    {
                        dummy_student.quiz1 = Convert.ToInt32(values[3]);
                    }
                    catch
                    {
                        dummy_student.quiz1 = 0;
                    }
                    try
                    {
                        dummy_student.quiz2 = Convert.ToInt32(values[4]);
                    }
                    catch
                    {
                        dummy_student.quiz2 = 0;
                    }
                    try
                    {
                        dummy_student.quiz3 = Convert.ToInt32(values[5]);

                    }
                    catch
                    {
                        dummy_student.quiz3 = 0;
                    }
                    try
                    {
                        dummy_student.quiz4 = Convert.ToInt32(values[6]);
                    }
                    catch
                    {
                        dummy_student.quiz4 = 0;
                    }
                    try
                    {
                        dummy_student.mid = Convert.ToInt32(values[7]);
                    }
                    catch
                    {
                        dummy_student.mid = 0;
                    }
                    try
                    {
                        dummy_student.final = Convert.ToInt32(values[8]);
                    }
                    catch
                    {
                        dummy_student.final = 0;
                    }
                    try
                    {
                        dummy_student.viva = Convert.ToInt32(values[9]);
                    }
                    catch
                    {
                        dummy_student.viva = 0;
                    }
                    dummy_student.sort();

                    dummy_student.Percentage();

                    dummy_student.Grade();
                    Studentlist.studentsList.Add(dummy_student);
                }

            }
            InitializeListBoxValues();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeListBoxValues()
        {
            listBox1.Items.Clear();
            foreach (Student temp in Studentlist.studentsList)
            {
                listBox1.Items.Add(temp.GetInfo());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClickonSearch(object sender, EventArgs e)
        {
            {
                foreach (Student dummy in Studentlist.studentsList)
                {
                    var Student = from student in Studentlist.studentsList
                                  select dummy.id;
                    if (dummy.id == Convert.ToInt32(textBox_Idsearch.Text))
                    {
                        label_attendance.Text = Convert.ToString(dummy.attendance);
                        label_q1.Text = Convert.ToString(dummy.quiz1);
                        label_q2.Text = Convert.ToString(dummy.quiz2);
                        label_q3.Text = Convert.ToString(dummy.quiz3);
                        label_q4.Text = Convert.ToString(dummy.quiz4);
                        label_qtotal.Text = Convert.ToString(dummy.quiztotal);
                        label_mid.Text = Convert.ToString(dummy.mid);
                        label_final.Text = Convert.ToString(dummy.final);
                        label_viva.Text = Convert.ToString(dummy.viva);
                        label_Total.Text = Convert.ToString(dummy.Total);
                        label_percen.Text = Convert.ToString(dummy.percentage);
                       label_grade.Text = Convert.ToString(dummy.grade);
                    }

                }
            }
        }
    }
}
            
        
    
        
    

