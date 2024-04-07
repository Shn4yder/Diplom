using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using diplom.Properties;

namespace diplom
{
    internal class MailManager
    {
        public static MailMessage CreateMail(string emailTo, string subject, string body)
        {
            var from = new MailAddress(Resources.mail, "Art Coworking");
            var to = new MailAddress(emailTo);
            var mail = new MailMessage(from, to);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            return mail;
        }


        public static void SendMail(MailMessage mail)
        {
            SmtpClient smpt = new SmtpClient("smtp.gmail.com", 587);
            smpt.Credentials = new NetworkCredential(Resources.mail, Resources.mail_pass);
            smpt.EnableSsl = true;

            smpt.Send(mail);
        }
    }
}
