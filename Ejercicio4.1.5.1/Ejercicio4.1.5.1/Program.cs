using System;

namespace Ejercicio4._1._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pedido;
            const int MES =12;
            string[] meses = new string[MES] { "Enero", "Febreo", "Marzo", "Abril", "Mayo", "Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre" };

            Console.WriteLine("Introduce un número para hacer una de las siguientes cosas");
            Console.WriteLine("1º Que los meses esten en orden");
            Console.WriteLine("2º Que los meses esten al reves su orden");
            pedido = Convert.ToInt32(Console.ReadLine());

            switch (pedido)
            {
                case 1:
                    for (int i = 0; i < MES; i++)
                    {
                        Console.WriteLine(meses[i]);
                    }
                    ; break;
                case 2:
                    for (int a = MES-1; a > -1; a--)
                    {
                        Console.WriteLine(meses[a]);
                    }
                    ; break;



            }

        }
    }
}
