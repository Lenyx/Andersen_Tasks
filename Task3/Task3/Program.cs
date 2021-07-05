using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string str;
            bool check = true;

            Console.WriteLine("Задание 3.\nСоставить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3\n");

            while (check)
            {
                
                Console.WriteLine("Введите размер массива:");
                str = Console.ReadLine();
                
                if (Int32.TryParse(str, out n))
                {
                    if (n > 0)
                    {
                        Random rand = new Random();
                        int[] arr = new int[n];
                        Console.WriteLine("Отлично! Введите цифру одного из вариантов, представленных ниже:");
                        Console.WriteLine("1. Заполнить массив случайными числами.\n2. Заполнить массив вручную.\n3. Выход.");
                        while (check)
                        {
                            str = Console.ReadLine();
                            if (str == "1")
                            {
                                for (int i = 0; i < n; i++)
                                    arr[i] = rand.Next(-1000, 1000);
                                Console.WriteLine("Созданный массив:");
                                foreach (int i in arr)
                                    Console.Write($"{i} ");
                                Console.WriteLine("\nНиже выведены элементы этого массива кратные 3:");
                                foreach (int i in arr)
                                    if (i % 3 == 0)
                                        Console.Write($"{i} ");
                                Console.WriteLine("\n");
                                break;
                            }
                            else if (str == "2")
                            {
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine($"Введите [{i + 1}] элемент массива:");   
                                    while (true)
                                    {
                                        str = Console.ReadLine();
                                        if (Int32.TryParse(str, out arr[i]))
                                            break;
                                        else
                                            Console.WriteLine("Неккоректный ввод, введите целое число!");
                                    }
                                }
                                Console.WriteLine("Созданный массив:");
                                foreach (int i in arr)
                                    Console.Write($"{i} ");
                                Console.WriteLine("\nНиже выведены элементы этого массива кратные 3:");
                                foreach (int i in arr)
                                    if (i % 3 == 0)
                                        Console.Write($"{i} ");
                                Console.WriteLine("\n");
                                break;
                            }
                            else if (str == "3")
                            {
                                check = false;
                                break;
                            }
                            else
                                Console.WriteLine("Неккоректный ввод. Введите \"1\", \"2\" или \"3\".");

                        }
                        while (check)
                        {
                            Console.WriteLine("Если хотите продолжить введите \"1\", а чтобы выйти \"0\"");
                            str = Console.ReadLine();
                            if (str == "0")
                                check = false;
                            else if (str == "1")
                            {
                                check = true;
                                break;
                            }
                            else
                                Console.WriteLine("Некорректный ввод!");
                        }
                    }
                    else
                        Console.WriteLine("Размер массива не может быть меньше 1!");
                }
                else
                    Console.WriteLine("Вы ввели не целое число, попробуйте снова!");
            }

        }
    }
}
