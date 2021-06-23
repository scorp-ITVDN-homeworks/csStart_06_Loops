using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowTriangle();
            Console.WriteLine();
            ShowEqualSidesTriangle();
            Console.WriteLine();
            ShowHexagon();
            Console.WriteLine();
            ShowRhombus();
            Console.ReadKey();
        }

        static void ShowTriangle()
        {
            for (int i = 0; i <= 8; i++)
            {
                Console.Write(new string(' ', 8 - i + 1));
                Console.Write(new string('*', i + 1));
                Console.Write("\n");
            }
        }

        static void ShowEqualSidesTriangle()
        {
            for (int i = 0; i <= 8; i++)
            {
                Console.Write(new string(' ', (15 / 2 - i + 1)));
                Console.Write(new string('*', 1 + i * 2));
                Console.Write("\n");
            }
        }

        static void ShowHexagon()
        {
            int voidPlace = 5;
            int fullPlace = 0;
            for (int i = 0; i < 7; i++)
            {
                if (i < 4)
                {
                    voidPlace -= 1;
                    Console.Write(new string(' ', voidPlace));
                    Console.Write(new string('*', fullPlace + 8));
                    fullPlace += 2;
                }

                if (i == 4) fullPlace -= 4;

                if (i > 3)
                {
                    voidPlace += 1;
                    Console.Write(new string(' ', voidPlace));
                    Console.Write(new string('*', fullPlace + 8));
                    fullPlace -= 2;
                }
                Console.Write("\n");
            }
        }

        static void ShowRhombus()
        {
            for (int i = 0; i <= 8; i++)
            {
                Console.Write(new string(' ', (15 / 2 - i + 1)));
                Console.Write(new string('*', 1 + i * 2));
                Console.Write("\n");
            }

            for (int i = 0; i <= 7; i++)
            {
                Console.Write(new string(' ', i + 1));
                Console.Write(new string('*', 17 - (i + 1) * 2));
                Console.Write("\n");
            }
        }
    }
}
