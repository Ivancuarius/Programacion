using System;

namespace Ejercicio3._2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio; 
            float pi = 3.14f; 
            Console.Write("Introduce el radio: "); 
            radio = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("La longitud de la circunferencia es "+(2 * pi * radio)); 
        }
    }
}
