using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pharmacy_management_system_dependencies;

namespace Pharmacy_Management_system
{
    public partial class Form1 : Form

    {
        public List<Medicine> medicines = new List<Medicine>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddOnClick(object sender, EventArgs e)
        {
            string medName = textBox_MedNamePurchase.Text;
            int price = Convert.ToInt32(textBox_PricePurchase.Text);
            int quantity = Convert.ToInt32(textBox_QuantityPurchase.Text);
            int previous_stock = Convert.ToInt32(textBox_PrevStock.Text);

            Medicine dummy = new Medicine();
            {
                dummy.medName = medName;
                dummy.price = price;
                dummy.quantity = quantity;
                dummy.prevoius_stock = previous_stock;
                dummy.add();
                medicines.Add(dummy);
                MessageBox.Show("New medicine has been added! "+ dummy.prevoius_stock);
                               
            }
        }

        private void SellButtononClick(object sender, EventArgs e)
        {
            foreach(Medicine dummy in medicines)
            {
                if(dummy.medName == textBox_MedNameSales.Text)
                { 
                    dummy.quantity = Convert.ToInt32(textBox_QuantityMedSales.Text);
                    if(dummy.quantity<=dummy.prevoius_stock)
                    {    
                        dummy.sell();
                        MessageBox.Show("Sold");
                    }
                    else
                    {
                        MessageBox.Show("insufficient");
                    }
                }
                else
                {
                    MessageBox.Show("Medicine not found!");
                }
            }
        }

        private void CurrentStockOnclick(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            foreach (Medicine dummy in medicines)
            {
                if(dummy.medName==textBox_MedNameCurrent.Text)
                {
                    
                    for(int i=0;i<medicines.Count;i++)
                    {
                        listbox.Items.Add(medicines[i].getInfo());

                    }

                }
                else
                {
                    MessageBox.Show("Medicines not found");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account balance" + Medicine.current_account);

        }
    }
}
