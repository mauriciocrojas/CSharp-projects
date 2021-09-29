using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDispositivo
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        //Constructores
        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }

        //Metodos
        public static bool InstalarApp(Aplicacion app)
        {
            if (app.SistemaOperativo != sistemaOperativo)
            {
                return false;
            }

            return appsInstaladas + app;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistema operativo: {sistemaOperativo} {Environment.NewLine}");

            foreach (Aplicacion app in appsInstaladas)
            {
                sb.AppendLine(app.ObtenerInformacionApp());
            }

            return sb.ToString();

        }
    }
}
