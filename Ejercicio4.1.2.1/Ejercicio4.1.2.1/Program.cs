using System;

namespace Ejercicio4._1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meses = new int[13]{0,31,28,31,30,31,30,31,31,30,31,30,31};
            int result;
            Console.Write("Introduce un numero del mes: ");
            result = Convert.ToInt32(Console.ReadLine());

            result = meses[result];

            Console.WriteLine("Tiene " + result+" dias.");

            

        }
    }
}
