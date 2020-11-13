using System;

namespace Ejercicio3._2._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;

            Console.WriteLine("Escribe un nuero");
            y = Convert.ToDouble(Console.ReadLine());

            for(double x = 1; x < 10; x++)
            {
                y = (x - 5) * (x - 5);

                for(double a = 0; a <= y; a++)
                {
                    if (a == y)
                    {
                        Console.Write("*");
                    }
                    else
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
}
