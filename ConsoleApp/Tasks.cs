using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Tasks
    {

        class SumContainer
        {
            private int sum;
            private int multiple;
            public SumContainer(int k)
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
                var engine = new SumContainer(k);
                Console.WriteLine($"Сумма = {engine.getSum()}, Произведение = {engine.getMult()}");
            }
        }
        
        public static void IsSimple_1()
        {
            /*
               Вводим целое положительное К.
               Программа определяет, К - простое число или нет,
               то есть делится ли К без остатка только на 1 и на себя
            */

            while (true)
            {
                Console.Write("Введите любое число >");
                var input = Console.ReadLine();
                if (input == "q") {
                    break;
                }

                //todo: вынести в отдельный класс
                int K = int.Parse(input);
                bool isSimple = true;
                for (int i = 2; i <= K / 2 + 1; i++)
                {
                    if (K % i == 0)
                    {
                        isSimple = false;
                        break;
                    }
                }
                if (isSimple) Console.WriteLine($"Число {K} - простое");
                else Console.WriteLine($"Число {K} - не простое");
            }
         
        }

        public static void IsSimple_2()
        {
            /*
             *      todo:
                    Задача: разбить число на множители
                   
                    Пример 1: 
                        вводим 12
                        программа печатает: "12 = 2 * 2 * 3"
                    
                    Пример 2: 
                        вводим 11
                        программа печатает: "11 - простое число"
                    
                */
        }
    }
}
