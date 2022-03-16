using System;

namespace Education.Module_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя");

            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам в обратном порядке: ");

            for (int ch = name.Length - 1; ch >= 0; ch--)
            {
                Console.Write(name[ch] + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", name[0]);

            
                var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

                int temp;

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }

                foreach (var item in arr)
                {
                    Console.Write(item);
                }

                Console.ReadKey();
        }
    }
}
 