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


        public EjercitoImperial(int capacidad)
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


            foreach (Trooper soldier in ejercito.troopers)
            {
                if (soldier == soldado)
                {
                    ejercito.troopers.Remove(soldado);
                    break;
                }
            }

            return ejercito;

        }


        public static EjercitoImperial operator +(EjercitoImperial ejercito, Trooper soldado)
        {

            ejercito.troopers.Add(soldado);

         /*int count = ejercito.troppers.Count();

        if (count <= ejercito.capacidad)
        {

        }*/

            return ejercito;

        }








    }
}
