using System;

namespace Ejercicio1._9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int div = 0;
            int res = 0;
            System.Console.Write("Introduce el primer numero ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Introduce el segundo numero ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            div = numero1 / numero2;
            res = numero1 % numero2;
            Console.WriteLine("{0} entre {1} da {2} y su resto es {3}",numero1,numero2,div,res);
        }
    }
}
