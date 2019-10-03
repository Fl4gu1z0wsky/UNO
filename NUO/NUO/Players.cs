using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO
{
    public class Players
    {
        public Players()
        {

        }

        public Players(string pseudoPlayer, int scorePlayer)
        { 
            Pseudo = pseudoPlayer;
            Score = scorePlayer;
        }

        public string Pseudo { get; set; }
        public int Score { get; set; }

    }
}
