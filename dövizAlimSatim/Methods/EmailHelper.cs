using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace dövizAlimSatim.Methods
{
    public class EmailHelper
    {
        public bool SendEmail(string email, string mesaj)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("bticaret01@gmail.com");
            mailMessage.To.Add(email);
            mailMessage.Subject = "Şifre Sıfırlama";
            mailMessage.Body = mesaj;
            mailMessage.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("bticaret01@gmail.com", "Proje3434.");
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;

            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
