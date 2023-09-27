using System;
using System.Reflection.Metadata.Ecma335;

namespace _3_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string act;

            do
            {
                Console.WriteLine("Выберите программу, которую вы хотите запустить:");
                Console.WriteLine("1. Игра 'Угадай число'.");
                Console.WriteLine("2. Таблица умножения.");
                Console.WriteLine("3. Вывод делителей числа.");
                Console.WriteLine("4. Закрыть программу.");
                act = Console.ReadLine();
                switch (act)
                {
                    case "1":
                        {
                            Guess_The_Number();
                            break;
                        }
                    case "2":
                        {
                            Multiply_Table(); 
                            break;
                        }
                    case "3":
                        {
                            Divisors(); 
                            break;
                        }
                    case "4":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такой программы нет.");
                            break;
                        }
                }
            } while (act != "4");
        }
        static void Guess_The_Number()
        {
            Random rnd = new Random();
            int scrt = rnd.Next(100) + 1;
            int mynum;
            string txt;
            Console.WriteLine("Загадано число от 1 до 100. Попробуйте его отгадать. У вас 10 попыток.");
            for (int i = 10; i > 0; i--)
            {
                Console.Write("Попыток осталось: " + i + ". Введите число:");
                txt = Console.ReadLine();
                if (!int.TryParse(txt, out mynum))
                {
                    i++;
                    continue;
                }
                if (mynum == scrt)
                {
                    Console.WriteLine("Йее! Вы угадали число.");
                    Console.WriteLine();
                    return;
                }
                else if (mynum > scrt)
                {
                    Console.WriteLine("Эх... Вы не угадали. Введите число поменьше.");
                }
                else if (mynum < scrt)
                {
                    Console.WriteLine("Эх... Вы не угадали. Введите число побольше.");
                }
            }
            Console.WriteLine("Попытки закончились. Было загадано число "+ scrt + ".");
            Console.WriteLine();
        }
        static void Multiply_Table()
        {
            int[,] table = new int[11, 11];

            for (int a = 1; a < table.GetLength(0); a++)
            {
                for (int b = 1; b < table.GetLength(1); b++)
                {
                    table[a, b] = a * b;
                }
            }
            Console.WriteLine();

            for (int y = 1; y < table.GetLength(0); y++) 
            {
                for (int x = 1; x < table.GetLength(1); x++)
                {
                    Console.Write(table[y, x] + "\t" );
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Divisors()
        {
            int number;
            try
            {
                Console.WriteLine("Введите положительное число:");
                number = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.Write(i + "\t");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите 'y', чтобы продолжить. В ином случае нажмите любую другую клавиатуру.");
                string proceed = Console.ReadLine();
                while (proceed == "y")
                {
                    Console.WriteLine("Введите положительное число:");
                    number = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            Console.Write(i + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Это не число.");
            }
            Console.WriteLine();
        }
        
    }
}