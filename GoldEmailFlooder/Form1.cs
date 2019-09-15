using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using System.Threading;

namespace GoldEmailFlooder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmailPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMailTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSender_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBody_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownSendAmmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonFlood_Click(object sender, EventArgs e)
        {


            buttonFlood.Enabled = false;
            buttonFlood.Text = "Flooding..";

            SmtpClient client = new SmtpClient();
            client.Timeout = 30000;
            client.AuthenticationMechanisms.Remove("XOAUTH2");

            client.Connect("smtp.gmail.com", 465);
            client.Authenticate(textBoxEmail.Text, textBoxEmailPassword.Text);

            for (int i = 0; i < numericUpDownSendAmmount.Value; i++)
            {
                BodyBuilder body = new BodyBuilder();
                body.HtmlBody = $"{textBoxBody.Text}{i}";

                MimeMessage mail = new MimeMessage();
                mail.Subject = $"{textBoxSubject.Text}{i}";
                mail.Body = body.ToMessageBody();

                mail.From.Add(new MailboxAddress($"{textBoxSender.Text}", $"{textBoxEmail.Text}"));
                mail.To.Add(new MailboxAddress($"{textBoxMailTo.Text}"));
                client.Send(mail);
                Thread.Sleep(5000);
            }
            client.Disconnect(true);
            buttonFlood.Enabled = true;
            buttonFlood.Text = "Flood";
        }
    }
}
