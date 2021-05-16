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

namespace IMAP
{
    public partial class Login : Form
    {

        int mov;
        int movX;
        int movY;

        public static string user;
        public static string pass;


        protected static ImapClient client { get; set; }

        public Login()
        {
            InitializeComponent();
            initData();
        }




        // move form possition
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }


        //login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Initialize();
        }


        private void tbUP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Initialize();
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        public void Initialize()
        {
            user = tbUser.Text;
            pass = tbPass.Text;
            client = new ImapClient("imap.gmail.com", 993, true);

            //check username, password
            try
            {
                client.Login(user, pass, AuthMethod.Auto);
            }
            catch
            {
                MessageBox.Show("Username or Password is incorrect!!!\nPlease try again.",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Checked();
            Main c = new Main();
            c.log = this; //Truyền dữ liệu bên này qua cho bên kia
            new Thread(() => new Main().ShowDialog()).Start();
            this.Close();
        }



        //Save username, password if click remme
        public void initData()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remme == "yes")
                {
                    tbUser.Text = Properties.Settings.Default.UserName;
                    tbPass.Text = Properties.Settings.Default.Password;
                    cbRemember.Checked = true;
                }
                else
                {
                    tbUser.Text = Properties.Settings.Default.UserName;
                    tbPass.Text = "";
                }
            }
        }


        //Kiểm tra đã đánh dấu Remmeber me chưa ?
        public void Checked()
        {
            if (!cbRemember.Checked)
            {
                Properties.Settings.Default.UserName = tbUser.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remme = "no";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = tbUser.Text;
                Properties.Settings.Default.Password = tbPass.Text;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();
            }
        }
    }
}
