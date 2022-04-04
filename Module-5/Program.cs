using System;

namespace Module_5
{
    class Program
    {
        /*
        static void Main()
        {
            
            (string Name, string[] Dishes) User;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];

           

            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine("Введите любимое блюдо {0}", i+1);
                User.Dishes[i] = Console.ReadLine();
            }
            


            Console.ReadKey();

            

        }
        
        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

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
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        public static void Main(string[] args)
        {
            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }

            Console.WriteLine("Ваши любимые цвета: ");

            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        
        public static void Main(string[] args)
        {
            GetArrayFromConsole();
        }


        
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
            }

            
        
        
          int temp = 0;

            for (int i = 0; i < result.Length; i++)

                for (int j = i + 1; j < result.Length; j++)

                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            return result;
       }
        

        static string ShowColor(string username, int userage)
            
        {
            Console.WriteLine("{0}, {1} лет \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
            var color = Console.ReadLine();

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
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

         static void Main()
        {

            var (name, age) = ("Евгения", 27);
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);



            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }
        }
        static void ShowColor(string[] favcolors)
        {
                Console.WriteLine("Ваши любимые цвета: ");

                foreach (var color in favcolors)
                {
                    Console.WriteLine(color);
                }
        }
        */



        public static void Main(string[] args)
        {
            GetArrayFromConsole();
        }

        static int[] GetArrayFromConsole()
       
            {
                var result = new int[5];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                return result;
            }

        static int[] SortArray(int[] result)
        {


                    int temp = 0;

                    for (int i = 0; i < result.Length; i++)

                        for (int j = i + 1; j < result.Length; j++)

                            if (result[i] > result[j])
                            {
                                temp = result[i];
                                result[i] = result[j];
                                result[j] = temp;
                            }
                    return result;
        }
            
        

    }
}