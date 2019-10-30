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
    /// Form to explain joker's cards
    /// </summary>
    public partial class frmJoker : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public frmJoker()
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
        /// Load of the form jokers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmJoker_Load(object sender, EventArgs e)
        {
            lblJoker.Left = (this.ClientSize.Width - lblJoker.Size.Width) / 2;
            cmdBack.Left = (this.ClientSize.Width - cmdBack.Size.Width) / 2;
            lblCPNV.Left = (this.ClientSize.Width - lblCPNV.Size.Width) / 2;
        }
    }
}
