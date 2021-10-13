/*
3. Mostrar por pantalla todos los números primos que haya 
hasta el número que ingrese el usuario por consola. Nota: 
Utilizar estructuras repetitivas, selectivas y la función módulo (%).
*/

using System;

namespace Ejercicio3
{
    class Ejercicio03
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int contadorPrimos=0;

            Console.WriteLine("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out numeroIngresado);

            Console.WriteLine("Los numeros primos hasta el numero ingresado son: ");
            for (int i = 1; i<= numeroIngresado; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contadorPrimos++;
                    }
                }
                if (contadorPrimos == 2)
                {
                    Console.WriteLine("{0} ", i);
                }
                contadorPrimos = 0;
            }
            System.Console.ReadKey();
        }
    }
}
