using System;

namespace Ejercicio3._2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumen;
            float pi = 3.14f;
            Console.Write("Introduce el radio que deseas calcular: ");
            volumen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El volumen de "+volumen+" es de "+(pi *volumen* 4 / 3));
        }
    }
}
