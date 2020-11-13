using System;
using System.IO.Pipes;

namespace Ejercicio3._2._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1,i,n2=1,calc=0;
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
            Console.WriteLine(calc);
        }
    }
}
