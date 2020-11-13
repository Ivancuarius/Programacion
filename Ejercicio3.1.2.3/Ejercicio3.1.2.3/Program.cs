using System;

namespace Ejercicio3._1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = 0;
            long num2 = 0;
            Console.Write("Introduce un numero: ");
            num1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("Introduce otro numero: ");
            num2 = Convert.ToInt64(Console.ReadLine());

            long suma = num1 + num2;
            long resta = num1 - num2;
            long producto = num1 * num2;

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("El producto es: " + producto);

        }
    }
}
