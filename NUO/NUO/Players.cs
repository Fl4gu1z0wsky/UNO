/**
 * \file      Players.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Class for the player.
 *
 * \details   This class create an object Player and give him a stack of cards. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO
{
    /// <summary>
    /// Create the player for the game
    /// </summary>
    public class Players
    {
        /// <summary>
        /// Constructor of the player
        /// </summary>
        public Players()
        {
            this.Cartes = new List<int>();
        }
        /// <summary>
        /// Destructor of the player
        /// </summary>
        ~Players()
        {

        }
        /// <summary>
        /// Constructor of the player with parameters
        /// </summary>
        /// <param name="pseudoPlayer">This is the pseudo in string</param>
        /// <param name="scorePlayer">This is the Score in int</param>
        public Players(string pseudoPlayer, int scorePlayer)
        { 
            Pseudo = pseudoPlayer;
            Score = scorePlayer;
            this.Cartes = new List<int>();
        }

        /// <summary>
        /// Pseudo of the player
        /// </summary>
        public string Pseudo { get; set; }
        /// <summary>
        /// Score of the player
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// List of cards
        /// </summary>
        public List<int> Cartes { get; set; }
        /// <summary>
        /// TIming of the player for playing
        /// </summary>
        public decimal Timing { get; set; }
    }
}
