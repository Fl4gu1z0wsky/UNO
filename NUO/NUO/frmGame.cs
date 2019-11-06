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
            Players playerClass = new Players();
            IA IA1Class = new IA();
            IA IA2Class = new IA();
            IA IA3Class = new IA();

            //contains all ids of the DB
            List<int> pile = nuoDB.GetIdCards();
            
            //contains the id card's selected randomly
            List<int> selectedIdCards = new List<int>();

            //contains the stack for the rest of the game
            List<int> savePile = pile;

            //Peek id randomly en relation with the number of players
            for (int i = 1; i < (numberIA + 1) * 7 + 1; i++)
            {
                int index = rand.Next(0, pile.Count);
                selectedIdCards.Add(pile[index]);
                pile.RemoveAt(index);
            }

            //Deliver 7 ids card to each player contained in the list selectedIdCards
            while (selectedIdCards.Count() != 0)
            { 
                do
                {

                    int index = rand.Next(0, selectedIdCards.Count);
                    playerClass.Cartes.Add(selectedIdCards[index]);
                    selectedIdCards.RemoveAt(index);

                } while (playerClass.Cartes.Count < 7);


                do
                {

                    int index = rand.Next(0, selectedIdCards.Count);
                    IA1Class.Cartes.Add(selectedIdCards[index]);
                    selectedIdCards.RemoveAt(index);

                } while (IA1Class.Cartes.Count < 7);


                if (selectedIdCards.Count > 0)
                {
                    do
                    {

                        int index = rand.Next(0, selectedIdCards.Count);
                        IA2Class.Cartes.Add(selectedIdCards[index]);
                        selectedIdCards.RemoveAt(index);

                    } while (IA2Class.Cartes.Count < 7);
                }

                if (selectedIdCards.Count > 0)
                {
                    do
                    {

                        int index = rand.Next(0, selectedIdCards.Count);
                        IA3Class.Cartes.Add(selectedIdCards[index]);
                        selectedIdCards.RemoveAt(index);

                    } while (IA3Class.Cartes.Count < 7);

                }
            }
            //Adding the cards in the tablelayout
            tableLayoutPanel1.Left = (this.ClientSize.Width - tableLayoutPanel1.Size.Width) / 2;
            tableLayoutPanel2.Left = (this.ClientSize.Width - tableLayoutPanel2.Size.Width) / 2;
            cmdCards.Left = ((this.ClientSize.Width - cmdCards.Size.Width) / 2) - 100;
            //Proprieties of the cards pile to pick up
            cmdCards.BackgroundImage = Properties.Resources.unoVersoVertical;
            cmdCards.BackgroundImageLayout = ImageLayout.Stretch;
            cmdCards.Cursor = Cursors.Hand;
            cmdCardPlayed.Left = ((this.ClientSize.Width - cmdCardPlayed.Size.Width) / 2) + 100;
            cmdCardPlayed.BackgroundImage = Properties.Resources._26;
            TablesLayout table = new TablesLayout();
            //Creating cards board of the mainplayer
            table.setTablesLayout(tableLayoutPanel1, playerClass);
            //Creating cards board of the AI
            table.setTablesLayoutHorizontal(tableLayoutPanel2, IA1Class);
            table.setTablesLayoutVertical(tableLayoutPanel3, IA2Class);
            table.setTablesLayoutVertical(tableLayoutPanel4, IA3Class);
        }
    }
}
