using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter double: ");
            double NumDouble = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter float: ");
            float NumFloat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("HI," + Name);
            Console.WriteLine(Age);
            Console.WriteLine(NumDouble);
            Console.WriteLine(NumFloat);

        }
    }
}
