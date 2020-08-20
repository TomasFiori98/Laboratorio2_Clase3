using System;

namespace Clase3_Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int numero, aleatorio;
            int intentos=13;

            aleatorio = r.Next(1, 10001);

            Console.WriteLine("- - - - - - BIENVENIDO! - - - - - -");
            Console.WriteLine("Intenta adivinar el numero escondido!");
            Console.WriteLine("Tienes {0} intentos! Mucha suerte!!", aleatorio);

            do
            {
                Console.WriteLine("\nQue numero crees que sea?");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == aleatorio)
                    Console.WriteLine("\nCORRECTO! Has GANADO :D");
                else
                {
                    intentos -= 1;

                    Console.WriteLine("\nIncorrecto! Te quedan {0} intentos", intentos);
                    if (numero < aleatorio && intentos != 0)
                        Console.WriteLine("Te has quedado corto");
                    if (numero > aleatorio && intentos != 0)
                        Console.WriteLine("Te has pasado");

                    if (intentos == 0)
                    {
                        Console.WriteLine("Perdiste, te has quedado sin intentos :c");
                        Console.WriteLine("La solucion era --> {0}", aleatorio);
                    }

                }

            } while (numero != aleatorio && intentos!=0);

        }
    }
}
