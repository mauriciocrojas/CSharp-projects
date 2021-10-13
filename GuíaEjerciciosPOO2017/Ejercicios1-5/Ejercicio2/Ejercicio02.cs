/*
2. Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, caso contrario, 
mostrar el mensaje: "ERROR. ¡Reingresar número!". Nota: 
Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
*/

using System;

namespace Ejercicio2
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {

            int numeroIngresado;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (numeroIngresado <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!: ");
                int.TryParse(Console.ReadLine(), out numeroIngresado);
            }

            cuadrado = Math.Pow(numeroIngresado, 2);
            cubo = Math.Pow(numeroIngresado, 3);

            Console.WriteLine("El cuadrado del numero ingresado es: {0} y su cubo es: {1}", cuadrado, cubo);

            System.Console.ReadKey();
        }
    }
}
