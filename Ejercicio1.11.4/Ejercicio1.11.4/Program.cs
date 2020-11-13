using System;

namespace Ejercicio1._11._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int grados = 0;
            int kelvin = 0;
            int fahrenheit = 0;
            Console.Write("Introduce la cantidad de Celsius que quieres introducir ");
            grados = Convert.ToInt32(Console.ReadLine());
            kelvin = grados + 273;
            fahrenheit= grados*18 /10+32;
        }
    }
}
