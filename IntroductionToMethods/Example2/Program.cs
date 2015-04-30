using System;

namespace Example2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GoodGuy frodo = new GoodGuy("Frodo", 1);
            GoodGuy aragorn = new GoodGuy("Aragorn", 20);
            BadGuy orc = new BadGuy("Orc", 100);

            frodo.Attack(orc);
            frodo.Attack(orc);
            frodo.Attack(orc);
            aragorn.Attack(orc);

            Console.ReadKey();
        }
    }
}