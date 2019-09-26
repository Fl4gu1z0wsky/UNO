﻿using System;
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
    /// Form for the player to enter his name
    /// </summary>
    public partial class frmLaunch : Form
    {    
        /// <summary>
        /// Constructor
        /// </summary>
        public frmLaunch()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load of the form launch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Align labels, buttons, ...
            lblWelcome.Left = (this.ClientSize.Width - lblWelcome.Size.Width) / 2;
            picNUO.Left = (this.ClientSize.Width - picNUO.Size.Width) / 2;
            lblCreators.Left = (this.ClientSize.Width - lblCreators.Size.Width) / 2;
            lblFlavio.Left = (this.ClientSize.Width - lblFlavio.Size.Width) / 2;
            lblMauricio.Left = (this.ClientSize.Width - lblMauricio.Size.Width) / 2;
            lblCPNV.Left = (this.ClientSize.Width - lblCPNV.Size.Width) / 2;
            lblPseudo.Left = (this.ClientSize.Width - lblPseudo.Size.Width) / 2;
            txtPseudo.Left = (this.ClientSize.Width - txtPseudo.Size.Width) / 2;
            cmdVal.Left = (this.ClientSize.Width - cmdVal.Size.Width) / 2;
        }
        /// <summary>
        /// When the button cmdVal is clicked, it open the welcome form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdVal_Click(object sender, EventArgs e)
        {
            //We had the name of the player
            Program.playerName = txtPseudo.Text;
            this.Hide();
            frmWelcome form = new frmWelcome();
            form.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// When the enter key is pressed, it open the welcome form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxPseudo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                this.Hide();
                frmWelcome form = new frmWelcome();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
