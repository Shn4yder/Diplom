using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using diplom.Properties;
using diplom.Models;
using System.Windows.Forms;

namespace diplom
{
    internal class MailManager
    {
        // Создание письма
        public static MailMessage CreateMail(string emailTo, string body)
        {
            var from = new MailAddress(Resources.mail, "Art Coworking");
            var to = new MailAddress(emailTo);
            var mail = new MailMessage(from, to);
            mail.Subject = $"Отчет о смене за {DateTime.Now.ToString("dd.MM.yyyy")}";
            mail.Body = body;
            mail.IsBodyHtml = true;
            return mail;
        }

        // Отправка письма
        public static void SendMail(MailMessage mail)
        {
            SmtpClient smpt = new SmtpClient("smtp.gmail.com", 587);
            smpt.Credentials = new NetworkCredential(Resources.mail, Resources.mail_pass);
            smpt.EnableSsl = true;

            smpt.Send(mail);
        }

        // Отправка отчета
        public static void SendReport(string name_usr)
        {
            List<UsersModel> users = DataManager.LoadUsers();    
            ReportManager report = new ReportManager(name_usr);

            if (InternetCS.IsConnectedToInternet())  //проверка подлкючения к интернету
            {
                foreach (UsersModel user in users)
                {
                    if (user.Status == "Администратор")
                    {
                        //System.Net.Mail.SmtpException
                        var mail = MailManager.CreateMail(user.Email, $"{report.GetReport()}");    // отправка каждому администратору
                        try { SendMail(mail); }
                        catch { } 
                    }
                }
            }
            else
            {
                MessageBox.Show("Отсутствует подлкючение к интернету, отчет на почту не отправлен", "Внимание");
            }
            
        }
    }
}
