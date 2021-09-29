using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDispositivo
{
    public abstract class Aplicacion
    {
        //Atributos
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return this.sistemaOperativo;
            }
        }

        //Constructores
        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMB;
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int maximoTamanio = int.MinValue;

            Aplicacion aplicacionMasPesada = null;

            foreach (Aplicacion app in listaApp)
            {
                if (app.Tamanio > maximoTamanio)
                {
                    maximoTamanio = app.Tamanio;
                    aplicacionMasPesada = app;
                }
            }

            return aplicacionMasPesada;
        }

        //Propiedades


        protected abstract int Tamanio { get; }

        //Metodos
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Sistema operativo: {SistemaOperativo}");
            sb.AppendLine($"Tamaño ocupado: {Tamanio}");

            return sb.ToString();

        }


        public override string ToString()
        {
            return this.nombre;
        }

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (app is null || listaApp is null)
            {
                return false;
            }

            foreach (Aplicacion a in listaApp)
            {
                if (app.nombre == a.nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {

            if (listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }


            return false;

        }
    }
}
