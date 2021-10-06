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
        /// Constructor sin parametros para Trooper
        /// </summary>
        public Trooper()
        {
        }

        /// <summary>
        /// Constructor con parametros para Trooper
        /// </summary>
        /// <param name="armamento">Es el arma del trooper</param>
        public Trooper(Blaster armamento)
        {
            this.armamento = armamento;
        }


        /// <summary>
        /// Constructor con parametros para Trooper
        /// </summary>
        /// <param name="armamento">Es el arma del trooper</param>
        /// <param name="esClon">Dice si es un clon o no</param>
        public Trooper(Blaster armamento, bool esClon) : this(armamento)
        {
            //this.esClon = false;
            EsClon = esClon;
        }


        //Propiedades

        public Blaster Armamento { get { return this.armamento; } }


        public bool EsClon
        {
            get
            { return this.esClon; }
            set
            { this.esClon = value ? value : false; }
        }


        public abstract string Tipo { get; }



        //Metodos


    /*    public override bool Equals(object obj)
        {

            return (this == obj);

        }*/
        
        public override bool Equals(Object obj)
        {
            bool retorno = false;

            if (this.Equals("TYPE") && obj.Equals("TYPE"))
            {
                return true;
            }

            return retorno;
        }


        public virtual string InfoTrooper()
        {
            string esUnClon = esClon ? "SI" : "NO";

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{Tipo} armado con {armamento}, {esUnClon} es clone");


            return sb.ToString();
        }



    }
}
