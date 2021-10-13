/*
 4. Un número perfecto es un entero positivo, que es igual a la suma de 
todos los enteros positivos (excluido el mismo) que son divisores del número. 
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. 
Escribir una aplicación que encuentre los 4 primeros números perfectos. 
Nota: Utilizar estructuras repetitivas y selectivas. 
 */

using System;

namespace Ejercicio4
{
    class Ejercicio04
    {
        static void Main(string[] args)
        {
            int acum = 0;
            int cont = 0;
            int numero = 1;
            int numeroPerfecto;

            Console.WriteLine("Los primeros cuatro numeros perfectos son: ");
            do
            {
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        acum += i;
                    }
                }
                    if (acum == numero)
                    {
                        cont++;
                        numeroPerfecto = numero;
                        Console.WriteLine("{0} ", numeroPerfecto);
                    }

                numero++;
                acum = 0;

            } while (cont < 4);

            System.Console.ReadKey();
        }
    }
}
