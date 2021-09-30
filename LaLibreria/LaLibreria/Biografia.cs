using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLibreria
{
    public class Biografia : Publicacion
    {

        //Constructores
        public Biografia(string nombre) : base(nombre)
        {

        }

        public Biografia(string nombre, int stock) : base(nombre, stock)
        {


        }

        public Biografia(string nombre, int stock, float valor) : base(nombre, stock, valor)
        {


        }

        //Propiedades
        protected override bool EsColor { get { return false; } }


        /// <summary>
        /// Retorna true si hay stock. 
        /// </summary>
        public override bool HayStock
        {
            get
            {
                return this.stock > 0;
            }

        }

        //Sobrecargas

        /// <summary>
        /// Genera un objeto Biografia a partir del nombre.
        /// </summary>
        /// <param name="nombre"></param>
        public static explicit operator Biografia(string nombre)
        {

            return new Biografia(nombre);

        }
    }
}
