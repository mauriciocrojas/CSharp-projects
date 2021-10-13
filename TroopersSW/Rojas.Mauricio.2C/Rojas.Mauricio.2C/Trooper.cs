using System;
using System.Text;

namespace Rojas.Mauricio._2C
{
    public abstract class Trooper
    {

        //Atributos
        protected Blaster armamento;
        protected bool esClon;


        //Constructores

        /// <summary>
        /// Constructor con parametros para Trooper
        /// </summary>
        /// <param name="armamento">Es el arma del trooper</param>
        public Trooper(Blaster armamento) : this(armamento, false)
        {

        }


        /// <summary>
        /// Constructor con parametros para Trooper
        /// </summary>
        /// <param name="armamento">Es el arma del trooper</param>
        /// <param name="esClon">Dice si es un clon o no</param>
        public Trooper(Blaster armamento, bool esClon) 
        {
            this.armamento = armamento;
            this.esClon = esClon;
        }


        //Propiedades

        public Blaster Armamento { get { return this.armamento; } }


        public bool EsClon
        {
            get
            { return this.esClon; }
            set
            { this.esClon = value; }
        }


        public abstract string Tipo { get; }



        //Metodos
        
        public override bool Equals(Object obj)
        {

            return this.GetType() == obj.GetType();
        }


        public virtual string InfoTrooper()
        {
            //string esUnClon = esClon ? "SI" : "NO";

            //StringBuilder sb = new StringBuilder();
            //sb.AppendFormat($"{Tipo} armado con {armamento}, {esUnClon} es clone");


            //return sb.ToString();

            return string.Format("{0} armado con {1}, {2} es clone", this.Tipo, this.Armamento, this.EsClon ? "SI" : "NO" );
        }



    }
}
