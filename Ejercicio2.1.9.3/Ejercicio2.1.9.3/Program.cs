using System;

namespace Ejercicio2._1._9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.Write("Introduce una letra o un numero: ");
            a = Convert.ToChar(Console.ReadLine());
            switch (a)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':Console.WriteLine("Es una vocal");break;

                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':Console.WriteLine("Es un numero");break;

                default:Console.WriteLine("Es una constante (O que has puesto otra cosa en ese caso muy mal)"); break;


            }
        }
    }
}
