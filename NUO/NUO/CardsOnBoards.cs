﻿/**
 * \file      CardsOnBoards.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Class to put the cards on the board game.
 *
 * \details   This class create an object CardsonBoards and put the differents cards of the player
 * and the AI on the board. 
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
    /// Add the cards on the tableLayoutPanel
    /// </summary>
    public class CardsOnBoards
    {
        /// <summary>
        /// Creator of CardsOnBoards
        /// </summary>
        public CardsOnBoards()
        {

        }
        /// <summary>
        /// Destructor of CardsOnBoards
        /// </summary>
        ~CardsOnBoards()
        {

        }
        /// <summary>
        /// Add the cards on the tableLayout of the MainPlayer
        /// </summary>
        /// <param name="table">This is a TableLayoutPanel</param>
        /// <param name="player">This is the MainPlayer</param>
        public void AddBUttons(TableLayoutPanel table, Players player, Button activate)
        {
            table.ColumnCount = 9;
            table.RowCount = 2;
            for (int i = 0; i < player.Cartes.Count; i++)
            {
                ImageList imagelist1 = new ImageList();
                imagelist1.ImageSize = new Size(81, 124);
                string from = "Images/" + player.Cartes[i] + ".png";
                imagelist1.Images.Add(Image.FromFile(from));
                //We create the button with the image of the card inside
                //And we add the event click that send the id of the card
                Button cmdImage = new Button();
                cmdImage.Click += (s, e) => {
                    Verifications verif = new Verifications();
                    MessageBox.Show(player.Cartes[0].ToString(), "Index", MessageBoxButtons.OK, MessageBoxIcon.Information);// --> Return un nb between 0 and 17
                    verif.verificationCard(player.Cartes[0]);                  
                    //If the player has 18 cards, he can't take anymore cards
                    if (player.Cartes.Count < 18)
                    {
                        activate.Enabled = true;
                    }
                    else
                    {
                        activate.Enabled = false;
                    }
                };
                cmdImage.BackgroundImage = imagelist1.Images[0];
                cmdImage.Text = "";
                cmdImage.Size = new Size(81, 124);
                cmdImage.Anchor = AnchorStyles.None;
                cmdImage.Cursor = Cursors.Hand;
                if (i >= 9)
                {
                    table.Controls.Add(cmdImage, (i - 9), 1);
                }
                else
                {
                    table.Controls.Add(cmdImage, i, 0);
                }
            }
        }
        /// <summary>
        /// Add the cards on the tableLayoutVertical of an ai
        /// </summary>
        /// <param name="table">This is a TableLayoutPanel</param>
        /// <param name="ai">This is an ai</param>
        public void AddCardsIAVertical(TableLayoutPanel table, IA ai)
        {
            table.ColumnCount = 2;
            table.RowCount = 9;
            for (int i = 0; i < ai.Cartes.Count; i++)
            {
                Button cmdImage = new Button();
                cmdImage.BackgroundImage = Properties.Resources.unoVersoHorizontal;
                cmdImage.BackgroundImageLayout = ImageLayout.Stretch;
                cmdImage.Text = "";
                cmdImage.Size = new Size(124, 81);
                cmdImage.Anchor = AnchorStyles.None;
                cmdImage.Enabled = false;
                if (i >= 9)
                {
                    table.Controls.Add(cmdImage, 1, (i - 9));
                }
                else
                {
                    table.Controls.Add(cmdImage, 0, i);
                }
            }
        }
        /// <summary>
        /// Add the cards on the tableLayoutHorizontal of an ai
        /// </summary>
        /// <param name="table">This is a TableLayoutPanel</param>
        /// <param name="ai">This is an ai</param>
        public void AddCardsIAHorizontal(TableLayoutPanel table, IA ai)
        {
            table.ColumnCount = 9;
            table.RowCount = 2;
            for (int i = 0; i < ai.Cartes.Count; i++)
            {
                Button cmdImage = new Button();
                cmdImage.BackgroundImage = Properties.Resources.unoVersoVertical;
                cmdImage.BackgroundImageLayout = ImageLayout.Stretch;
                cmdImage.Text = "";
                cmdImage.Size = new Size(81, 124);
                cmdImage.Anchor = AnchorStyles.None;
                cmdImage.Enabled = false;
                if (i >= 9)
                {
                    table.Controls.Add(cmdImage, (i - 9), 1);
                }
                else
                {
                    table.Controls.Add(cmdImage, i, 0);
                }
            }
        }
    }
}
