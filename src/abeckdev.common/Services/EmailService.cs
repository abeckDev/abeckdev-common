using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using AbeckDev.Common.Models.Mail;

namespace AbeckDev.Common.Services
{
    public interface IEmailService
    {
        void Send(EmailMessage emailMessage);
    }
    public class EmailService : IEmailService
    {
        // Get Email Settings from Config File
        private readonly IEmailConfiguration _emailConfiguration;
        public EmailService(IEmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }

        /// <summary>
        /// Sends a <see cref="EmailMessage"/>
        /// </summary>
        /// <param name="emailMessage"></param>
        public void Send(EmailMessage emailMessage)
        {
            //Get Message Client
            var message = new MimeMessage();


            //Add email reciever to Message Client
            message.To.AddRange(emailMessage.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));

            //Add email sender to Message Client
            message.From.AddRange(emailMessage.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));

            //Add Subject to Message Client
            message.Subject = emailMessage.Subject;

            //Add the Content in HTML Format to Message Client
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = emailMessage.Content
            };


            //Get SSL Settings
            var options = new MailKit.Security.SecureSocketOptions();

            switch (_emailConfiguration.SecureOptions)
            {
                case "SSL":
                    options = MailKit.Security.SecureSocketOptions.SslOnConnect;
                    break;
                case "TLS":
                    options = MailKit.Security.SecureSocketOptions.StartTls;
                    break;
                case "TLSlight":
                    options = MailKit.Security.SecureSocketOptions.StartTlsWhenAvailable;
                    break;
                case "None":
                    options = MailKit.Security.SecureSocketOptions.None;
                    break;
                default:
                    options = MailKit.Security.SecureSocketOptions.Auto;
                    break;
            }

            //Gets the emailClient
            using (var emailClient = new MailKit.Net.Smtp.SmtpClient())
            {   
                //Connect with the SMTP Settings from Config File (Dependencie Injection)
                emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, options);

                //Remove OAuth Header
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

                //Authenticat with the Server with the Settings from Config File (Dependencie Injection)
                emailClient.Authenticate(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);

                //Sends the Smime Message
                emailClient.Send(message);

                //Logout from Server
                emailClient.Disconnect(true);
            }

        }
    }
}
