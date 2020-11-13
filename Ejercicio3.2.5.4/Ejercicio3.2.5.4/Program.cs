using System;

namespace Ejercicio3._2._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio, superficie, volumen;
            float pi = (float)3.141592654;
            Console.Write("Introduce el radio de su circulo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            superficie = 4 * pi * Math.Pow(radio, 2);
            volumen = 4 / 3 * pi * Math.Pow(radio, 3);

            Console.WriteLine("La superficie es de "+superficie.ToString("0.00000"));
            Console.WriteLine("El volumen es de "+volumen.ToString("0.00000"));
        }
    }
}
