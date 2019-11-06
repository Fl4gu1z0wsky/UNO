/**
 * \file      TablesLayout.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Class for the tableLayout.
 *
 * \details   This class create an object TableLayout se the cards are well brought
 * on the board game for the player and the AI's. 
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
    /// Initiate what is inside the tablelayout on the frmgame
    /// </summary>
    public class TablesLayout
    {
        /// <summary>
        /// Constructor of TablesLayout
        /// </summary>
        public TablesLayout()
        {

        }
        /// <summary>
        /// Destructor of TablesLayout
        /// </summary>
        ~TablesLayout()
        {

        }
        /// <summary>
        /// Add cards on the tablelayoutpanel for the player
        /// </summary>
        /// <param name="table">This is a TableLayoutPanel</param>
        /// <param name="player">This is the MainPlayer</param>
        public void setTablesLayout(TableLayoutPanel table, Players player)
        {           
            CardsOnBoards buttonsCard = new CardsOnBoards();
            buttonsCard.AddBUttons(table, player);
            this.ArrangeTableLayout(table);
        }
        /// <summary>
        /// Add cards on the tablelayoutpanel horizontaly for an ai
        /// </summary>
        /// <param name="table">This is a TableLayoutPanel</param>
        /// <param name="ai">This is an ai</param>
        public void setTablesLayoutHorizontal(TableLayoutPanel table, IA ai)
        {
            CardsOnBoards buttonsCard = new CardsOnBoards();
            buttonsCard.AddCardsIAHorizontal(table, ai);
            this.ArrangeTableLayout(table);
        }
        /// <summary>
        /// Add cards on the tablelayoutpanel verticaly for an ai
        /// </summary>
        /// <param name="table">This is a TableLayoutPanel</param>
        /// <param name="ai">This is an ai</param>
        public void setTablesLayoutVertical(TableLayoutPanel table, IA ai)
        {
            CardsOnBoards buttonsCard = new CardsOnBoards();
            buttonsCard.AddCardsIAVertical(table, ai);
            this.ArrangeTableLayout(table);
        }
        /// <summary>
        /// Clear and arrange the tableLayoutPanel to add the cards
        /// </summary>
        /// <param name="table">This is a TableLayoutPanel</param>
        private void ArrangeTableLayout(TableLayoutPanel table)
        {
            table.ColumnStyles.Clear();
            for (int i = 0; i < table.ColumnCount; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            table.RowStyles.Clear();
            for (int i = 0; i < table.RowCount; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }
    }
}
