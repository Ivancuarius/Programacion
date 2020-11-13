using System;

namespace Ejercicio4._2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[3, 4];
            int[] reserva = new int[4];

            for (int i = 0; i < 3; i++)
            {
                for(int a = 0; a < 4; a++)
                {
                    Console.Write("Introduce un numero para la posicion " + (i + 1) + "," + (a + 1) + ": ");
                    numeros[i, a] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("----------------------------------------------");
            }
            if (numeros[1, 0] < numeros[0, 0]&& numeros[1,0]< numeros[2, 0])//Cambiar la posicion
            {
                reserva[0] = numeros[0, 0];
                reserva[1] = numeros[0, 1];
                reserva[2] = numeros[0, 2];
                reserva[3] = numeros[0, 3];

                numeros[0, 0] = numeros[1, 0];
                numeros[0, 1] = numeros[1, 1];
                numeros[0, 2] = numeros[1, 2];
                numeros[0, 3] = numeros[1, 3];

                numeros[1,0]= reserva[0];
                numeros[1,1]= reserva[1];
                numeros[1,2]= reserva[2];
                numeros[1,3]= reserva[3];

               
            }
            else
            {
                if(numeros[2, 0] < numeros[0, 0] && numeros[2, 0] < numeros[1, 0])
                {
                    reserva[0] = numeros[0, 0];
                    reserva[1] = numeros[0, 1];
                    reserva[2] = numeros[0, 2];
                    reserva[3] = numeros[0, 3];

                    numeros[0, 0] = numeros[2, 0];
                    numeros[0, 1] = numeros[2, 1];
                    numeros[0, 2] = numeros[2, 2];
                    numeros[0, 3] = numeros[2, 3];

                    numeros[2, 0] = reserva[0];
                    numeros[2, 1] = reserva[1];
                    numeros[2, 2] = reserva[2];
                    numeros[2, 3] = reserva[3];

                    
                }   
            }
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.Write(numeros[i, a] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < 4; i++)//Para que la reserva tenga 0 por si acaso lo necesitamos para otro moneto
            {
                reserva[i] = 0;
            }

            for(int i = 0; i < 4; i++)
            {
                reserva[i] = (numeros[1, i]*numeros[0,0]) + (-(numeros[1,0]) * numeros[0, i]);
                
            }
            numeros[1, 0] = reserva[0];
            numeros[1, 1] = reserva[1];
            numeros[1, 2] = reserva[2];
            numeros[1, 3] = reserva[3];
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.Write(numeros[i, a] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < 4; i++)
            {
                reserva[i] = (numeros[2, i]* numeros[0, 0]) + (-(numeros[2, 0]) * numeros[0, i]);

            }
            numeros[2, 0] = reserva[0];
            numeros[2, 1] = reserva[1];
            numeros[2, 2] = reserva[2];
            numeros[2, 3] = reserva[3];
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.Write(numeros[i, a] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < 4; i++)//Para que la reserva tenga 0 por si acaso lo necesitamos para otro moneto
            {
                reserva[i] = 0;
            }
            int[] reserva1 = new int[4];//Esta variable es para reservar algun numero
            reserva1[0] = numeros[1, 1];
            reserva1[1] = numeros[2, 1];
            for (int i = 0; i < 4; i++)
            {
                reserva[i] = (numeros[1, i] * -numeros[2, 1]) - (numeros[2, i] * -numeros[1, 1]);
            }
            numeros[2, 0] = reserva[0];
            numeros[2, 1] = reserva[1];
            numeros[2, 2] = reserva[2];
            numeros[2, 3] = reserva[3];

            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.Write(numeros[i, a] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("----------------------------------------------");

            double x, y, z;
            z = numeros[2, 3] / numeros[2, 2];
            y = (numeros[1, 3] - numeros[1, 2] * z)/numeros[1, 1];
            x = ((-numeros[0, 1] * y) + (-numeros[0, 2] * z) + (numeros[0, 3])) / numeros[0,0];

            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.WriteLine("Z: " + z);

        }
    }
}
