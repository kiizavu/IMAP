using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMAP
{
    public partial class MailItem : UserControl
    {
        public Main main { get; set; }

        public MailItem()
        {
            InitializeComponent();
        }

        public Label Uid
        {
            get { return this.lbUid; }
        }

        public Label From
        {
            get { return this.lbFrom; }
        }

        public Label MailAddress
        {
            get { return this.lbMailAddress; }
        }

        public Label Subject
        {
            get { return this.lbSubject; }
        }

        public Label Date
        {
            get { return this.lbDate; }
        }

        public Label Body
        {
            get { return this.lbBody; }
        }

        public Label UnSeen
        {
            get { return this.lbUnSeen; }
        }


        private void MailItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(110, 110, 110);
        }

        private void MailItem_MouseLeave(object sender, EventArgs e)
        {
            if (lbUnSeen.Text == "True")
                this.BackColor = Color.FromArgb(59, 72, 77);
            else
                this.BackColor = Color.FromArgb(46, 52, 57);
        }

        public void MailItem_Click(object sender, EventArgs e)
        {
            if (lbUnSeen.Text == "True")
            {
                lbUnSeen.Text = "False";
                this.BackColor = Color.FromArgb(46, 52, 57);
                main.client.SetMessageFlags(uint.Parse(lbUid.Text), null, 0);
            }
            main.From.Clear();
            main.From.SelectionFont = new Font(main.From.Font, FontStyle.Bold);
            main.From.AppendText(lbFrom.Text);
            main.From.SelectionFont = new Font("Times New Roman", 12, FontStyle.Regular);
            main.From.AppendText("<" + lbMailAddress.Text + ">");
            setViEnTrue(main.From);

            main.Subject.Text = lbSubject.Text;
            setViEnTrue(main.Subject);

            main.Date.Text = lbDate.Text;
            setViEnTrue(main.Date);

            main.Body.Text = lbBody.Text;
            setViEnTrue(main.Body);

            setViEnTrue(main.Attachment);

            main.NoMailSelected.Visible = false;
            main.NoMailSelected.Enabled = false;
        }

        private void setViEnTrue(Label lb)
        {
            lb.Visible = true;
            lb.Enabled = true;
        }

        private void setViEnTrue(RichTextBox rtb)
        {
            rtb.Visible = true;
            rtb.Enabled = true;
        }
    }
}
