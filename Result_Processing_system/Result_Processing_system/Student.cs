using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_Processing_system
{
    public class Student
    {
        public int id;
        public string name;
        public int attendance;
        public int quiz1;
        public int quiz2;
        public int quiz3;
        public int quiz4;
        public int mid;
        public int final;
        public int viva;
        public int percentage;
        public string grade;
        public int Total;
        public int quiztotal = 0;

        public Student()
        {

        }
        
    public Student(int id, string name, int attendance, int quiz1, int quiz2, int quiz3, int quiz4, int mid, int final, int viva)
        {
            this.id = id;
            this.name = name;
            this.attendance = attendance;
            this.quiz1 = quiz1;
            this.quiz2 = quiz2;
            this.quiz3 = quiz3;
            this.quiz4 = quiz4;
            this.mid = mid;
            this.final = final;
            this.viva = viva;

        }
        public void sort()
        {
            int[] arr_quiz = { quiz1, quiz2, quiz3, quiz4 };
            Array.Sort(arr_quiz);
            
            for (int i = 1; i < arr_quiz.Length; i++)
            {
                quiztotal = quiztotal + arr_quiz[i];
            }
        }
    public void Percentage()
        {
           
            Total = quiztotal + attendance + mid + final + viva;
            percentage = Total / 3;
        }
        public void Grade()
        {
            if (percentage >= 80 && percentage <= 100)
            {
                grade = "A+";
            }
            else if (percentage <= 79 && percentage >= 75)
            {
                grade = "A";
            }
            else if (percentage <= 74 && percentage >= 70)
            {
                grade = "A-";
            }
            else if (percentage <= 69 && percentage >= 65)
            {
                grade = "B+";
            }
            else if (percentage <= 64 && percentage >= 60)
            {
                grade = "B";
            }
            else if (percentage <= 59 && percentage >= 55)
            {
                grade = "B-";
            }
            else if (percentage <= 54 && percentage >= 50)
            {
                grade = "C+";
            }
            else if (percentage <= 49 && percentage >= 45)
            {
                grade = "C";
            }
            else if (percentage <= 44 && percentage >= 40)
            {
                grade = "D";
            }
            else 
            {
                grade = "F";
            }
        }

        public string GetInfo()
        {
            return Convert.ToString(id) + "\t" + name + "\t" + grade + "\t" + percentage;
        }
    }
}
    
    

