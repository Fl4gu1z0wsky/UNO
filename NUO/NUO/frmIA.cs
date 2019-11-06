/**
 * \file      frmIA.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Form with AI.
 *
 * \details   This form let the player chose how many AI he can play against. 
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
    /// The player enter the number of IA to play against
    /// </summary>
    public partial class frmIA : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public frmIA()
        {
            InitializeComponent();

            //Add items in the cboBox and select the first item by default
            cboNumberIA.Items.Add(1);
            cboNumberIA.Items.Add(2);
            cboNumberIA.Items.Add(3);
            cboNumberIA.SelectedIndex = 0;
        }
        /// <summary>
        /// When clicked, open the frmGame to play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdValidation_Click_1(object sender, EventArgs e)
        {
            frmGame frmWindowGame = new frmGame(Convert.ToSByte(cboNumberIA.SelectedItem));
            frmWindowGame.FormClosed += new FormClosedEventHandler(frmIA_FormClosed);
            frmWindowGame.Show();
            this.Hide();
        }
        /// <summary>
        /// Close the frmIA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmIA_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


    }
}
