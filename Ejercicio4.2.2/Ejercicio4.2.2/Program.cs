using System;

namespace Ejercicio4._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 2;
            int[,] numeros = new int[y,x];

            int[] usuario = new int[x];

            int[] coincidencias = new int[x];

            for(int i = 0; i < y; i++)
            {
                for(int a = 0; a < x; a++)
                {
                    Console.Write("Introduce un numero para la posicion " + (i + 1) + "," + (a + 1) + " ");
                    numeros[i,a] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0; i < x; i++)
            {
                Console.Write("Introduce un numero ");
                usuario[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < y; i++)
            {
                for (int a = 0; a < x; a++)
                {
                    for(int e = 0; e < x; e++)
                    {
                        if (usuario[e]==numeros[i,a])
                        {

                            coincidencias[e] = numeros[i,a];
                        }
                        
                    }
                }
            }
            Console.WriteLine("Estos son los numeros coincidentes ");
            for(int i = 0; i < x; i++)
            {
                Console.WriteLine(coincidencias[i]+" ");
            }
        }
    }
}
