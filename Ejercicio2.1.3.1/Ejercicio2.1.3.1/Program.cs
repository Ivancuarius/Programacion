using System;

namespace Ejercicio2._1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int result = 0;
            Console.Write("Introduce un numero ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            if (numero1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            }
            else{
                Console.Write("Introduce otro numero ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                if (numero2 == 0)
                {
                    Console.WriteLine("El producto de 0 por cualquier número es 0");
                }
                else {
                    result = numero1 * numero2;
                    Console.WriteLine(numero1+" X "+numero2+" = "+result);
                }
            }
        }
    }
}
