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

        public TrooperExplorador(string vehiculo)
        {
            this.vehiculo = vehiculo;
            base.armamento = Blaster.EC17;
            

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
            string esUnClon = esClon ? "SI" : "NO";

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{Tipo} armado con {armamento}, " +
                $"{esUnClon} es clone, su vehiculo es {vehiculo}");


            return sb.ToString();
        }










    }
}
