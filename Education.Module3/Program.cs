using System;

namespace Education.Module3
{
    class Program
    {
        static void Main()

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

            double result = 5.0 / 2.0 * 3.0;
            Console.WriteLine("Value: {0}", result);

            int olddata = 6;
            string data = olddata.ToString();

            Console.WriteLine(data);

            Console.WriteLine(olddata);

            Console.Write("Enter your age: ");
            int agge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is {0} ", agge);

            Console.Write("Enter your name: ");
            string namee = Console.ReadLine();
            Console.Write("Enter your age: ");
            string agee = Console.ReadLine();
            Console.WriteLine("Your name is {0} and age is {1} ", namee, agee);
            Console.Write("What is your favorite day of week?: ");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is  {0} ", day);

            Console.Write("Введите имя: ");
            var Name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            var AGE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age {1}", Name, AGE);

            Console.Write("Введите дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Your birtdate is {0}", birthdate);

            Console.ReadKey();
        }

            enum DaysOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
        
            

           enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green=300
        }

        
    }
}
