using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO
{
    class IA2
    {
        private List<int> cartes; /* Attributs */
        private string pseudo;
        private int score;
        private decimal timing;

        public IA2() /* constructeur de base */
        {
            this.Cartes = new List<int>();
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
