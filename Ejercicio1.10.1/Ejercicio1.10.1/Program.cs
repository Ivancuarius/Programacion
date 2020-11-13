using System;
//Este apartado sirve para sumar 2 numero que el usuario quiere poner
namespace Ejercicio1._10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int producto = 0;
            System.Console.Write("Introduce el primer número ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Introduce el segundo número ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            producto = numero1 * numero2;
            Console.WriteLine(producto);
        }
    }
}