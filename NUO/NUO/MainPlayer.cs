using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO
{
    /// <summary>
    /// Create the main player for the game
    /// </summary>
    public class MainPlayer
    {
        private List<int> cartes; /* Attributs */
        private string pseudo;
        private int score;
        private decimal timing;
        /// <summary>
        /// Constructor of the mainPlayer
        /// </summary>
        public MainPlayer() /* constructeur de base */
        {
            this.Cartes = new List<int>();
        }
        public List<int> Cartes /* Propriété */
        {
            get /* permet la lecture uniquement*/
            {
                return cartes;
            }
            set /*permet la modification uniquement*/
            {
                cartes = value;
            }
        }

        public string Pseudo
        {
            get
            {
                return pseudo;
            }
            set
            {
                pseudo = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public decimal Timing
        {
            get
            {
                return timing;
            }

        }
    }
}
