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
    /// Form to explain the rules
    /// </summary>
    public partial class frmRulesExplanation : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public frmRulesExplanation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When the button cmdBack is clicked, it open the welcome form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRules form = new frmRules();
            form.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Load of the form eplanation's rule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRulesExplanation_Load(object sender, EventArgs e)
        {
            lblRules.Left = (this.ClientSize.Width - lblRules.Size.Width) / 2;
            cmdBack.Left = (this.ClientSize.Width - cmdBack.Size.Width) / 2;
            lblCPNV.Left = (this.ClientSize.Width - lblCPNV.Size.Width) / 2;
        }
    }
}
