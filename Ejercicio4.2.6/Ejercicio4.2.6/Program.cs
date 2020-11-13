using System;

namespace Ejercicio4._2._6
{
    class Program
    {
        static void Main(string[] args)
        { 
            double[,] numeros = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.Write("Introduce un numero para la posicion " + (i + 1) + "," + (a + 1) + ": ");
                    numeros[i, a] = Convert.ToDouble(Console.ReadLine());
                }
            }
            if((numeros[0,0]+ numeros[0, 1]+ numeros[0, 2])+ (numeros[2, 0] + numeros[2, 1] + numeros[2, 2])== (numeros[1, 0] + numeros[1, 1] + numeros[1, 2]))
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int a = 0; a < 3; a++)
                    {
                        Console.Write(numeros[i, a] + " ");
                    }
                    Console.WriteLine(" ");
                }
                double matriz = ((numeros[0, 0] * numeros[1, 1] * numeros[2, 2])
                    + (numeros[1, 0] * numeros[2, 1] * numeros[0, 2])
                    + (numeros[2, 0] * numeros[0, 1] * numeros[1, 2]))
                    - ((numeros[0, 2] * numeros[1, 1] * numeros[2, 0])
                    + (numeros[1, 2] * numeros[2, 1] * numeros[0, 0])
                    + (numeros[2, 2] * numeros[0, 1] * numeros[1, 0]));

                Console.WriteLine("El determinante de una matriz de 3X3 es de " + matriz);
                Console.WriteLine("A por cierto, es una matriz que son linealmente dependientes");
            }
            else
            {
                Console.WriteLine("Lo siento no se puede calcular ya que no es una matriz que son linealmente dependientes");
            }
            
        }
    }
}
