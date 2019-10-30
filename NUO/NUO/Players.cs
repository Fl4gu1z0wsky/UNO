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

        public string Pseudo { get; set; }
        public int Score { get; set; }
        public List<int> Cartes { get; set; }
        public decimal Timing { get; set; }
    }
}
