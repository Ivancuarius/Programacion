using System;

namespace Ejercicio4._1._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int vez = 3;
            double[] numeros = new double[vez];
            for(int i = 0; i < vez; i++) 
            {
                Console.Write("Introduce un numero: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
            double resuelto = 0;
            for (int a = 0; a < vez; a++)
            {
                resuelto += Math.Pow(numeros[a],2);
            }
            resuelto =Math.Sqrt(resuelto);
            Console.WriteLine("Eso da " + resuelto);

        }
        
    }
}
