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
    /// <summary>
    /// Form with button to give more access to the game for the player
    /// </summary>
    public partial class frmWelcome : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public frmWelcome()
        {
            InitializeComponent();
            frmLaunch window = new frmLaunch();
            lblBvn.Text = lblBvn.Text + " " + Program.playerName;
        }
        /// <summary>
        /// Load of the form welcome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void windowWelcome_Load(object sender, EventArgs e)
        {
            //Align labels, buttons, ...
            picNUO.Left = (this.ClientSize.Width - picNUO.Size.Width) / 2;
            lblBvn.Left = (this.ClientSize.Width - lblBvn.Size.Width) / 2;
            cmdGame.Left = (this.ClientSize.Width - cmdGame.Size.Width) / 2;
            cmdScores.Left = (this.ClientSize.Width - cmdScores.Size.Width) / 2;
            cmdRules.Left = (this.ClientSize.Width - cmdRules.Size.Width) / 2;
            lblCPNV.Left = (this.ClientSize.Width - lblCPNV.Size.Width) / 2;

        }
        /// <summary>
        /// When the button cmdRules is clicked, it open the rules form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRules_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRules form = new frmRules();
            form.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// When the button cmdScores is clicked, it open the scores form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdScores_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScores form = new frmScores();
            form.ShowDialog();
            this.Close();
        }
    }
}
