using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO
{
    /// <summary>
    /// Create the ai's for the game
    /// </summary>
    public class IA
    {
        private List<int> cartes; /* Attributs */
        private string pseudo;
        private int score;
        private decimal timing;
        /// <summary>
        /// Constructor of the ai
        /// </summary>
        public IA()
        {
            this.Cartes = new List<int>();
        }
        /// <summary>
        /// Destructor of the ai
        /// </summary>
        ~IA()
        {

        }
        public List<int> Cartes /* Propriété */
        {
            get 
            {
                return cartes;
            }
            set 
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
