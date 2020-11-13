using System;

namespace Ejercicio4._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 2];

            for(int i = 0; i < 2; i++)
            {
                for(int a = 0; a < 2; a++)
                {
                    Console.Write("Introduce un numero para la posicion " + (i + 1) +", "+(a+1)+ " ");
                    numeros[i, a] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0; i < 2; i++)
            {
                for(int a = 0; a < 2; a++)
                {
                    Console.Write(numeros[i, a]+" ");
                }
                Console.WriteLine(" ");
            }

            int matriz = (numeros[0, 0] * numeros[1, 1]) - (numeros[0, 1] * numeros[1, 0]);
            Console.WriteLine("El determinante de una matriz de 2X2 es de " + matriz);
        }
    }
}
