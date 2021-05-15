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
using S22.Imap;
using System.Net;
using System.Net.Mail;

namespace IMAP
{
    public partial class Main : Form
    {
        int mov;
        int movX;
        int movY;

        CancellationTokenSource source = null;

        public Label From { get; }

        public Login log { get; set; } //Lấy dữ liệu của form Login

        protected static ImapClient client { get; set; }

        loadingProgress lP;

        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        /////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////Control button/////////////////////////////////////
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        /////////////////////////////////////////////////////////////////////////////////
        ////////////////////////// move form possition//////////////////////////////////
        private void _MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void _MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }


        /////////////////////////////////////////////////////////////////////////////////
        //////////////////////////button click//////////////////////////////////////////
        private void btnInbox_Click(object sender, EventArgs e)
        {
            btnInbox.selected = true;
            loadMails("INBOX");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnAll.selected = true;
            loadMails("[Gmail]/All Mail");
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            btnSent.selected = true;
            loadMails("[Gmail]/Sent Mail");
        }

        private void btnDrafts_Click(object sender, EventArgs e)
        {
            btnDrafts.selected = true;
            loadMails("[Gmail]/Drafts");
        }

        private void btnImportant_Click(object sender, EventArgs e)
        {
            btnImportant.selected = true;
            loadMails("[Gmail]/Important");
        }

        private void btnStarred_Click(object sender, EventArgs e)
        {
            btnStarred.selected = true;
            loadMails("[Gmail]/Starred");
        }

        private void btnSpam_Click(object sender, EventArgs e)
        {
            btnSpam.selected = true;
            loadMails("[Gmail]/Spam");
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            btnTrash.selected = true;
            loadMails("[Gmail]/Trash");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                client.Logout();
                this.Close();

                Thread t = new Thread(new ThreadStart(showLoginForm));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
        }



        /////////////////////////////////////////////////////////////////////////////////
        //////////////////////////Form load/////////////////////////////////////////////
        private void Main_Load(object sender, EventArgs e)
        {
            btnInbox.selected = true;
            client = new ImapClient("imap.gmail.com", 993, Login.user, Login.pass, AuthMethod.Login, true);
            lP = new loadingProgress();
            lP.Location = new Point(65, 790);
            Task.Run(() => loadMails("INBOX"));
        }



        /////////////////////////////////////////////////////////////////////////////////
        //////////////////////////Function//////////////////////////////////////////////
        private void loadMails(string folderName)
        {
            this.Invoke((MethodInvoker)delegate
            {
                pnlFolder.Controls.Add(lP);
                pnlContainer.Controls.Add(lbNoMail);
            });

            if (source != null)
            {
                source.Cancel();
                source.Dispose();
            }
            source = new CancellationTokenSource();
            var token = source.Token;

            //Set tilte for mail container
            if (folderName != "INBOX")
                lbTilte.Text = folderName.Substring(8, folderName.Length - 8);
            else
                lbTilte.Text = folderName;

            //Clear the mail container
            pnlContainer.Controls.Clear();

            //Get mail
            int i = 0;
            List <MailItem> mailItems = new List<MailItem>();
            Task.Run(() =>
            {
                IEnumerable<uint> uids = client.Search(SearchCondition.All(), folderName);
                foreach (uint uid in uids)
                {
                    using (MailMessage msg = client.GetMessage(uid, FetchOptions.Normal, true, folderName))
                    {
                        mailItems.Add(new MailItem());
                        mailItems[i].Dock = DockStyle.Top;

                        if (token.IsCancellationRequested)
                            break;
                        else
                            this.BeginInvoke((Action)(() =>
                            {
                                pnlContainer.Controls.Add(mailItems[i]);
                                mailItems[i].From.Text = msg.From.DisplayName;
                                mailItems[i].Date.Text = msg.Date().ToString();
                                mailItems[i].Subject.Text = msg.Subject;
                                mailItems[i++].Body.Text = msg.Body;
                            }));
                    }
                }
                if (uids.Count() != 0)
                    pnlContainer.Controls.Remove(lbNoMail);
                else
                    pnlContainer.Controls.Add(lbNoMail);
                pnlFolder.Controls.Remove(lP);
            }, token);
        }

        static private void showLoginForm()
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
