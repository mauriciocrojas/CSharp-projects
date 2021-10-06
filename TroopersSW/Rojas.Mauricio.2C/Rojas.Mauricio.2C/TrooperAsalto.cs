using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojas.Mauricio._2C
{
    public class TrooperAsalto : Trooper
    {
        //Constructores

        public TrooperAsalto(Blaster armamento) :base(armamento)
        {
            this.esClon = true;
        }

        //Propiedades
        public override string Tipo
        {
            get
            { return "Comando para misiones de infiltración"; }



        }
    }
}