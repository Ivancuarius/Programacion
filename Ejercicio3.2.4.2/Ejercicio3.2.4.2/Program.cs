using System;

namespace Ejercicio3._2._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, i, n2 = 1, calc = 0;
            Console.WriteLine("Intoduce un numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            for (i = 1; i <= n1; i++)
            {
                if (n2 % 2 == 0)
                {
                    calc = calc - (1 / n2);
                }
                else
                {
                    calc = calc + (1 / n2);
                }
                n2++;
            }

            float calcresult = (float)calc;
            Console.WriteLine(calcresult);
        }
    }
}
