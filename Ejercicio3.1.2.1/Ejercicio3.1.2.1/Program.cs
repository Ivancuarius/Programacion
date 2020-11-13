using System;

namespace Ejercicio3._1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ejemplo1 = "0";
            Console.Write("Introduce su edad: ");
            ejemplo1 = Convert.ToString(Console.ReadLine());

            byte edad = Convert.ToByte(ejemplo1);
            Console.WriteLine("Pues no aparentas "+edad+" años");
        }
    }
}