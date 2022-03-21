using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<teachers> teacher = new List<teachers>();
        public Form1()
        {
            InitializeComponent();
        }

        private void saveonclick_students(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(studentID_textbox.Text);
            string  name = StudentName_textBox.Text;
            string department = Studentdept_textBox.Text;
            int Semester = Convert.ToInt32(Studentsemester_textBox.Text);

            Student dummy_student = new Student();
            dummy_student.id = id;
            dummy_student.name = name;
            dummy_student.department = department;
            dummy_student.semester = Semester;

            students.Add(dummy_student);
            MessageBox.Show("Student has been added successfully!");
        }

        private void Clearonclick_students(object sender, EventArgs e)
        {
            studentID_textbox.Text = String.Empty;
            StudentName_textBox.Text = String.Empty;
            Studentdept_textBox.Text = String.Empty;
            Studentsemester_textBox.Text = String.Empty;
            MessageBox.Show("Cleared Successfully!");

        }

        private void showstudentsonclick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                listBox1.Items.Add(students[i].getInfo());
            }
        }

        private void teacherssaveonclick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TeacherID_textBox.Text);
            string name = TeacherName_textBox.Text;
            string department = Teacherdept_textBox.Text;
            string designation = designation_textBox.Text;
            int salary = Convert.ToInt32(salary_textBox.Text);


            teachers dummy_teacher = new teachers();
            dummy_teacher.ID = id;
            dummy_teacher.Name = name;
            dummy_teacher.dept = department;
            dummy_teacher.designation = designation;
            dummy_teacher.salary = salary;

            teacher.Add(dummy_teacher);
            MessageBox.Show("teacher has been added successfully!");
        }

        private void teacherclearonclick(object sender, EventArgs e)
        {
            TeacherID_textBox.Text = String.Empty;
            TeacherName_textBox.Text = String.Empty;
            designation_textBox.Text = String.Empty;
            Teacherdept_textBox.Text = String.Empty;
            salary_textBox.Text = String.Empty;
            MessageBox.Show("Cleared Successfully!");
        }

        private void showteachersonclick(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < teacher.Count; i++)
            {
                listBox2.Items.Add(teacher[i].getInfo());
            }
        }
    }
}
