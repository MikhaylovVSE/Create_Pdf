using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("input number >");
                string input = Console.ReadLine();
                if (input == "q") {
                    break;
                }

                int number = Int32.Parse(input);
                for(int i = 0; i < number ; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            } 
        }
    }
}
