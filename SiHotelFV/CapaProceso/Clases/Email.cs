using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Net.Http;
using CapaDatos.Clases.EmailTableAdapters;

namespace CapaProceso.Clases
{
    public class Email
    {
        private static host_mailTableAdapter CEmail = new host_mailTableAdapter();

        MailMessage email = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        public static CapaDatos.Clases.Email.host_mailDataTable Lista()
        {
            return CEmail.GetLista();
        }
        public bool enviarcorreo(string paraMail) {


            try
            {
                string asunto="Contraseña temporal";
                string mensaje = "no se";
                /* recuperar de base de tabla HostMail */
                string Usuario = "cepes@cepes.ec";
                string Contrasenia = "Orlando26";
                string smtpHost = "mail.cepes.ec";
                int puerto = 587;
                bool ssl = false;
                /* recuperar de base de tabla HostMail */

                email.From = new MailAddress(Usuario);
                email.To.Add(new MailAddress(paraMail));
                email.Subject = asunto;
                email.Body = mensaje;
                email.IsBodyHtml = true;
                smtp.Host = smtpHost;
                smtp.Port = puerto;
                smtp.Credentials = new NetworkCredential(Usuario, Contrasenia);
                smtp.EnableSsl = ssl;
                smtp.Send(email);

                return true;
            }
            catch (Exception e)
            {
               // Console.WriteLine(e.StackTrace);
                return false;
            }

            }

        }

    


    }

