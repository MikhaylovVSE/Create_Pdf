using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Вводим целое положительное К.
                Программа считает: 
                    Сумму чисел от 1 до К
                    Произведение чисел от 1 до К
                    Определяет, К - простое число или нет (делится без остатка только на 1 и на себя)
             */

            int sum = 0;
            int multiple = 1;

            while (true)
            {
                Console.Write("input number >");
                string input = Console.ReadLine();
                if (input == "q") {
                    break;
                }

                int k = Int32.Parse(input);

                for(int i=1; i <= k; i++)
                {
                    sum += i;
                    multiple *= i;
                }
            }
            Console.WriteLine($"Сумма = {sum}, Произведение = {multiple}");
            Console.ReadKey();
        }
    }
}