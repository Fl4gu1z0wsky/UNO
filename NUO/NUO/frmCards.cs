/**
 * \file      frmCards.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Form with different Cards.
 *
 * \details   This form shows the differents cards from the UNO game. 
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
    /// Form that explains the various cards of the game
    /// </summary>
    public partial class frmCards : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public frmCards()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load of the form cards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCards_Load(object sender, EventArgs e)
        {
            lblCards.Left = (this.ClientSize.Width - lblCards.Size.Width) / 2;
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
