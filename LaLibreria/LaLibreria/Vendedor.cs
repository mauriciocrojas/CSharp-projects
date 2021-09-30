using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLibreria
{
    public class Vendedor
    {
        //Atributos
        private string nombre;
        private List<Publicacion> ventas;

        //Constructores
        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre) : this()
        {
            this.nombre = nombre;
        }


        //Metodos

        /// <summary>
        /// Retorna la información del vendedor, sus ventas y la ganancia total de las mismas.
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public static string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            float gananciaTotal = 0;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + vendedor.nombre.ToUpper());
            sb.AppendLine("---------------------");

            foreach (Publicacion venta in vendedor.ventas)
            {
                sb.AppendLine(venta.ObtenerInformacion());
                gananciaTotal += venta.Importe;
            }

            sb.AppendLine("Ganancia Total: " + gananciaTotal);

            return sb.ToString();
        }


        //Sobrecargas

        /// <summary>
        /// Agrega al vendedor una publicación, 
        /// siempre y cuando haya stock suficiente para realizar una venta del producto, 
        /// agregando en ese caso la información de la venta a la lista 
        /// y descontando Stock de la publicación.
        /// </summary>
        /// <param name="vendedor"></param>
        /// <param name="publicacion"></param>
        /// <returns></returns>
        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if (publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;
                return true;
            }
            return false;
        }



    }
}
