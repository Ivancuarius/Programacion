using System;

namespace Ejercicio2._6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int a;
            int num=0;
            int num2 = 1;
            Console.Write("Introduce un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 9)
            {
                Console.Write("Lo siento es superior de 9 porfavor vuele a intentarlo.");
            }
            else
            for (i = num; i > 0; i--)
            {
                for (a = num; a > 0; a--)
                {
                    Console.Write(num2);
                }
                Console.WriteLine();
                num2 = num2 + 1;
            }
        }
    }
}
