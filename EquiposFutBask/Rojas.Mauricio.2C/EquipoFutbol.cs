using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojas.Mauricio._2C
{
    public class EquipoFutbol : Equipo
    {
        //Atributos

        private bool jugadoresEstrellas;

        //Constructores

        /// <summary>
        /// Constructor con parametros para EquipoFutbol
        /// </summary>
        /// <param name="nombre">Es el nombre del equipoFutbol</param>
        public EquipoFutbol(string nombre) : this(nombre, false)
        {

        }

        public EquipoFutbol(string nombre, bool jugadoresEstrellas) : base(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrellas;
        }


        //Metodos

        /// <summary>
        /// Metodo que retorna la dificultad random de un equipo, si este tiene jugadores estrellas sera el doble
        /// </summary>
        /// <returns></returns>
        public override int GetDificultad()
        {
            Random dificultadRandom = new Random();


            if (jugadoresEstrellas)
            {
                return (dificultadRandom.Next(7, 10) * 2);
            }
            return dificultadRandom.Next(7, 10);
        }


        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Futbol - ");
            sb.AppendFormat(base.MostrarDatos());

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }




    }
}
