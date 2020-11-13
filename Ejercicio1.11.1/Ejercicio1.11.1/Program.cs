using System;

namespace Ejercicio1._11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int res1 = 0;
            int res2 = 0;
            Console.Write("Introduce el primer numero ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo numero ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            res1 = (numero1 + numero2) * (numero1 - numero2);
            res2 = (numero1 * numero1) - (numero2 * numero2);
            Console.Write("(a+b)*(a-b) da " + res1);
            Console.Write(" y a2-b2 da " + res2);
        }
    }
}
