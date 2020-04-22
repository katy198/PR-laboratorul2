using Limilabs.Client.IMAP;
using Limilabs.Mail;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2_IDWEB
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }


#pragma warning disable IDE1006 // Стили именования
        private void message_TextChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Стили именования
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Username = user.Text;
            Password = pass.Text;
            LogIn l = new LogIn();
            l.Show();

            using (var client = new ImapClient())
            {
                using (var cancel = new CancellationTokenSource())
                {
                    client.Connect("imap.gmail.com", 993, true, cancel.Token);
                    // If you want to disable an authentication mechanism,
                    // you can do so by removing the mechanism like this:
                    client.AuthenticationMechanisms.Remove("XOAUTH");
                    client.Authenticate(Username, Password, cancel.Token);

                        // The Inbox folder is always available...
                        var inbox = client.Inbox;
                        inbox.Open(FolderAccess.ReadOnly, cancel.Token);
                       
                        var b = inbox.Count.ToString();
                        var a = inbox.Recent.ToString();

                        StringBuilder sb = new StringBuilder();
                        // download each message based on the message index
                        for (int i = 1; i < inbox.Count; i++)
                        {
                            var message = inbox.GetMessage(i, cancel.Token);
                            Subjects.Items.Add(message.Subject + "   |   " + message.Date + "   |   " + message.From + "   |   " + message.TextBody);
                        }
                        client.Disconnect(true, cancel.Token);
                    
                }
            }

        }
        public static string Username;
        public static string Password;

#pragma warning disable IDE1006 // Стили именования
        private void textBox1_TextChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Стили именования
        {
        }
        public static string messages;
        public static string recentmessages;

#pragma warning disable IDE1006 // Стили именования
        private void richTextBox1_TextChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Стили именования
        {
        }

#pragma warning disable IDE1006 // Стили именования
        private void textBox2_TextChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Стили именования
        {

        }
#pragma warning disable IDE1006 // Стили именования
        private void button2_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Стили именования
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
#pragma warning disable IDE1006 // Стили именования
        private void pass_TextChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Стили именования
        {
            pass.PasswordChar = '●';
        }
        private void Subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var client = new ImapClient())
            {
                using (var cancel = new CancellationTokenSource())
                {
                    client.Connect("imap.gmail.com", 993, true, cancel.Token);
                    client.AuthenticationMechanisms.Remove("XOAUTH");
                    client.Authenticate(Username, Password, cancel.Token);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly, cancel.Token);
                    
                    var b = inbox.Count.ToString();
                    var a = inbox.Recent.ToString();
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i, cancel.Token);
                        listmess.Text = Subjects.SelectedItem.ToString();
                    } 
                    client.Disconnect(true, cancel.Token);
                }

            }
        }
    }
}


