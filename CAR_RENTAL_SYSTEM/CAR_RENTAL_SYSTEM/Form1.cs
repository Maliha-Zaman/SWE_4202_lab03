using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary5;

namespace CAR_RENTAL_SYSTEM
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<CAR> cars = new List<CAR>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveuseronclick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UserId_textbox.Text);
            string name = textBox_UserName.Text;
            string address = textBox_Address.Text;
            string destination = textBox_Destination.Text;

            User dummy = new User(id, name, address, destination);
            users.Add(dummy);
            MessageBox.Show("User has been added successfully");
        }

        private void savecaronclick(object sender, EventArgs e)
        {
            string carname = textBox_Carname.Text;
            string model = textBox_Model.Text;
            int numofcars = Convert.ToInt32(textBox_Numberofcars.Text);
            if (numofcars < 0)
            {
                MessageBox.Show("Number of cars can not be negative");
                return;
            }
            CAR dummy = new CAR(carname, model, numofcars);

            cars.Add(dummy);
            MessageBox.Show("car has been added successsfully");
        }

        private void showuserhistory_onclick(object sender, EventArgs e)
        {
            int userhistoryID = Convert.ToInt32(textBox_IDhistory.Text);
            bool flag = false;
            foreach (User user in users)
            {
                if (user.id == userhistoryID)
                {
                    flag = true;
                    textBox_Usernamehistory.Text = user.name;
                    textBox_Addresshistory.Text = user.address;
                    textBox_Rentedcar.Text = user.CarRented;
                    textBox_Destination.Text = user.destination;
                }
                if (flag == false)
                {
                    MessageBox.Show("User Could Not be Found.");
                }
            }

        }

        private void showcarhistoryonclick(object sender, EventArgs e)
        {
            string carhistoryname = textBox_carnamehistory.Text;
            bool flag = false;
            foreach (CAR car in cars)
            {
                if (car.carname == carhistoryname)
                {
                    flag = true;
                    string Numbercar = Convert.ToString(car.numofcars);
                    textBox_modelhistory.Text = car.model;
                    textBox_availableunit.Text = Numbercar;
                }
                if (flag == false)
                {
                    MessageBox.Show("Car can not be found.");
                }
            }
        }

        private void rentcar_onclick(object sender, EventArgs e)
        {
            bool flagCar = false;
            bool flagUser = false;
            int userid = Convert.ToInt32(textBox_Useridforrent.Text);
            string Carname = textBox_carnameforrent.Text;
            foreach (User user in users)
            {
                if (user.id == userid)
                {
                    flagUser = true;
                    user.CarRented = Carname;
                }
                if (flagUser == false)
                {
                    MessageBox.Show("User Could Not be Found.");
                }
            }
            foreach (CAR car in cars)
            {
                if (car.carname == Carname)
                {
                    flagCar = true;
                    if (flagUser == true)
                    {
                        car.numofcars = car.numofcars - 1;
                        if (car.numofcars > 0)
                        {
                            MessageBox.Show("Car Rented Successfully");
                        }
                        if (car.numofcars < 0)
                        {
                            MessageBox.Show("Car Can't be Negative");
                            car.numofcars++;
                        }

                    }
                }
                if (flagCar == false)
                {
                    MessageBox.Show("Car Could Not be Found.");
                }
            }
        }
    }
    }

