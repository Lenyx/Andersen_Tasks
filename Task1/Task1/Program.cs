using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string str = "";

            Console.WriteLine("Задание 1.\nСоставить алгоритм: если введенное число больше 7, то вывести “Привет”\n");

            while (true)
            {
                Console.WriteLine("Введите любое число. (для выхода введите \"exit\")");
                str = Console.ReadLine();
                str = str.ToLower();
                if (Int32.TryParse(str, out number))
                {
                    if (number > 7)
                        Console.WriteLine("Привет");
                }
                else if (str == "exit")
                    break;
                else
                    Console.WriteLine("Некорректный ввод, попробуйте снова!");
            }  
        }
    }
}
