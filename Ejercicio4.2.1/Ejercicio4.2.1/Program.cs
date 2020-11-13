using System;

namespace Ejercicio4._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 2;
            int[,] numeros = new int[y, x];
            int numero = 0;
            int[] maximos = new int[2];
            int max = 0;
            for(int i = 0; i < y; i++)
            {
                for(int a=0; a < x; a++)
                {
                    Console.Write("Introduce un numero para que este en la posicion " + (i + 1) + "," + (a + 1)+" ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    numeros[i, a] = numero;

                    if (max < numero)
                    {
                        max = numero;
                    }
                }
                maximos[i] = max;
            }
            for(int i = 0; i < y; i++)
            {
                for(int a=0; a < x; a++)
                {
                    Console.Write(numeros[i, a]+" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("La primera fila maximo es " + maximos[0]);
            Console.WriteLine("La segunda fila maximo es " + maximos[1]);
        }
    }
}
