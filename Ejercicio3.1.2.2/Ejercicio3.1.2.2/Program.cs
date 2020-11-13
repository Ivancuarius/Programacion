using System;

namespace Ejercicio3._1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1 = 0;
            byte num2 = 0;
            Console.Write("Introduce un numero: ");
            num1 = Convert.ToByte(Console.ReadLine());
            Console.Write("Introduce otro numero: ");
            num2 = Convert.ToByte(Console.ReadLine());

            int res = 0;
            res = num1 * num2;

            ushort res1 = Convert.ToUInt16(res);

            Console.WriteLine(res1);
        }
    }
}
