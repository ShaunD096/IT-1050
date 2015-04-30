using System;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Alana", "Santos", 42, false);

            Person p2 = new Person("Donnie", "Santos");
            p2.SetAge(36);
            p2.SetIsMarried(false);

            Person p3 = new Person();
            p3.SetFirstName("Michael");
            p3.SetLasttName("Santos");
            p3.SetAge(28);
            p3.SetIsMarried(false);

            p1.Print();
            p2.Print();
            p3.Print();

            Console.ReadKey();
        }
    }
}