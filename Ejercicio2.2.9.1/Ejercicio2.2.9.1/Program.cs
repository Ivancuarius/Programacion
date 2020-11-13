using System;

namespace Ejercicio2._2._9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i;
            Console.Write("Introduce un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Los numeros multiplos de 9 son: ");
            for (num = num; num >= 1; num--)
            {
                if (num % 9 == 0) { Console.WriteLine(num); }
            }
        }
    }
}
