//17.Crear la clase Bolígrafo a partir del siguiente diagrama: (diagrama en pdf)
//a.La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante
//en el Bolígrafo llamada cantidadTintaMaxima donde se guardará dicho valor.
//b. Generar los métodos GetColor y GetTinta para los correspondientes atributos (sólo
//retornarán el valor del mismo).
//c.Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
//i. tinta será el valor a agregar de tinta, pudiendo ser positivo (cargar tinta) o negativo
//(gastar tinta)
//ii.Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a
//0 y menor o igual a cantidadTintaMaxima.
//d. Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.
//e. En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta
//de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
//f.El método Pintar(short, out string) restará la tinta gastada (reutilizar código SetTinta), sin
//poder quedar el nivel en negativo, avisando si pudo pintar (nivel de tinta mayor a 0).
//También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de
//tinta. O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es
//10 "***".
//g. Utilizar todos los métodos en el Main.
//h. Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho
//bolígrafo.
//Nota: Crear el constructor que crea conveniente. La clase Bolígrafo y el Program deben estar en
//namespaces distintos.


using System;
using Entidades;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guardamos el color de la consola
            ConsoleColor colorOriginalDeConsola = Console.ForegroundColor;     
            
            // Generamos string para usarlo luego
            string dibujo;

            // Instanciamos un boligrafo de tinta azul
            Boligrafo tintaAzul = new Boligrafo(100, ConsoleColor.Blue);
            Console.WriteLine("Capaxidad maxima del boligrafo: 100");

            // Obtenemos el color de dicho boligrafo
            Console.ForegroundColor = tintaAzul.GetColor();

            // Una vez obtenido el color, utilizamos el metodo pintar
            // Se gasto la siguiente tinta: 35
            tintaAzul.Pintar(35, out dibujo);
            Console.WriteLine(dibujo);

            // Se gasto la siguiente tinta: 75
            tintaAzul.Pintar(75, out dibujo);
            Console.WriteLine(dibujo);

            // Aplicamos de nuevo el color original de la consola
            Console.ForegroundColor = colorOriginalDeConsola;

            // Mostramos el nivel de tinta
            Console.WriteLine($"El nivel de tinta del boligrafo azul es {tintaAzul.GetTinta()}");

            Console.WriteLine("\n\n Intentamos volver a dibujar");
            tintaAzul.Pintar(3, out dibujo);
            Console.WriteLine(dibujo);

            Console.ReadKey();
        }
    }
}
