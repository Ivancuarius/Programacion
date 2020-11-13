using System;

namespace Ejercicio1._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int metros = 3000;
            int millas = 1609;
            //Numeros guardados y recogidos
            int calc = metros * millas; //Como se que un metro es 1609 pues lo multiplicare

            //Y aqui lo enseño el resultado
            Console.WriteLine("{0} metros equivale a {1} millas",metros, calc);
        }
    }
}
