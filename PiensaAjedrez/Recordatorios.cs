using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializacionLibreria;
using System.IO;

namespace PiensaAjedrez
{
   public abstract class Recordatorios
    {
        public static ArchivoSecuencialSerializadoBinario<DateTime> miConfiguración = new ArchivoSecuencialSerializadoBinario<DateTime>(System.IO.Directory.GetCurrentDirectory() + @"\Configuracion.bin");
        public static DateTime dtmHoraRecordatorio;


        private static int _intCaso;

        public static int intCaso
        {
            get { return _intCaso; }
            set { _intCaso = value;
                if (intCaso == 1)
                    Recordar = true;
                else
                    Recordar = false;
            }
        }


        private static bool _blnRecordar;

        public static bool Recordar
        {
            get { return _blnRecordar; }
            set { _blnRecordar = value;
                //if (Recordar)
                //    unEvento();
            }
        }

        public static void CargarConfiguracion()
        {
            try
            {
            miConfiguración.AbrirEnModoLectura();
                while (true)
                {
                    dtmHoraRecordatorio = miConfiguración.LeerObjeto();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (dtmHoraRecordatorio != null)
                    intCaso = 1;
                else
                    intCaso = 0;
                miConfiguración.Cerrar();
                if (DateTime.Today.Day != 5 || DateTime.Today.Day != 10 || DateTime.Today.Day != 11 || !EsUltimoDia() || DateTime.Today.Day != 13)
                    File.Delete(Directory.GetCurrentDirectory() + @"\Configuracion.bin");
            }
        }

       public static bool EsUltimoDia()
        {
            if (DateTime.Now.Month == 1 || DateTime.Now.Month == 3 || DateTime.Now.Month == 5 || DateTime.Now.Month == 7 || DateTime.Now.Month == 8 || DateTime.Now.Month == 10 || DateTime.Now.Month == 12)
            {
                if (DateTime.Now.Day == 31)
                    return true;
                else
                    return false;
            }
            if (DateTime.Now.Month == 4 || DateTime.Now.Month == 6 || DateTime.Now.Month == 9 || DateTime.Now.Month == 11)
            {
                if (DateTime.Now.Day == 30)
                    return true;
                else
                    return false;
            }
            if (DateTime.Now.Month == 2)
                if (DateTime.Now.Day == 28)
                    return true;
                else
                    return false;
            return false;
        }

        public static void GuardarConfiguracion(DateTime dtmHora)
        {
            File.Delete(Directory.GetCurrentDirectory() + @"\Configuracion.bin");
            miConfiguración.AbrirEnModoEscritura();
            miConfiguración.GrabarObjeto(dtmHora);
            miConfiguración.Cerrar();
        }

       
    }
}
