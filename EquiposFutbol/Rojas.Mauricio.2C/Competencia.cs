using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojas.Mauricio._2C
{
    public class Competencia
    {
        //Atributos

        private int cantidadCompetidores;
        private List<Equipo> equipos;
        private string nombre;


        //Constructores

        /// <summary>
        /// Constructor privado de torneo que se va a usar desde la conversion implicita de string
        /// Por defecto cantidad de competidores es cero
        /// </summary>
        /// <param name="nombre"></param>
        private Competencia(string nombre) : this(nombre, 5)
        {

        }

        /// <summary>
        /// Constructor public de torneo que recibe todos los parametros e inicializa la lista
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cantidadCompetidores"></param>
        public Competencia(string nombre, int cantidadCompetidores)
        {
            this.equipos = new List<Equipo>();
            this.nombre = nombre;
            this.cantidadCompetidores = cantidadCompetidores;
        }


        //Propiedades

        public int CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { cantidadCompetidores = value; }
        }


        public List<Equipo> Equipos
        {
            get
            { return this.equipos; }
        }

        public string Nombre { get { return this.nombre; } set { nombre = value; } }


        //Metodos


        /// <summary>
        /// Metodo de clase que expone los datos del torneo y sus equipos (basket y futbol)
        /// </summary>
        /// <param name="torneo"></param>
        /// <returns></returns>
        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Competencia: " + torneo.nombre);
            sb.AppendLine("Cantidad de competidores: " + torneo.equipos.Count +"/"+ torneo.cantidadCompetidores); ;

            foreach (Equipo item in torneo.equipos)
            {
                sb.AppendLine(item.ToString());
            }

            //Forma Landa
            //torneo.Equipos.ForEach(element => sb.AppendLine(element.ToString()));

            return sb.ToString();
        }

        //Sobrecargas 


        /// <summary>
        /// Un torneo y un equipo son iguales si este equpo esta en el torneo, se compara por ==
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static bool operator ==(Competencia torneo, Equipo equipo)
        {
            foreach (Equipo item in torneo.equipos)
            {
                if (item == equipo)
                {
                    return true;
                }
            }
            return false;

            //Forma Landa
            //return torneo.Equipos.Exists(element => element == equipo);
        }

        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {


            if (torneo != equipo && torneo.CantidadCompetidores > torneo.equipos.Count)
            {
                torneo.Equipos.Add(equipo);
            }

            return torneo;

        }



        /// <summary>
        /// Conversion implicita de string a torneo que devuelve una instancia con el nombre asignado
        /// Llama al constructor privado y por defecto no asigna competidores
        /// </summary>
        /// <param name="nombre"></param>
        public static implicit operator Competencia(string nombre)
        {
            return new Competencia(nombre);
        }

    }
}
