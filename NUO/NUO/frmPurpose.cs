/**
 * \file      frmPurpose.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Form with the purpose.
 *
 * \details   This form explains the purpose of the game. 
 */
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
    /// Form explaining the game's purpose
    /// </summary>
    public partial class frmPurpose : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public frmPurpose()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load of the form purpose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurpose_Load(object sender, EventArgs e)
        {
            lblPurpose.Left = (this.ClientSize.Width - lblPurpose.Size.Width) / 2;
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
            frmRules form = new frmRules();
            form.ShowDialog();
            this.Close();
        }
    }
}
