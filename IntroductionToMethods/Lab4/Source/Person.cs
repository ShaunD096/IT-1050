using System;

namespace Lab4
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
    }

     public static Person Create(string prefix)
    {
        Questiom.SetPromtPrefix(prefix);

        person.FirstName = Question.AskForString("First Name");
            person.LastName = Question.AskForString("Last Name");
            person.Age = Question.AskForInteger("Age");

            if (Question.AskForBoolean("Married?"))
            {
                person.Spouse = new Person();
                person.Spouse.FirstName = Question.AskForString("Spouse First Name");
                person.Spouse.Age = Question.AskForInteger("Spouse Age");
                person.Spouse.LastName = person.LastName;
                person.Spouse.Spouse = person;
            }

            return person;
            }
        }
}