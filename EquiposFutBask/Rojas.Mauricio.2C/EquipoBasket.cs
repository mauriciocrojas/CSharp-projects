using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojas.Mauricio._2C
{
    public class EquipoBasket : Equipo
    {

        //Atributos

        private ELiga liga;

        //Construtores

        /// <summary>
        /// Constructor con parametros para EquipoBasket
        /// </summary>
        /// <param name="nombre">Es el nombre del equipoBasket</param>
        public EquipoBasket(string nombre) : this(nombre, ELiga.NBA)
        {

        }

        public EquipoBasket(string nombre, ELiga liga) : base(nombre)
        {
            this.liga = liga;
        }

        //Metodos

        public override int GetDificultad()
        {
            Random r = new Random();

            if (this.liga == ELiga.ACB)
            {
                return r.Next(1, 7);
            }

            else if (this.liga == ELiga.Euroleague)
            {
                return r.Next(5, 10);
            }

            else //(this.liga == ELiga.NBA)
            {
                return r.Next(8, 10);
            }


        }


        /// <summary>
        /// Agrega basket al nombre del equipo
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Basket – ");
            sb.AppendFormat(base.MostrarDatos());
            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }


    }
}
