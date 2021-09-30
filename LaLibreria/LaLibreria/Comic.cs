using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLibreria
{
    public class Comic : Publicacion
    {
        //Atributos
        private bool esColor;

        //Constructores
        public Comic(string nombre, bool esColor, int stock, float valor) : base(nombre, stock, valor)
        {
            this.esColor = esColor;
        }

        //Propiedades

        /// <summary>
        /// Retorna true si el comic es a color.
        /// </summary>
        protected override bool EsColor { get { return this.esColor; } }


    }
}
