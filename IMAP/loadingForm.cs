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
    public partial class loadingForm : Form
    {
        public loadingForm()
        {
            InitializeComponent();
            loadingProgress f = new loadingProgress();
            f.Show();
            this.Controls.Add(f);
            f.Location = new Point(96, 145);
        }
    }
}
