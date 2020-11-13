using System;

namespace Ejercicio2._6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio;
            int pagado;
            int cambio;
            int billete = 100;
            Console.Write("Introduce lo que has comprado: ");
            precio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ahora lo que has pagado: ");
            pagado = Convert.ToInt32(Console.ReadLine());

            cambio = pagado - precio;

            if (cambio == 0)
            {
                Console.WriteLine("No te debe nada");

            }
            else 
                if(precio > pagado)
                {
                    Console.WriteLine("Lo siento el precio es mayor que tú le has pagado");
                
                }
                else
                {
                Console.Write("Su cambio es "+cambio+":");
                    while (cambio != 0)
                    {

                        if (cambio - billete < 0)
                        {
                            if (billete == 100)
                            {
                                billete = 50;
                                continue;   
                            }
                            else
                            if (billete == 50)
                            {
                                billete = 20;
                                continue;
                            }
                            if (billete == 20)
                            {
                                billete = 10;
                                continue;
                                
                            }
                            if (billete == 10)
                            {
                                billete = 5;
                                continue;
                            }
                            if (billete == 5)
                            {
                                billete = 2;
                                continue;
                            }
                            if (billete == 2)
                            {
                                billete = 1;
                                
                            }
                        }
                        Console.Write(billete + " ");
                        cambio = cambio - billete;
                    }
               
                }
           
        }
    }
}
