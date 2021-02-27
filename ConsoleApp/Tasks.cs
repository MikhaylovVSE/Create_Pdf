using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Tasks
    {

        class Engine
        {
            private int sum;
            private int multiple;
            public Engine(int k)
            {
                sum = 0;
                multiple = 1;
                for (int i = 1; i <= k; i++)
                {
                    sum += i;
                    multiple *= i;
                }
            }
            public int getSum() { return sum; }
            public int getMult() { return multiple;  }

            //"Авто-свойства"
            //public int Sum { get; set; }
            //public int Mult { get; set; }
        }

        public static void Sum()
        {
            /*
                Вводим целое положительное К.
                Программа считает: 
                    1. Сумму чисел от 1 до К
                    2. Произведение чисел от 1 до К
            */

            
            while (true)
            {
                Console.Write("input number >");
                string input = Console.ReadLine();
                if (input == "q") {
                    break;
                }

                var k = int.Parse(input);
                var engine = new Engine(k);
                Console.WriteLine($"Сумма = {engine.getSum()}, Произведение = {engine.getMult()}");
            }
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
