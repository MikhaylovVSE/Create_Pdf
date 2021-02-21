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

            int amount = 0;
            int max = 0;

            while (true)
            {
                Console.Write("input number >");
                string input = Console.ReadLine();
                if (input == "q") {
                    break;
                }

                int number = Int32.Parse(input);
                amount += number;
                if (max < number) {
                    max = number;
                }


                //вывод
            }

            Console.WriteLine($"Amount = {amount}, Max number = {max}");
            Console.ReadKey();

        }
    }
}