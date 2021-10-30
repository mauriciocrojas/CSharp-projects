using System.Text;


namespace Rojas.Mauricio._2C
{
    public abstract class Equipo
    {
        //Atributos

        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;


        //Constructores

        /// <summary>
        /// Constructor con parametros para Equipo
        /// </summary>
        /// <param name="nombre">Es el nombre del equipo</param>
        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }

        //Propiedades

        public string Nombre
        {
            get { return this.nombre; }
        }

        public int PE
        {
            get { return this.partidosEmpatados; }
            set { this.partidosEmpatados = value; }
        }

        public int PG
        {
            get { return this.partidosGanados; }
            set { this.partidosGanados = value; }
        }

        public int PJ
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }

        public int PP
        {
            get { return this.partidosPerdidos; }
            set { this.partidosPerdidos = value; }
        }

        public int Puntuacion
        {
            get { return this.puntuacion; }
            set { this.puntuacion = value; }
        }

        public string Tipo { get { return this.GetType().Name; } }



        //Metodos

        public override bool Equals(object obj)
        {

            return this.GetType() == obj.GetType();

        }

        public abstract int GetDificultad();


        /// <summary>
        /// Metodo que simula una competencia en base a la dificultad
        /// </summary>
        /// <param name="equipoA">Es el nombre del equipoA/param>
        /// <param name="equipoB">Es el nombre del equipoB</param>
        /// <returns></returns>
        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            bool returnAux = false;

            if (equipoA.Equals(equipoB))
            {
                returnAux = true;
                equipoA.PJ++;
                equipoB.PJ++;
                if (equipoA.GetDificultad() > equipoB.GetDificultad())
                {
                    equipoA.PG++;
                    equipoB.PP++;
                    equipoA.Puntuacion += 3;
                }
                else if (equipoA.GetDificultad() < equipoB.GetDificultad())
                {
                    equipoB.PG++;
                    equipoA.PP++;
                    equipoB.Puntuacion += 3;
                }
                else
                {
                    equipoA.Puntuacion += 1;
                    equipoB.Puntuacion += 1;
                    equipoA.PE++;
                    equipoB.PE++;
                }
            }

            return returnAux;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this.nombre);

            return sb.ToString();
        }

        //Sobrecargas 

        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            return (equipoA.nombre == equipoB.nombre && equipoA.Equals(equipoB));
        }

        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA.nombre == equipoB.nombre && equipoA.Equals(equipoB));
        }

    }
}
