using System;

namespace Ejercicio1._9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int millas = 0;
            int metros = 1852;
            int res = 0;
            Console.Write("Introduce la cantidad de millas ");
            millas = Convert.ToInt32(Console.ReadLine());
            res = millas * metros;
            Console.WriteLine("{0} millas es equivalente a {1} metros", millas, res);
        }
    }
}
