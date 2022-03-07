using System;

namespace Education.Module3
{
    class Program
    {
        static void Main(string[] args)

        {
            const string myName = "Timur";
            Console.WriteLine(myName);
            Console.WriteLine("\t Привет, Мир");
            Console.WriteLine("\t Мне 31 год");
            Console.WriteLine("\t My mane is \n Timur");
            Console.WriteLine("\u0040");
            Console.WriteLine("\u0023");
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(5);
            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);
      
            string name = "Jane";
            byte age = 27;
            string favcolor = "black";
            bool HaveIApet = true;
            double MyShoeSize = 43.5;

            Console.WriteLine("My name is " + name);
            Console.WriteLine("My age " + age);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);
            Console.WriteLine("\t Привет, \n мир!");

            byte Age = 31;
            Console.WriteLine($"Мой возраст {Age}");

            Console.WriteLine("{0}\n{1}\n{2}", name, age,favcolor);

            string str = Console.ReadLine();
            Console.WriteLine(str);

            Console.ReadKey();
        }
           enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green=300
        }

        
    }
}
