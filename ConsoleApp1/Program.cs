using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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
                if (max < number)
                    max = number;
            }

            Console.WriteLine($"Amount = {amount}, Max number = {max}");
            Console.ReadKey();

        }
    }
}