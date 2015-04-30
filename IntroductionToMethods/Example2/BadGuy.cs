using System;

namespace Example2
{
    public class BadGuy
    {
        private string _name;
        private int _health;

        public BadGuy(string name, int health)
        {
            _name = name;
            _health = health;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetHealth()
        {
            return _health;
        }

        public void TakeDamage(int amount)
        {
            Console.WriteLine(_name + " takes " + amount + " damage.");
            _health -= amount;
        }

        public bool IsAlive()
        {
            return _health > 0;
        }
    }
}