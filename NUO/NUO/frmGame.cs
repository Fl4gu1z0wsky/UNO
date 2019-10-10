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
                MainPlayer playerClass = new MainPlayer();
                IA1 IA1Class = new IA1();
                IA2 IA2Class = new IA2();
                IA3 IA3Class = new IA3();

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
        }
    }
}
