using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializacionLibreria;

namespace PiensaAjedrez
{
   public abstract class Recordatorios
    {
        public static ArchivoSecuencialSerializadoBinario<DateTime> miConfiguración = new ArchivoSecuencialSerializadoBinario<DateTime>(System.IO.Directory.GetCurrentDirectory() + @"\Configuracion.bin");
        public static DateTime dtmHoraRecordatorio;
        //public delegate void CambioPropiedadEventHandler();
        //public static event CambioPropiedadEventHandler unEvento;

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
            }
        }

        public static void GuardarConfiguracion(DateTime dtmHora)
        {
            
            miConfiguración.AbrirEnModoEscritura();
            miConfiguración.GrabarObjeto(dtmHora);
            miConfiguración.Cerrar();
        }

       
    }
}
