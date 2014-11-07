using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Windows.Forms;

namespace hotel
{
    public class Email
    {
        public void otpravka(string email,  string login, string pas, DateTime data, string fio, string nomer,int cena,string hotel,string schet)
        {
            try
            {
                SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 25);
                Smtp.Credentials = new NetworkCredential(login, pas);
                MailMessage Message = new MailMessage();
                Message.From = new MailAddress(login);//от кого
                Message.To.Add(new MailAddress(email));//кому
                Message.Subject = "Счет о предоплате брони " ;
                Message.Body = "Уважаемый " + fio + "  отель "+ hotel+"  напоминает о предоплате брони за "+  data+ "  в размере "+cena+" на счет" + schet;
                Smtp.Send(Message);
            }
            catch { MessageBox.Show("Сбой при отправке сообщения электронной почты."); }
        }
    }
}
