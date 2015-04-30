using System;

namespace Example2
{
    public class GoodGuy
    {
        private string _name;
        private int _level;

        public GoodGuy(string name, int level)
        {
            _name = name;
            _level = level;
        }

        public void Attack(BadGuy target)
        {
            Console.WriteLine(_name + " attacks " + target.GetName() + ".");
            target.TakeDamage(_level * 10);

            if (target.IsAlive())
            {
                Console.WriteLine(target.GetName() + " has (" + target.GetHealth() + ") health left.");
            }
            else
            {
                Console.WriteLine(target.GetName() + " is dead!");
            }

            Console.WriteLine();
        }
    }
}