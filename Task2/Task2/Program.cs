using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Задание 2.\nСоставить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести \"Нет такого имени\"\n");

            while (true)
            {
                Console.WriteLine("Введите имя. (Для завершения работы введите \"выход\")");
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
