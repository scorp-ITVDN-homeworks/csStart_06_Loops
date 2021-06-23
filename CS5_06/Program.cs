using System;

namespace CS5_06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doRectangle = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Задайте ширину прямоугольника:");
                int width = (int)(Convert.ToInt32(Console.ReadLine()) * 1.8);
                Console.WriteLine("Задайте высоту прямоугольника:");
                int height = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < height; i++)
                {
                    bool isEdgeRow = (i != 0 && i != height - 1);
                    if (isEdgeRow)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (j == 0 || j == width - 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    if (!isEdgeRow)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write("*");
                        }
                    }

                    Console.Write("\n");
                }

                Console.WriteLine("Продолжить? (да/нет)");

                doRectangle = Console.ReadLine() == "да" ? true : false;
            }
            while (doRectangle);
            

            Console.ReadKey();
        }
    }
}
