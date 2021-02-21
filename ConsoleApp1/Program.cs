using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                Console.Write("input number >");
                string input = Console.ReadLine();
                if (input == "q") {
                    break;
                }

                int number = Int32.Parse(input);
                if (number > 5)
                {
                    count++;
                }
            }

            Console.WriteLine($"Count = {count}, count * count = {count * count}");

        }
    }
}