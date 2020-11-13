using System;

namespace Ejercicio4._1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros= new int[6];
            for(int i = 0; i != 6; i++)
            {
                Console.Write("Introduce un numero: ");
                numeros[i] = (Convert.ToInt32(Console.ReadLine()));
            }

            for(int a = 5; a > -1; a--)
            {
                Console.WriteLine(numeros[a]);
            }
            
        }
    }
}
