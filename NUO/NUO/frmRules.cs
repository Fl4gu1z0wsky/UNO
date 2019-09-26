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
    /// Form to show the rules
    /// </summary>
    public partial class frmRules : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public frmRules()
        {            
            InitializeComponent();
        }
        /// <summary>
        /// Load of the form rules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRules_Load(object sender, EventArgs e)
        {
            //Align labels, buttons, ...
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;
            cmdCards.Left = (this.ClientSize.Width - cmdCards.Size.Width) / 2;
            cmdJoker.Left = (this.ClientSize.Width - cmdJoker.Size.Width) / 2;
            cmdPurpose.Left = (this.ClientSize.Width - cmdPurpose.Size.Width) / 2;
            cmdRules.Left = (this.ClientSize.Width - cmdRules.Size.Width) / 2;
            cmdBack.Left = (this.ClientSize.Width - cmdBack.Size.Width) / 2;
            lblCPNV.Left = (this.ClientSize.Width - lblCPNV.Size.Width) / 2;
        }
        /// <summary>
        /// When the button cmdPurpose is clicked, it open the purpose form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPurpose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPurpose form = new frmPurpose();
            form.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// When the button cmdBack is clicked, it open the welcome form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome form = new frmWelcome();
            form.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// When the button cmdCards is clicked, it open the cards form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCards_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCards form = new frmCards();
            form.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// When the button cmdJoker is clicked, it open the joker form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdJoker_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJoker form = new frmJoker();
            form.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// When the button cmdRules is clicked, it open the rules explanation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRules_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRulesExplanation form = new frmRulesExplanation();
            form.ShowDialog();
            this.Close();
        }
    }
}
