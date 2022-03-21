using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class Student
    {
        public int id;
        public string name;
        public string department;
        public int semester;

        public string getInfo()
        {
            string studentInfo = id.ToString() + "\t" + name + "\t" + department + semester.ToString();
            return studentInfo;
        }
    }

}
