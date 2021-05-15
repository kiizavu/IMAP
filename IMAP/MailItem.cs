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

        public MailItem()
        {
            InitializeComponent();
        }

        public Label From
        {
            get { return this.lbFrom; }
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


        private void MailItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(110, 110, 110);
        }

        private void MailItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(46, 52, 57);
        }
    }
}
