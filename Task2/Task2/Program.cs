using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            while (true)
            {
                Console.WriteLine("Введите имя или \"выход\" для завершения работы.");
                name = Console.ReadLine();
                name = name.ToLower();
                if (name == "вячеслав")
                {
                    Console.WriteLine("Привет, Вячеслав!");
                }
                else if (name == "выход")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Нет такого имени, попробуйте ещё раз!");
                }
            }

        }
    }
}
