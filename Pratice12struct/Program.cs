using System;

namespace Pratice12struct
{
    class Program
    {
        public struct Person
        {
            public string Name;
            public int Age;
            public int Weight;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("============================Student Data==============================");

            // Declare obj of person type
            Person p1;
            p1.Name = "Pooja";
            p1.Age = 22;
            p1.Weight = 64;

            Console.WriteLine("Personal Details Of The Student");
            Console.WriteLine("Name : {0} \t Age : {1} \t Weight : {2}",p1.Name, p1.Age, p1.Weight);

            //Copy the details of a person into another object
            Person p2 = p1;
            p2.Name = "Pihu";
            Console.WriteLine("Personal Details Of The Student");
            Console.WriteLine("Name : {0} \t Age : {1} \t Weight : {2}", p2.Name, p2.Age, p2.Weight);

            Person p3 = p2;
            p3.Age = 21;
            Console.WriteLine("Personal Details Of The Student");
            Console.WriteLine("Name : {0} \t Age : {1} \t Weight : {2}", p3.Name, p3.Age, p3.Weight);

        }
    }
}
