using System;

namespace Ejercicio4._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max=0;
            int[] maximos = new int[2];

            Console.Write("Introduce cuantos bloques quieres para la primera fila ");
            int fila = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce cuantos bloques quieres para la segunda fila ");
            int fila2 = Convert.ToInt32(Console.ReadLine());

            int[][] numeros=new int[2][];
            numeros[0] = new int[fila];
            numeros[1] = new int[fila2];

            for(int i = 0; i < numeros.Length; i++)
            {
                for(int a = 0; a < numeros[i].Length; a++)
                {
                    Console.Write("Introduce un numero para la fila "+(i+1)+": ");
                    numeros[i][a] = Convert.ToInt32(Console.ReadLine());

                    if (max < numeros[i][a])
                    {
                        max = numeros[i][a];
                    }
                }
                maximos[i] = max;
                max = 0;
            }
            Console.WriteLine("La primera fila maximo es " + maximos[0]);
            Console.WriteLine("La segunda fila maximo es " + maximos[1]);
        }
    }
}
