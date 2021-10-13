/*
5. Un centro numérico es un número que separa una lista de números enteros
(comenzando en 1) en dos grupos de números, cuyas sumas son iguales. 
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los 
grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los 
grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595. 
Se pide elaborar una aplicación que calcule los centros numéricos 
entre 1 y el número que el usuario ingrese por consola. 
Nota: Utilizar estructuras repetitivas y selectivas.
 */

using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mensaje
            Console.Title = "Ejercicio 05";
            Console.WriteLine("Calculo centro numerico\n" +
                              "-----------------------");
            // Variables
            double aumento = 1,
                numero,
                i,
                j,
                sumaAtras,
                sumaAdelante;

            // Ingreso de datos
            Console.Write("Ingrese un numero (ejemplo: 10000): ");
            numero = double.Parse(Console.ReadLine());

            // Comienzo del programa
            while (aumento < numero)
            {

                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                // Calculo para atras
                for (i = 1; i < aumento; i++)
                {
                    sumaAtras = sumaAtras + i;
                }
                //calculo para adelante
                for (j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                    {
                        break;
                    }
                    sumaAdelante = sumaAdelante + j;
                }

                // Mostrando en pantalla
                if (sumaAtras == sumaAdelante)
                    Console.WriteLine("Es centro numerico: {0}", aumento);
            }
            Console.ReadLine();
        }
    }

}

