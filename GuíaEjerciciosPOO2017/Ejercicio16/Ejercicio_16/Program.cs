//16. Crear la clase Alumno de acuerdo al siguiente diagrama: (diagrama en pdf)
//a.Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle
//nombre, apellido y legajo a cada uno de ellos.
//b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
//c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
//iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
//el método de instancia Next de la clase Random.
//d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
//mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
//desaprobado"

using System;
using Entidades;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int legajo;
            int nota1;
            int nota2;

            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el legajo: ");
            int.TryParse(Console.ReadLine(), out legajo);

            Console.WriteLine("Ingrese la nota 1: ");
            int.TryParse(Console.ReadLine(), out nota1);

            Console.WriteLine("Ingrese la nota 2: ");
            int.TryParse(Console.ReadLine(), out nota2);

            // Instanciamos la clase
            Alumno unAlumno = new Alumno(apellido, legajo, nombre);

            // Asignamos las notas
            unAlumno.Estudiar(nota1, nota2);

            // Calculamos el final
            unAlumno.CalcularFinal();

            // Mostramos alumno
            Console.WriteLine(unAlumno.Mostrar());

            Console.ReadKey();
        }
    }
}
