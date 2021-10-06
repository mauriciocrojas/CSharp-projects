using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojas.Mauricio._2C
{
    public class TrooperArena : Trooper
    {

        //Metodos

        public TrooperArena(Blaster armamento):base(armamento)
        {

        }



        //Propiedades

        public override string Tipo
        {
            get
            { return "Soldado de asalto de terrenos desérticos"; }
        }




    }
}
