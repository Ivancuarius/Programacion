using System;

namespace Ejercicio1._9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            int suma = 0;
            Console.Write("Pon el primer numero ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pon el segundo numero ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pon el tercer numero ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            suma = numero1 + numero2 + numero3;
            Console.WriteLine("El resultado de {0}",suma);
        }
    }
}
