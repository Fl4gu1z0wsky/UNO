/**
 * \file      frmGame.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Form of the Game.
 *
 * \details   This is the form of the board game where the player can interact with the IA. 
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
    /// Form to show the game
    /// </summary>
    public partial class frmGame : Form
    {
        /// <summary>
        /// THe number of IA in the game selected by the player
        /// </summary>
        public int numberIA;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value"></param>
        public frmGame(int value)
        {
            InitializeComponent();

            //Get the choice of the user
            numberIA = value;
        }
        /// <summary>
        /// Load of the cards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGame_Load(object sender, EventArgs e)
        {
            
            Random rand = new Random();
            DBConnection nuoDB = new DBConnection();
            //Minimum number of players required (The others are created later)
            Players playerClass = new Players();
            IA IA1Class = new IA();  

            //-----CREATION OF THE STACK FOR THE CARDS-------
            //contains all ids of the DB
            List<int> pile = nuoDB.GetIdCards();            
            //contains the id card's selected randomly
            List<int> selectedIdCards = new List<int>();            
            //Peek id randomly en relation with the number of players
            for (int i = 1; i < (numberIA + 1) * 7 + 1; i++)
            {
                int index = rand.Next(0, pile.Count);
                selectedIdCards.Add(pile[index]);
                pile.RemoveAt(index);
            }
            //Test
            //MessageBox.Show(selectedIdCards.Count.ToString(), "Nombre de cartes", MessageBoxButtons.OK, MessageBoxIcon.Information);// --> Return 28 cards with numberIA = 3

            //contains the stack for the rest of the game
            List<int> savePile = new List<int>();
            int max = pile.Count;
            for (int i = 0; i < max; i++)
            {
                int index = rand.Next(0, pile.Count);
                savePile.Add(pile[index]);
                pile.RemoveAt(index);
            }
            //Test
            //MessageBox.Show(savePile.Count.ToString(), "Nombre de cartes", MessageBoxButtons.OK, MessageBoxIcon.Information);// --> Return 80 cards with numberIA = 3

            //Adding the cards in the tablelayout
            tableLayoutPanel1.Left = (this.ClientSize.Width - tableLayoutPanel1.Size.Width) / 2;
            tableLayoutPanel2.Left = (this.ClientSize.Width - tableLayoutPanel2.Size.Width) / 2;
            cmdCards.Left = ((this.ClientSize.Width - cmdCards.Size.Width) / 2) - 100;
            //Proprieties of the cards pile to pick up
            cmdCards.BackgroundImage = Properties.Resources.unoVersoVertical;
            cmdCards.BackgroundImageLayout = ImageLayout.Stretch;
            cmdCards.Cursor = Cursors.Hand;
            //We add a card to the player when he click on the stack
            cmdCards.Click += (s, f) => {
                int i = savePile.Count;
                playerClass.Cartes.Add(savePile[i - 1]);
                //Test
                //MessageBox.Show(playerClass.Cartes.Count.ToString(), "Nombre de cartes", MessageBoxButtons.OK, MessageBoxIcon.Information);// --> Return 80 cards with numberIA = 3
                //--> The player has 8 cards after picking up one more
                savePile.RemoveAt(i - 1);
                //Clearing the tableLayout in order not to have doubloons
                tableLayoutPanel1.Controls.Clear();
                //Creating new range of cards board of the mainplayer
                TablesLayout tables = new TablesLayout();
                tables.setTablesLayout(tableLayoutPanel1, playerClass, cmdCards);
                //If the player has 18 cards, he can't take anymore cards
                if(playerClass.Cartes.Count == 18)
                {
                    cmdCards.Enabled = false;
                }
                else
                {
                    cmdCards.Enabled = true;
                }
            };
            cmdCardPlayed.Left = ((this.ClientSize.Width - cmdCardPlayed.Size.Width) / 2) + 100;
            cmdCardPlayed.BackgroundImage = Properties.Resources._26;

            //-----DISTRIBUTION OF THE CARDS-------

            Distributions dist = new Distributions();
            TablesLayout table = new TablesLayout();

            do
            {
                dist.getDistributionPlayer(playerClass, selectedIdCards);

            } while (playerClass.Cartes.Count < 7);
            //Creating cards board of the mainplayer
            table.setTablesLayout(tableLayoutPanel1, playerClass, cmdCards);

            do
            {
                dist.getDistributionIA(IA1Class, selectedIdCards);

            } while (IA1Class.Cartes.Count < 7);
            //Creating cards board of the AI
            table.setTablesLayoutHorizontal(tableLayoutPanel2, IA1Class);

            if (numberIA == 2)
            {
                IA IA2Class = new IA();
                do
                {
                    dist.getDistributionIA(IA2Class, selectedIdCards);

                } while (IA2Class.Cartes.Count < 7);
                table.setTablesLayoutVertical(tableLayoutPanel3, IA2Class);
            }
            else if (numberIA == 3)
            {
                IA IA2Class = new IA();
                do
                {
                    dist.getDistributionIA(IA2Class, selectedIdCards);

                } while (IA2Class.Cartes.Count < 7);
                table.setTablesLayoutVertical(tableLayoutPanel3, IA2Class);

                IA IA3Class = new IA();
                do
                {
                    dist.getDistributionIA(IA3Class, selectedIdCards);

                } while (IA3Class.Cartes.Count < 7);
                table.setTablesLayoutVertical(tableLayoutPanel4, IA3Class);
            }
        }
    }
}
