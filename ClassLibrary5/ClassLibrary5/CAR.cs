using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5
{
    public class CAR
    {
        public string carname;
        public string model;
        public int numofcars;
        public CAR(string carname, string model, int numofcars)
        {
            this.carname = carname;
            this.model = model;
            this.numofcars = numofcars;
        }
    }
}
