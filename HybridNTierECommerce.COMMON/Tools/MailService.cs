using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.COMMON.Tools
{
    public static class MailService
    {
        public static void Send(string receiver, string password = "app key from gmail", string body = "Test Message", string subject = "Email Test", string sender = "senderemail from gmail")
        {
            MailAddress senderEmail = new(sender);
            MailAddress receiverEmail = new(receiver);

            SmtpClient smtp = new()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };

            using (MailMessage message = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
