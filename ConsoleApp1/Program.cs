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

            while (true)
            {
              
                Console.Write("input делимое >");
                string input = Console.ReadLine();
                Console.Write("input делитель >");
                string input2 = Console.ReadLine();

                int K = Int32.Parse(input);
                int Divider = Int32.Parse(input2);

                if (K % Divider == 0 && K / 1 != 0)
                    Console.WriteLine("К-простое число");
                else
                    Console.WriteLine("К-вещественное число");

                if (Console.ReadLine() == "q") break;
            }
        }
    }
}