using System;

namespace Ejercicio3._2._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float c;

            Console.Write("Introduce un numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce un numero: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce un numero: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La x es " + ((-b + Math.Sqrt(b * b - 4 * a * c) / 2 * a))+ " y "+((-b - Math.Sqrt(b * b - 4 * a * c) / 2 * a)));
            
        }
    }
}
