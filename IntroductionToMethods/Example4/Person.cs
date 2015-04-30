using System;

namespace Example4
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private bool _isMarried;

        #region Public Set Methods

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }

        public void SetLasttName(string lastName)
        {
            _lastName = lastName;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void SetIsMarried(bool isMarried)
        {
            _isMarried = isMarried;
        }

        #endregion

        #region Constructors

        public Person()
        {
        }

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public Person(string firstName, string lastName, int age, bool isMarried)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _isMarried = isMarried;
        }

        #endregion

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine(" First Name : " + _firstName);
            Console.WriteLine(" Last Name  : " + _lastName);
            Console.WriteLine(" Age        : " + _age);
            Console.WriteLine(" Married    : " + (_isMarried ? "Yes" : "No"));
        }
    }
}