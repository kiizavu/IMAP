using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S22.Imap;
using System.Net;
using System.Net.Mail;

namespace IMAP
{
    public partial class Client : Form
    {
        int mov;
        int movX;
        int movY;

        static Client f;

        loadingForm loading;


        public Login log { get; set; } //Lấy dữ liệu của form Login

        protected static ImapClient client { get; set; }



        public Client()
        {
            InitializeComponent();
            f = this;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            loading = new loadingForm();
            loading.Show();
            CheckForIllegalCrossThreadCalls = false;
            client = new ImapClient("imap.gmail.com", 993, Login.user, Login.pass, AuthMethod.Login, true);
            
            Task.Run(() => getFolders());
            
            starReceiveMail();
        }


        private void getFolders()
        {
            this.Enabled = false;
            foreach (string m in client.ListMailboxes())
            {
                MailboxInfo info = client.GetMailboxInfo(m);
                listView1.Items.Add(info.Name);
            }
            loading.Close();
            this.Enabled = true;
        }



        private void starReceiveMail()
        {
            Task.Run(() =>
            {
                using (ImapClient clients = new ImapClient("imap.gmail.com", 993, Login.user, Login.pass, AuthMethod.Login, true))
                {
                    clients.NewMessage += new EventHandler<IdleMessageEventArgs>(OnNotifyMessage);
                    while (true) ;
                }
            });
        }

        static void OnNotifyMessage(object sender, IdleMessageEventArgs e)
        {
            MessageBox.Show("New mail received!", "Notification", MessageBoxButtons.OK);
            MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
            f.Invoke((MethodInvoker)delegate
            {
                f.richTextBox1.AppendText($"From: {m.From} \nSubject: {m.Subject}\nBody: {m.Body}\n");
            });
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            string folderSelected = listView1.SelectedItems[0].Text;
            listView2.Clear();
            IEnumerable<uint> uids = client.Search(SearchCondition.All(), folderSelected);
            IEnumerable<MailMessage> messages = client.GetMessages(uids, true, folderSelected);
            foreach (MailMessage m in messages)
                listView2.Items.Add("Subject: " + m.Subject);
        }
    }
}
