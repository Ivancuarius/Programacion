using System;

namespace Ejercicio4._1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int vez = 10;
            double max = 0;
            double[] numeros = new double[vez];
            for(int i = 0; i < vez; i++)
            {
                Console.WriteLine("Introduce un numero: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
            double suma = 0;
            for(int a = 0; a < vez; a++)
            {
                suma += numeros[a];
            }
            Console.WriteLine("La media es de "+suma / vez);

            for(int e = 0; e < vez; e++)
            {
                if (max < numeros[e])
                {
                    max = numeros[e];
                }
            }
            max /= 2;
            for(int o = 0; o < vez; o++)
            {
                if (max <= numeros[o])
                {
                    Console.WriteLine(numeros[o]);
                }
            }
           
        }
    }
}
