/**
 * \file      frmScores.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Form with the scores.
 *
 * \details   This form shows the 10 best scores. 
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
    /// Form of the scores
    /// </summary>
    public partial class frmScores : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public frmScores()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Show the table of scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmScores_Load(object sender, EventArgs e)
        {
            lblScores.Left = (this.ClientSize.Width - lblScores.Size.Width) / 2;
            cmdBack.Left = (this.ClientSize.Width - cmdBack.Size.Width) / 2;
            lblCPNV.Left = (this.ClientSize.Width - lblCPNV.Size.Width) / 2;

            //We display the pseudo and scores in an array and put it on a label
            lblArrayPlayer.Text = "";
            lblArrayScore.Text = "";
            //Declaration and instanciation of a new DBConnection
            DBConnection sqliteConn = new DBConnection();
            //Insertion of the new player's name
            int i = 1;
            List<Players> read = sqliteConn.ReadDataPlayer();
            foreach(Players user in read)
            {
                //To align scores
                int count = user.Pseudo.Length - user.Score.ToString().Length;
                lblArrayPlayer.Text += i + ". " + user.Pseudo + "\n";
                lblArrayScore.Text += user.Score + "\n";
                i++;
            }
            //DB connection close
            sqliteConn.Close();

            //And we put the label in the middle
            lblArrayPlayer.Left = ((this.ClientSize.Width - lblArrayPlayer.Size.Width) / 2) - 50;
            lblArrayScore.Left = ((this.ClientSize.Width - lblArrayScore.Size.Width) / 2) + 130;
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
