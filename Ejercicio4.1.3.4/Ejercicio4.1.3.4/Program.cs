using System;

namespace Ejercicio4._1._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meses = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes;
            int suma=0;
            Console.Write("Introduce un mes del 1 al 12: ");
            mes = Convert.ToInt32(Console.ReadLine());
            mes--;
            int dia;
            Console.Write("Introduce un dia del 1 al 31: ");
            dia = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < mes; i++)
            {
                suma += meses[i];
            }
            suma += dia;

            Console.WriteLine("Es el dia " + suma);
        }
    }
}
