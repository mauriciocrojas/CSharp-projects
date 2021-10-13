using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private int nota1;
        private int nota2;
        private float notaFinal;

        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(
            string apellido, 
            int legajo, 
            string nombre
        )
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void Estudiar(int notaUno, int notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            if(this.nota1 >= 4  && this.nota2 >=4)
            {
                this.notaFinal = (float) (nota1 + nota2) / 2;
            } else
            {
                this.nota1 = -1;
                this.nota2 = -1;
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            string notaFinal;
           

            if(this.notaFinal == -1)
            {
                notaFinal = "Alumno desaprobado";
            } else
            {
                notaFinal = this.notaFinal.ToString();
            }

            string texto = "Nombre: " + this.nombre + " Apellido: " + this.apellido + " Legajo: " + this.legajo + " Nota 1: " + this.nota1 + " Nota 2: " + this.nota2 + " Nota Final: " + notaFinal;


            return texto;
        }

        

    }
}
