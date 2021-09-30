using System;
using System.Text;


namespace LaLibreria
{
    public abstract class Publicacion
    {

        //Atributos
        protected float importe;
        protected string nombre;
        protected int stock;

        //Constructores
        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }
        public Publicacion(string nombre, int stock):this(nombre)
        {
            this.stock = stock;
        }
        public Publicacion(string nombre, int stock, float importe):this(nombre, stock)
        {
            this.importe = importe;
        }

        //Propiedades
        protected abstract bool EsColor { get; }

        public virtual bool HayStock
        {
            get
            {
                return this.stock > 0 && this.importe > 0;
            }
        }

        public float Importe { get { return this.importe; } }

        public int Stock
        {
            get { return this.stock; }
            set
            {
                if (value > 0)
                    this.stock = value;

            }
        }


        //Metodos
        public string ObtenerInformacion()
        {

            string esColor = EsColor ? "SI" : "NO";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Stock: " + this.stock);
            sb.AppendFormat("Es color: " + esColor+ Environment.NewLine);
            sb.Append("Valor: $" + this.importe);

            return sb.ToString();

        }

        public override string ToString()
        {
            return this.nombre;
        }





    }
}
