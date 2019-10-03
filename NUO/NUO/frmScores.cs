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
    public partial class frmScores : Form
    {
        public frmScores()
        {
            InitializeComponent();
        }

        private void frmScores_Load(object sender, EventArgs e)
        {
            lblScores.Left = (this.ClientSize.Width - lblScores.Size.Width) / 2;
            cmdBack.Left = (this.ClientSize.Width - cmdBack.Size.Width) / 2;
            lblCPNV.Left = (this.ClientSize.Width - lblCPNV.Size.Width) / 2;
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
    }
}
