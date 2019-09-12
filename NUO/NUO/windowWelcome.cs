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
    public partial class windowWelcome : Form
    {
        public windowWelcome(string value)
        {
            InitializeComponent();
            lblBvn.Text = lblBvn.Text + " " + value;
        }

        private void windowWelcome_Load(object sender, EventArgs e)
        {
            //Alignement au centre des différents labels, boutons, ...
            picNUO.Left = (this.ClientSize.Width - picNUO.Size.Width) / 2;
            lblBvn.Left = (this.ClientSize.Width - lblBvn.Size.Width) / 2;
            cmdPartie.Left = (this.ClientSize.Width - cmdPartie.Size.Width) / 2;
            cmdScores.Left = (this.ClientSize.Width - cmdScores.Size.Width) / 2;
            cmdRegles.Left = (this.ClientSize.Width - cmdRegles.Size.Width) / 2;
            lblCPNV.Left = (this.ClientSize.Width - lblCPNV.Size.Width) / 2;

        }
    }
}
