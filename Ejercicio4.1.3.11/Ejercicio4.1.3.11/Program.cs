using System;

namespace Ejercicio4._1._3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int vez = 4;
            int max = Int32.MinValue;
            int[] numeros = new int[vez];
            for (int i = 0; i < vez; i++)
            {
                Console.WriteLine("Introduce un numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int e = 0; e < vez; e++)
            {
                if (max < numeros[e])
                {
                    max = numeros[e];
                }
                Console.WriteLine("------------------------");
                Console.WriteLine(numeros[e]);
            }
            Console.WriteLine("El mas mayor es el: "+max);
        }
    }
}
