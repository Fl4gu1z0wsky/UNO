using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUO
{
    public partial class windowLaunch : Form
    {
        public windowLaunch()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Alignement au centre des différents labels, boutons, ...
            lblBvn.Left = (this.ClientSize.Width - lblBvn.Size.Width) / 2;
            picNUO.Left = (this.ClientSize.Width - picNUO.Size.Width) / 2;
            lblCreateurs.Left = (this.ClientSize.Width - lblCreateurs.Size.Width) / 2;
            lblFlavio.Left = (this.ClientSize.Width - lblFlavio.Size.Width) / 2;
            lblMauricio.Left = (this.ClientSize.Width - lblMauricio.Size.Width) / 2;
            lblCPNV.Left = (this.ClientSize.Width - lblCPNV.Size.Width) / 2;
            lblPseudo.Left = (this.ClientSize.Width - lblPseudo.Size.Width) / 2;
            txtBoxPseudo.Left = (this.ClientSize.Width - txtBoxPseudo.Size.Width) / 2;
            cmdValPseudo.Left = (this.ClientSize.Width - cmdValPseudo.Size.Width) / 2;
        }

        private void cmdValPseudo_Click(object sender, EventArgs e)
        {
            this.Hide();
            windowWelcome form = new windowWelcome(txtBoxPseudo.Text);
            form.ShowDialog();
            this.Close();
        }

        private void txtBoxPseudo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                this.Hide();
                windowWelcome form = new windowWelcome(txtBoxPseudo.Text);
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
