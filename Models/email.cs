using System;
using System.Net.Mail;
using System.Windows.Forms;
namespace Controllers
{
    public class email
    {

        public void enviarEmail()
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("potulskdeveloper@gmail.com", "guPutu123");
                smtpClient.EnableSsl = true;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("mateusantomar@gmail.com"),
                    Subject = "subject",
                    Body = "<h1>Hello</h1>",
                    IsBodyHtml = true,
                };
                mailMessage.To.Add("mateusantomar@gmail.com");

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}