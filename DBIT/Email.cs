using System;
using System.Net.Mail;

namespace DBIT
{
    class Email
    {
        //properties
        public String EmailReceiver { set; get; }
        public String EmailHeader { set; get; }
        public String EmailBody { set; get; }

        public Email(String emailreceiver, String emailheader, String emailbody)
        {
            this.EmailReceiver = emailreceiver;
            this.EmailHeader = emailheader;
            this.EmailBody = emailbody;
        }

        public void Send()
        {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("in-v3.mailjet.com");//server name

                mail.From = new MailAddress("dragonballitemail@gmail.com");


                mail.To.Add(this.EmailReceiver);//logged in user email
                mail.Subject = this.EmailHeader;
                mail.IsBodyHtml = true;
                mail.Body = this.EmailBody;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("73ff8ceceaaf47a016b44a7bd8b905d5",//username
                                                                          "ea813bc70cd9f50796abedbeeef49345");//password
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
        }
    }
}
