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



                Console.ReadKey();
        }
    }
}

