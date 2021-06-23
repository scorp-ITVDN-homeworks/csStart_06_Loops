using System;
using System.Threading;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Input the quantity of customers");
                int customersQuantity = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < 20; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(100);
                }
                Console.WriteLine();

                Console.WriteLine($"Total number of routs = {GetFactorial(customersQuantity)}");
                Console.WriteLine(new string('.', 20));

                Console.WriteLine("Do another calculation? (y/n)");
                if (Console.ReadLine() != "y") break;
            }
            while (true);     

        }

        static int GetFactorial(int number)
        {
            int factorial = number;
            do
            {
                factorial = factorial * (number - 1);
                number--;
            }
            while (number > 1);
            return factorial;
        }
    }
}
