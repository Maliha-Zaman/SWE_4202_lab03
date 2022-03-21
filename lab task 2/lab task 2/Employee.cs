using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_2
{
    internal class Employee
    {
        public int id;
        public string name;
        public string designation;

        public string getInfo()
        {
            string empInfo = id.ToString() + "\t" + name + "\t" + designation;
            return empInfo;
        }
    }
}
