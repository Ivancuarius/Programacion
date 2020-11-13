using System;

namespace Ejercicio4._1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int vez;
            double suma=0;
            Console.Write("Cuantos numeros quieres poner: ");
            vez = Convert.ToInt32(Console.ReadLine());
            double[] veces= new double[vez];

            for(int i = 0; i < vez; i++)
            {
                Console.Write("Introduce un numero: ");
                veces[i] = Convert.ToDouble(Console.ReadLine());
            }
            for(int a=0; a < vez; a++) 
            {
                suma += veces[a];
            }
            
            Console.WriteLine(suma/vez);
        }
    }
}
