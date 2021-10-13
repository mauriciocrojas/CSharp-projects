using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojas.Mauricio._2C
{
    public class TrooperExplorador : Trooper
    {
        //Atributos

        public string vehiculo;



        //Constructores

        public TrooperExplorador(string vehiculo) : base(Blaster.EC17)
        {
            this.Vehiculo = vehiculo;
        }


        //Propiedades

        public override string Tipo { get { return "Soldado de exploracion"; } }


        public string Vehiculo
        {
            get { return this.vehiculo; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vehiculo = value;
                }
                else
                {
                    vehiculo = "Indefinido";
                }
            }
        }

        //Metodos

        public override string InfoTrooper()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.InfoTrooper());
            sb.AppendFormat($"su vehiculo es {vehiculo}");


            return sb.ToString();
        }










    }
}
