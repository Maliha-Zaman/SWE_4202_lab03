using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_profile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var reader = new System.IO.StreamReader(@"E:\userInfo.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    User dummy_user = new User(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]);
                    UserList.usersList.Add(dummy_user);
                }
            }
            InitializeListBoxValues();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void InitializeListBoxValues()
        {
            listBox1.Items.Clear();
            foreach (User temp in UserList.usersList)
            {
                listBox1.Items.Add(temp.getinfo());
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        

        }

        private void clickonsearch(object sender, EventArgs e)
        {
            bool found = false;
            foreach (User dummy in UserList.usersList)
            {
                if (dummy.phone == textBox_phoneno.Text)
                {
                    listBox2.Items.Add(dummy.GETINFO());
                    using (System.IO.StreamWriter writer =System.IO. File.AppendText(@"E:\log.txt"))
                    {
                        writer.WriteLine(dummy.getinfo() + DateTime.Now);
                    }
                    found = true;
                }

            }
            if (!found)
            {
                MessageBox.Show("ID Not Found");
                using (System.IO.StreamWriter writer = System.IO.File.AppendText(@"E:\log.txt"))
                {
                    writer.WriteLine(textBox_phoneno.Text + ": ID Not Found" + DateTime.Now);
                }

            }
        }
    }
}
