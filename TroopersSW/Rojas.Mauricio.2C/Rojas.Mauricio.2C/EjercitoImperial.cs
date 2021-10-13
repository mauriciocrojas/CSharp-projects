using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojas.Mauricio._2C
{
    public class EjercitoImperial
    {
        //Atributos

        private int capacidad;
        private List<Trooper> troopers;

        //Constructores

        private EjercitoImperial()
        {
            this.troopers = new List<Trooper>();

        }


        public EjercitoImperial(int capacidad) : this()//llama al constructor privado
        {
            this.capacidad = capacidad;
        }

        //Propiedades

        public List<Trooper> Troopers
        {
            get
            {
                return this.troopers;
            }
        }



        //Sobrecargas

        public static EjercitoImperial operator -(EjercitoImperial ejercito, Trooper soldado)
        {


            foreach (Trooper item in ejercito.troopers)
            {
                if (item.Equals(soldado))
                {
                    ejercito.troopers.Remove(soldado);
                    break;
                }
            }

            return ejercito;

        }


        public static EjercitoImperial operator +(EjercitoImperial ejercito, Trooper soldado)
        {

            if(ejercito.troopers.Count < ejercito.capacidad)
            {
                 ejercito.troopers.Add(soldado);
            }

            return ejercito;

        }








    }
}
