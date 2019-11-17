/**
 * \file      Cards.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Class for Cards.
 *
 * \details   This class create an object Cards and put the informations of the db in it. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO
{
    /// <summary>
    /// It's the card that contains the element from the database
    /// </summary>
    public class Cards
    {
        /// <summary>
        /// Constructor of cards
        /// </summary>
        public Cards()
        {

        }
        /// <summary>
        /// Constructor of cards with parameters
        /// </summary>
        /// <param name="idCard">id of the card in int</param>
        /// <param name="colorCard">color from Colors</param>
        /// <param name="valueCard">value from Values</param>
        public Cards(int idCard, int colorCard, int valueCard)
        {
            Id = idCard;
            Color = colorCard;
            Value = valueCard;
        }
        //Get set to manage the cards informations
        /// <summary>
        /// Id of the cards
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Color of the card
        /// </summary>
        public int Color { get; set; }
        /// <summary>
        /// Value of the card
        /// </summary>
        public int Value { get; set; }

    }
}
