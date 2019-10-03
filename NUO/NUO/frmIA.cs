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
    public partial class frmIA : Form
    {




        public frmIA()
        {
            InitializeComponent();

            //Ajout des items dans la combox + sélection du premier item par défaut
            cboNumberIA.Items.Add(1);
            cboNumberIA.Items.Add(2);
            cboNumberIA.Items.Add(3);
            cboNumberIA.SelectedIndex = 0;
        }

        private void cmdValidation_Click_1(object sender, EventArgs e)
        {
            frmGame frmWindowGame = new frmGame(Convert.ToSByte(cboNumberIA.SelectedItem));
            frmWindowGame.FormClosed += new FormClosedEventHandler(frmIA_FormClosed);
            frmWindowGame.Show();
            this.Hide();
        }

        private void frmIA_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


    }
}
