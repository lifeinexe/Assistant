using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assistant
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        static void SendMessage(string userName, string adressTo, string messageSubject, string messageText)
        {
            try
            {
                string from = @"assistantomsk20@gmail.com"; // адреса отправителя
                string pass = "bruh228228"; // пароль отправителя
                MailMessage mess = new MailMessage();
                mess.To.Add(adressTo); // адрес получателя
                mess.From = new MailAddress(from);
                mess.Subject = messageSubject; // тема
                mess.Body = messageText; // текст сообщения
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com"; //smtp-сервер отправителя
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], pass);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mess); // отправка пользователю
                mess.SubjectEncoding = Encoding.UTF8;
                mess.To.Remove(mess.To[0]);
                mess.To.Add(from); //для сообщения на свой адрес
                mess.Subject = "Assistant | Баг репорт";
                mess.Body = "От: " + userName + " отправлено сообщение: " + messageText;
                client.Send(mess); // отправка себе
                mess.Dispose();
                MessageBox.Show("Сообщение отправлено! Спасибо за обратную связь.");
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string userName = nameTextbox.Text; //имя пользователя
            string adressTo = emailTextbox.Text; //адрес пользователя
            string messageSubject = "Баг репорт"; //тема
            string messageText = messageTextbox.Text; //текст
            SendMessage(userName, adressTo, messageSubject, messageText);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
