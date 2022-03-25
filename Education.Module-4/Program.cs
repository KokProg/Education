using System;

namespace Education.Module_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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

                        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

                        var colorr = Console.ReadLine();

                        switch(colorr)
                        {
                            case "red":
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;

                                Console.WriteLine("Your color is red!");
                                break;

                            case "green":
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Black;

                                Console.WriteLine("Your color is green!");
                                break;

                            case "cyan":
                                Console.BackgroundColor = ConsoleColor.Cyan;
                                Console.ForegroundColor = ConsoleColor.Black;

                                Console.WriteLine("Your color is cyan!");
                                break;

                            default:
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("Your color is Yallow!");
                                break;

                        }
                        
            Console.WriteLine("Цикл while");
            int k = 0;

            while (k < 1)
            {
                Console.WriteLine(k);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                k++;
            }



            Console.WriteLine("Цикл do");
            int t = -1;

            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }


                t++;

            }
            while (t < 1);

            int l = 0;

            while (k < 1)
            {
                Console.WriteLine(k);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                k++;
            }

            int sum = 0;

            while (true)
            {
                Console.WriteLine("Введите число");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }

                // number > 0
                sum += number;
            }

            Console.WriteLine("Итоговая сумма: {0}", sum);
            Console.ReadKey();
            */
            string[] favcolors = new string[3];

            for(int p = 0; p < favcolors.Length; p++)
            {
                Console.WriteLine("Введите любимый цвет номер {0}", p + 1);
                favcolors[p] = Console.ReadLine();
            }

            foreach (var color in favcolors)

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            Console.ReadKey();
            
            

        }
    }
}

