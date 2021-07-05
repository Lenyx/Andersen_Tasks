using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            while (number != 000)
            {
                Console.WriteLine("Введите любое число или число 000 для выхода:");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы ввели не число, попробуйте снова!");
                }
                finally
                {
                    if (number > 7)
                    {
                        Console.WriteLine("Привет!");
                    }
                }
            }  
        }
    }
}
