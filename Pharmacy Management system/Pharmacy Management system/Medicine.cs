using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_system
{
    public class Medicine
    {
        public string medName;
        public int price;
        public int quantity;
        public int prevoius_stock;
        public static int current_account = 0;

        public void add()
        {
            this.prevoius_stock = this.prevoius_stock + this.quantity;
        }
        public void sell()
        {
            this.prevoius_stock = this.prevoius_stock - this.quantity;
            current_account += this.quantity * this.price;
        }
        public string getInfo()
        {
            return this.medName + "\t" + Convert.ToString(this.prevoius_stock);
        }
    }

}
