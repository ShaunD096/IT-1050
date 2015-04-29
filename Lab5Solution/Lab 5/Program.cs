using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool reset = false;

            while (reset == false)
            {
                Course A = new Course();
                Console.WriteLine("Course Name     :" + A.Name);
                Console.WriteLine("Course ID       :" + A.ID);
                Console.WriteLine("Students Enrolled");
                foreach (Student student in A.Students)
                {
                    Console.WriteLine("Student Name   :" + student.Name);
                    Console.WriteLine("Student ID     :" + student.StudentID);
                }
                Console.Write("Would you like to reset (True/False)  :");
                reset = Console.ReadLine().ToLower().StartsWith("f");
            }

            Console.ReadLine();
        }
    }
}