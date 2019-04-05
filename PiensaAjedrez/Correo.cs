using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace PiensaAjedrez
{
    abstract class Correo
    {
        public static string Usuario = "piensaajedrez@outlook.com";
        public static string Contrasena = "123";

        /*
        public static string Usuario = "wweyes21@outlook.com";
        public static string Contrasena = "KnightJopus21";
        */

        static public void EnviarCorreo(MailMessage miCorreo)
        {
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587);

            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(miCorreo.From.ToString(), Contrasena);
            int temp = System.Net.ServicePointManager.MaxServicePointIdleTime;
            System.Net.ServicePointManager.MaxServicePointIdleTime = 1;
            client.EnableSsl = true;
            client.Send(miCorreo);
        }

       static AlternateView ObtenerImagen(String filePath, Alumno miAlumno, Pagos miPago, int intCaso)
        {
            LinkedResource res = new LinkedResource(filePath);
            res.ContentId = Guid.NewGuid().ToString();
            string htmlBody = "<html><body><center> "+@"<img src='cid:"+res.ContentId+@"'></center><br><p>Estimado padre de familia.</p><p> Por medio de este conducto queremos agradecerle su pago y reiterarle nuestro compromiso con la educacion de su hijo(a). </p><p>Estamos muy agradecidos por la confianza que nos esta brindando.</p><b>Alumno: </b>" + miAlumno.Nombre + "<p><b>Monto: </b>" + miPago.Monto.ToString("c") + "</p><b>Descripcion:</b><br><li>"+ ((intCaso==1)?("Mensualidad de "):(""))+ miPago.MesPagado + "</li><p><b>Metodo de pago: </b>" + miPago.MetodoPago + "</p><p><b>Fecha: </b>" + miPago.FechayHora.ToShortDateString() + "</p><p><i> Nota: los acentos fueron removidos intencionalmente para garantizar que el correo llegue completamente legible al destinatario. Este correo electronico es confidencial y/o puede contener informacion privilegiada. Queda prohibida la retransmision a distintas personas sin previa autorizacion del remitente.</i></p><center><b>Piensa Ajedrez<br>Direccion General.</b></center></body></html>";
            AlternateView alternateView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
            alternateView.LinkedResources.Add(res);
            return alternateView;
        }

       static public MailMessage CrearCorreo(Alumno miAlumno, Pagos miPago, int intCaso)
        {
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;            
            mail.AlternateViews.Add(ObtenerImagen(System.IO.Directory.GetCurrentDirectory() + @"\PiensaAjedrezLogo.png", miAlumno,miPago, intCaso));
            mail.From = new MailAddress(Usuario);
            mail.To.Add(miAlumno.Correo);
            mail.Subject = "Piensa Ajedrez | Pago de " + miPago.MesPagado + " realizado";
            return mail;
        }
    }
}
