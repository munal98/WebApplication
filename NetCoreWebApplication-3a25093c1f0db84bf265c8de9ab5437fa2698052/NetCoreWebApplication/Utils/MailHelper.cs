using Entities;
using System;
using System.Net;
using System.Net.Mail;

namespace NetCoreWebApplication.Utils
{
    public class MailHelper
    {
        public static bool SendMail(Contact contact)
        {
            try
            {
                SmtpClient client = new SmtpClient("mail.siteadi.com", 587);
                client.Credentials = new NetworkCredential("email kullanıcı adı","email şifre");
                //client.EnableSsl = true; eğer mailde ssl kullanılıyorsa burayı aç
                MailMessage message = new MailMessage();
                message.From = new MailAddress("info@siteadi.com");
                message.To.Add("mesajingidecegiadres@siteadi.com");
                message.Subject = "Siteden mesaj var";
                message.Body = $"<p>Mesaj Bilgileri; <hr /> İsim : {contact.Name} <hr /> Email : {contact.Email}<hr /> Telefon : {contact.Phone}<hr /> Mesaj : {contact.Message}<hr /> Mesaj Tarihi : {contact.CreateDate}</p>";
                message.IsBodyHtml = true;

                client.Send(message);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
