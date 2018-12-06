using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Net.Http;

namespace CapaProceso.Clases
{
    public class Email
    {

        MailMessage m = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        

        public bool enviarcorreo(string from, string password, string to, string mensaje) {


            try
            {
                m.From = new MailAddress(from);
                m.To.Add(new MailAddress(to));
                m.Body = mensaje;
                smtp.Host = "";
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }

            }

        }


    }
}
