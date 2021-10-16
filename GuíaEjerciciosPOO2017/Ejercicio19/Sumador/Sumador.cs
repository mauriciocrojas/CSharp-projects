using System;

namespace Clases
{
    public class Sumador
    {
        //Atributos
        private int cantidadSumas;

        //Constructores
        public Sumador() : this(0)
        {

        }

        public Sumador (int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        //Metodos
        
        public long Sumar (long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar (string a, string b)
        {
            this.cantidadSumas++;
            return a + b;

        }

        //Sobrecarga de operadores

        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }


        public static bool operator | (Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas.Equals(s2.cantidadSumas);
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (long) (s1.cantidadSumas + s2.cantidadSumas);
        }

        
        public int Mostrar()
        {
            return this.cantidadSumas;
        }


    }
}
