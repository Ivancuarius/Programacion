using System;

namespace Ejercicio4._1._3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int vez = 2;
            double[] numeros = new double[vez];
            for (int i = 0; i < vez; i++)
            {
                Console.Write("Introduce un numero: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
            double resuelve = 1;
            double resultadototal = 0;
            for (int a = 1; a < 4; a++)
            {
                for (int e = 0; e < vez; e++)
                {
                    resuelve = resuelve * numeros[e] * a;
                }

                resultadototal += resuelve;
                resuelve = 1;
            }
            Console.WriteLine(resultadototal);
        }
    }
}
