using System;

namespace Education.Module_4
{
    class Program
    {
        static void Main()
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
            
            

            
            
                Console.WriteLine("Введите своё имя");

                var name = Console.ReadLine();

                Console.WriteLine("Ваше имя по буквам: ");

                foreach (var ch in name)
                {
                    Console.Write(ch + " ");
                }

                Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);

                Console.ReadKey();

            
            Console.WriteLine("Введите своё имя");

            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам в обратном порядке: ");

            for (int i =name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }

            
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            foreach (var item in array)

            {
                Console.Write(item + " ");
            }

            Console.Write("Количество строк:");
            Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            Console.Write("Количество колонок:");
            Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");
            

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

                int temp;

                for (int l = 0; l< arr.Length; l++)
                {
                    for (int j = l + 1; j < arr.Length; j++)
                    {
                        if (arr[l] > arr[j])

                        {
                            temp = arr[l];
                            arr[l] = arr[j];
                            arr[j] = temp; 
                        }         
                    }
                }
                foreach(var itemm in arr)
                {
                    Console.Write(itemm);
                }
            
            Console.WriteLine();
            

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            Console.WriteLine(sum);
            
            var anketa = (name: "Timur", age: 31);

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            Console.WriteLine("Ваше имя: {0}", anketa.Item1);
            Console.WriteLine("Ваш возраст: {0}", anketa.Item2);

            

            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.Item1 = Console.ReadLine();

            Console.Write("Введите возраст с цифрами: ");
            anketa.Item2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.Item1);
            Console.WriteLine("Ваш возраст: {0}", anketa.Item2);
            

            var (name, age) = ("Евгения", 27);
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            

            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            (string Name, int Age, string Type) Pet;
            

            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Введите имя питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;
            Console.Write("Введите тим питомца: ");
            Pet.Type = Console.ReadLine();

            Console.Write("Введите возраст питомца: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Длина имени питомца {0} ", Pet.NameCount);
           
             */

            (string Name, string LastName, string Login, int LoginCount,  bool HasPet, string[] favColors, double Age) User;

            for (int k = 0; k < 3; k++)

            
            {
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");

                User.Login = Console.ReadLine();

                User.LoginCount = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные ? Да или Нет");

                var otvet = Console.ReadLine();

                if (otvet == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Введите возраст пользователя");

                User.Age = Convert.ToDouble(Console.ReadLine());

                User.favColors = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i < User.favColors.Length; i++)
                {
                    User.favColors[i] = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}

