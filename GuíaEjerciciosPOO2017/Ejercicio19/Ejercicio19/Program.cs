using System;
using Clases;
namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hola,";
            string word2 = " Juan Carlos";
            long num1 = 17;
            long num2 = 33;

            Sumador operacion1 = new Sumador(10);
            Sumador operacion2 = new Sumador(10);
            Console.WriteLine("Cantidad de sumas inicial de la operacion 1: " + operacion1.Mostrar());
            Console.WriteLine("Cantidad de sumas inicial de la operacion 2: " + operacion2.Mostrar());

            //Se agregaron dos sumas
            string cadena = operacion1.Sumar(word1, word2);
            long enteros = operacion2.Sumar(num1, num2);

            Console.WriteLine("Agregamos dos sumas:\nCadena: {0}\nEnteros: {1}", cadena, enteros);
            Console.ReadKey();


            long probarSuma = operacion1 + operacion2;
            bool probarPipe = operacion1 | operacion2;

            string comparacion = probarPipe ? "Si" : "No";

            Console.WriteLine("Cantidad de sumas final de la operacion 1: " + operacion1.Mostrar());
            Console.WriteLine("Cantidad de sumas final de la operacion 2: " + operacion2.Mostrar());

            Console.WriteLine("Cantidad de sumas: " + probarSuma + " Son iguales?: " + comparacion);
            Console.ReadKey();


        }
    }
}
