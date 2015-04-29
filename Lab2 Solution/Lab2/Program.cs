using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person();
            John.Firstname = "John";
            John.Lastname = "Smith";

            Person Rose = new Person();
            Rose.Firstname = "Rose";
            Rose.Lastname = "Tyler";

            Pet A = new Pet();
            A.PetName = "Max";
            A.PetAge = 6;
            A.Species = "Dog";

            Pet B = new Pet();
            B.PetName = "Lou";
            B.PetAge = 2;
            B.Species = "Dog";

            Pet C = new Pet();
            C.PetName = "Fluffy";
            C.PetAge = 1;
            C.Species = "Cat";

            A.Owner = John;
            B.Owner = Rose;
            C.Owner = Rose;

           
            Console.WriteLine(" Pets Name    : " + A.PetName);
            Console.WriteLine(" Pets Species : " + A.Species);
            Console.WriteLine(" Pets Age     : " + A.PetAge);
            Console.WriteLine(" Pets Owner   : " + A.Owner.GetFullname());

            Console.WriteLine();

            Console.WriteLine(" Pets Name    : " + B.PetName);
            Console.WriteLine(" Pets Species : " + B.Species);
            Console.WriteLine(" Pets Age     : " + B.PetAge);
            Console.WriteLine(" Pets Owner   : " + B.Owner.GetFullname());

            Console.WriteLine();

            Console.WriteLine(" Pets Name    : " + C.PetName);
            Console.WriteLine(" Pets Species : " + C.Species);
            Console.WriteLine(" Pets Age     : " + C.PetAge);
            Console.WriteLine(" Pets Owner   : " + C.Owner.GetFullname());
            
            Console.ReadKey();

        }

       
    }
}
