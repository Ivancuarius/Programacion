using System;

namespace Ejercicio2._2._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,num,result;
            num = 9;
            result = 0;
            for (i = 0; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine(i+" X "+num+" = "+result);
            }
        }
    }
}
