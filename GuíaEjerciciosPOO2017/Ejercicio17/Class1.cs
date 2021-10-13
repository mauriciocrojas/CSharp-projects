using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            int tintaAux = this.tinta + tinta;

            if(tintaAux > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else if(tintaAux < 0)
            {
                this.tinta = 0;
            }
            else
            {
                this.tinta += tinta;
            }
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            string cadenaAux = string.Empty;
            bool returnAux = false;

            if(this.tinta == 0)
            {
                dibujo = "No se puede pintar porque no hay mas tinta";
            } 
            
            else
            {
                while(gasto > 0 && this.tinta > 0)
                {
                    cadenaAux += "*";
                    gasto--;
                    this.SetTinta(-1);
                }

                dibujo = cadenaAux;
                returnAux = true;

            }

            return returnAux;

        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }


    }
}
