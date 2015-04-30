using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Question.Ask("What is your name?");
            int age = Question.AskForNumber("What is your age?");
            bool married = Question.AskYesOrNo("Are you married?");

            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(married);
            Console.ReadKey();
        }
    }
}