using System;

namespace Ejercicio3._2._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, result;

            Console.WriteLine("Introduce un numero: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce un numero: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce un numero: ");
            z = Convert.ToDouble(Console.ReadLine());

            result = (x * x) + y - z;

            Console.WriteLine(x.ToString("0.00")+ "*" + x.ToString("0.00") + "+" + y.ToString("0.00") + "-" + z.ToString("0.00"));
            Console.WriteLine(result.ToString("0.000"));
            Console.WriteLine(2^2);
        }
    }
}
