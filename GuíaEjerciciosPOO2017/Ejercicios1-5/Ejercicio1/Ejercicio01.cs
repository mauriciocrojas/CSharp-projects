/*
1. Ingresar 5 números por consola, guardándolos en una variable escalar. 
Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
*/

using System;

namespace Exercises
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acum=0;
            int prom;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;

            Console.Title = "Ejercicio Nro 1";

            for(int i=0; i<5; i++)
                {
                Console.WriteLine("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numeroIngresado);
                acum += numeroIngresado;

                if (numeroIngresado > maximo)
                {
                    maximo = numeroIngresado;
                }
                if (numeroIngresado < minimo)
                {
                    minimo = numeroIngresado;

                }
            }

            prom = acum / 5;

            Console.WriteLine("La suma de todos los numeros: {0}", acum);
            Console.WriteLine("El promedio de los numeros ingresados es: {0}", prom);
            Console.WriteLine("El mayor numero ingresados es: {0}", maximo);
            Console.WriteLine("El menor numero ingresados es: {0}", minimo);

            System.Console.ReadKey();
        }
    }
}
