using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Student
    {
        public string Name;
        public double StudentID;

        public Student()
        {
            this.Name = Question.AskForString("Enter Student's Full Name");
            this.StudentID = Question.AskForDouble("Enter Student's ID");

        }

    }

}
