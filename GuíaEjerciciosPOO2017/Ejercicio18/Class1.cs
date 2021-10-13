using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX
        {
            get
            {
                return this.x;
            }

        }

        public int GetY
        {
            get
            {
                return this.y;
            }

        }

    }

    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;


        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX, vertice3.GetY);
            this.vertice4 = new Punto(vertice3.GetX, vertice1.GetY);


        }

        private float GetArea
        {
            get
            {
                //  Calculamos base
                int ancho = Math.Abs(vertice1.GetX - vertice3.GetX);
                int alto = Math.Abs(vertice1.GetY - vertice3.GetY);

                return ancho * alto;
            }
        }

        private float GetPerimetro
        {
            get
            {
                int ancho = Math.Abs(vertice1.GetX - vertice3.GetX);
                int alto = Math.Abs(vertice1.GetY - vertice3.GetY);


                return (ancho + alto) * 2;
            }
        }



        public float Area()
        {
            if (this.area == 0)
            {
                this.area = GetArea;
            }
            return this.area;
        }

        public float Perimetro()
        {
            if (this.perimetro == 0)
            {
                this.perimetro = GetPerimetro;
            }

            return this.perimetro;
        }



    }

}
