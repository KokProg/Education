using System;

namespace Education.Module_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myapples = 5;
            var hisapples = 6;
            var hisspeares = 5;

            var result = (myapples != hisspeares) & (myapples < hisapples);
            Console.WriteLine(result);



            int currentDayInYear = 293;
            bool isLeapYear = false;

            bool isWinter =
               !isLeapYear && (currentDayInYear >= 335 || currentDayInYear <= 59)
               ||
               isLeapYear && (currentDayInYear >= 336 || currentDayInYear <= 60);

            Console.WriteLine("Текущее время года - зима: {0}", isWinter);

            string A = "апр";
            string B = "апр";

            bool C = A != B;

            Console.WriteLine(C);

            int a = 13;
            int b = 12;
            double x = 14;
            double y = 15;
            bool c = (a < b) || (x > y);
            Console.WriteLine(c);

            var f = 6;
            var h = 11;
            if (f == h)
            {
                Console.WriteLine("Условие истино");
            }
            else
            {
                Console.WriteLine("Условие ложно");

                if (h < 10)
                {
                    Console.WriteLine("Значение h = {0} меньше 10", h);
                }
                else
                {
                    Console.WriteLine("Значение h = {0} больше 10", h);
                }
            }
                if (f == h)
                {
                    Console.WriteLine("Условие истино");
                }
                else if(h<10)
                {
                    Console.WriteLine("Значение h = {0} меньше 10", h);
                }
                else
                {
                    Console.WriteLine("Значение h = {0} больше 10", h);
                }
            
                if (f == h && b > 1)
            {
                Console.WriteLine("Условие истино");
            }
                else if (b > 10 || b == 7)
            {
                Console.WriteLine("Значение h = {0} больше 10 или равно 7", h);
            }
            else 
            {
                Console.WriteLine("Значение h = {0}", h);
            }

            var g = f != h ? f + h : h;

            Console.WriteLine(g);

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")

            {
               Console.BackgroundColor = ConsoleColor.DarkRed;
               Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");

            }

            else if (color == "green")

            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }
            Console.ReadKey();


        }
    }
}

