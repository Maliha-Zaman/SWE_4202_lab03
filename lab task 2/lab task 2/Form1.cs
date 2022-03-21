using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_task_2
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Saveonclick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID_textbox.Text);
            string name = Name_textbox.Text;
            string designation = Designation_textbox.Text;

            Employee dummy_std = new Employee
            {
                id = id,
                name = name,
                designation = designation
            };


            employees.Add(dummy_std);

            MessageBox.Show("Information has been added successfully");

        }

        private void clearonclick(object sender, EventArgs e)
        {
            Name_textbox.Text = String.Empty;
            ID_textbox.Text = String.Empty;
            Designation_textbox.Text = String.Empty;
            

            MessageBox.Show("Information has been cleared Successfully");

        }

        private void showEmpList(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < employees.Count; i++)
            {
                listBox1.Items.Add(employees[i].getInfo());
            }
        }
    }
}
