using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class teachers
    {
        public int ID;
        public string Name;
        public  string dept;
        public  string designation;
        public int salary;

        public string getInfo()
        {
            string teacherInfo  = ID.ToString() + "\t" + Name + "\t" + dept +"\t"+ designation + "\t" + salary.ToString();
            return teacherInfo;
        }

    }
}
