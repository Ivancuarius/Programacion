using System;

namespace Ejercicio3._2._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1,numero2,result;

            Console.Write("Introduce un numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce un numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            result = numero1 / numero2;

            Console.WriteLine(result.ToString("0.000"));
        }
    }
}
