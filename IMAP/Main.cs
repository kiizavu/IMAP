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
    public partial class Main : Form
    {
        int mov;
        int movX;
        int movY;

        public Main()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            loadMailItems();
            loadingProgress loading = new loadingProgress();
            loading.Location = new Point(65, 790);
            pnlFolder.Controls.Add(loading);
        }

        // move form possition
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


        private void loadMailItems()
        {
            MailItem[] mailItems = new MailItem[2];
            pnlContainer.Controls.Clear();
            for (int i = 0; i < 2; i++)
            {
                mailItems[i] = new MailItem();
                mailItems[i].Dock = DockStyle.Top;
                pnlContainer.Controls.Add(mailItems[i]);
            }
        }
    }
}
