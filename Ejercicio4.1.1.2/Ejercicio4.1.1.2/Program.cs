using System;

namespace Ejercicio4._1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float [5];
            Console.Write("Introduce el primer numero: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo numero: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el tercero numero: ");
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el cuarto numero: ");
            numeros[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el quinto numero: ");
            numeros[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numeros[4] + " " + numeros[3] + " " + numeros[2] + " " + numeros[1] + " " + numeros[0]);
        }
    }
}
