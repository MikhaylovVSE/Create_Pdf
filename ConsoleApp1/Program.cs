using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                напечатать квалрат из звездочек заданного размера
             */

            while (true)
            {
                Console.Write("input number >");
                string input = Console.ReadLine();
                if (input == "q") {
                    break;
                }

                int number = Int32.Parse(input);
                for(int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");

            } 
        }
    }
}
