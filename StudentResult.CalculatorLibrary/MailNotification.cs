using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace StudentResult.CalculatorLibrary
{

    public interface INotification
    {
        void Notify(string msg);
    }

    public class MailNotification : INotification
    {
        public void Notify(string msg)
        {
            // write a code to send email
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "mail server address";
            smtpClient.Port = 234234;
            //MailAddress mailAddress = new MailAddress("from@mail.com", "to@mail.com");
            MailMessage message = new MailMessage("from@mail.com", "to@mail.com");
            message.Subject = "Result";
            message.Body = "Your result is " + msg;
            smtpClient.Send(message);
        }
    }
}
