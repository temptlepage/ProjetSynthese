﻿using System.Net.Mail;
using Microsoft.Ajax.Utilities;
using Stagio.Domain.Entities;


namespace Stagio.Web.Services
{
    public sealed class Mailler : IMailler
    {
        private static Mailler instance = new Mailler();

        private SmtpClient client;

        private const string SERVER = "jenkinssmtp.cegep-ste-foy.qc.ca";
        private const int SMTP_PORT = 25;
        static Mailler()
        {

        }
        private Mailler()
        {
            client = new SmtpClient();
            client.Port = SMTP_PORT;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = SERVER;
        }

        public static Mailler Instance
        {
            get
            {
                return instance;
            }
        }

        public bool SendEmail(string destination, string subject, string content)
        {
            try
            {
                MailMessage mail = new MailMessage("noreply@" + client.Host, destination);
                mail.IsBodyHtml = true;
                mail.Subject = subject;
                mail.Body = content;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                client.Send(mail);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public void SetNewSmtpOptions(Misc misc, string destination)
        {
            const string TEST_SUBJECT = "Stagio, essaie des options Smtp";
            const string TEST_CONTENT = "Essaie des nouvelles options Smtp du site Stagio.";
            client.Host = misc.SmtpServer;
            client.Port = misc.SmtpPort;

            if (misc.SmtpUsername != null && misc.SmtpPassword != null)
            {
                client.Credentials = new System.Net.NetworkCredential(misc.SmtpUsername, misc.SmtpPassword);
                client.EnableSsl = true;
            }
            else
            {
                client.Credentials = null;
                client.EnableSsl = false;
            }
            
            //test new options
            if (!destination.IsNullOrWhiteSpace())
            {
                SendEmail(destination, TEST_SUBJECT, TEST_CONTENT);
            }
           
        }
    }
}
