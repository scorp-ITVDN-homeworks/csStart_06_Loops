using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Показать сумму чисел между заданными числами");
                Console.WriteLine("2 - Показать все нечётные числа между заданными числами");
                Console.WriteLine("3 - Показать факториал заданного числа");
                int viewSettings = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Введите число:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                int secondNumber = 0;

                int lessNumber = 0;
                int greaterNumber = 0;

                if(viewSettings < 3)
                {
                    Console.WriteLine("Введите второе число:");
                    secondNumber = Convert.ToInt32(Console.ReadLine());

                    lessNumber = firstNumber <= secondNumber ? firstNumber : secondNumber;
                    greaterNumber = secondNumber >= firstNumber ? secondNumber : firstNumber;

                    //TODO Проверка на равенство чисел
                    //TODO Проверка на минимальный, равный единице, промежуток между числами
                }


                int sum = 0;
                if (viewSettings == 1)
                {
                    for (int i = lessNumber + 1; i < greaterNumber; i++)
                    {
                        sum += i;
                    }

                    Console.WriteLine($"Сумма всех чисел между {firstNumber} и {secondNumber} равна {sum}");
                }


                if (viewSettings == 2)
                {
                    Console.WriteLine(new string('*', 50));
                    for (int i = lessNumber + 1; i < greaterNumber; i++)
                    {
                        if ((i & 1) == 1)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine(new string('*', 50));
                }

                if(viewSettings == 3)
                {
                    int fac = 1;
                    //for (int i = 1; i < firstNumber; i++)
                    //{
                    //    fac *= i + 1;
                    //}

                    fac = GetFactorial(firstNumber);
                    Console.WriteLine($"Факториал числа {firstNumber} равен {fac}");
                }

                Console.WriteLine("Продолжить? (да/нет)");
                bool doOperations = Console.ReadLine() == "да" ? true : false;
                if (!doOperations) break;
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
