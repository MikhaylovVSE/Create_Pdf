using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Tasks
    {
        public static void Sum()
        {
            /*
                Вводим целое положительное К.
                Программа считает: 
                    1. Сумму чисел от 1 до К
                    2. Произведение чисел от 1 до К
            */


            int sum = 0;
            int multiple = 1;

            while (true)
            {
                Console.Write("input number >");
                string input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }

                int k = Int32.Parse(input);

                for (int i = 1; i <= k; i++)
                {
                    sum += i;
                    multiple *= i;
                }
            }
            Console.WriteLine($"Сумма = {sum}, Произведение = {multiple}");
            Console.ReadKey();
        }
        public static void IsSimpleNumber()
        {
            /*
               Вводим целое положительное К.
               Программа определяет, К - простое число или нет,
               то есть делится ли К без остатка только на 1 и на себя
            */

            while (true)
            {
                Console.Write("Введите любое число >");
                string input = Console.ReadLine();

                int K = Int32.Parse(input);
                int count = 0;
                for (int i = 1; i <= K; i++)
                {
                    if (K % i == 0)
                        count++;
                }

                if (count == 2)
                    Console.WriteLine($"Число {K} - простое");
                else
                    Console.WriteLine($"Число {K} - не простое");

                if (Console.ReadLine() == "q") break;
            }

        }
    }
}
