using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO
{
    public class Distributions
    {
        /// <summary>
        /// Constructor to distribute the cards to a player or an AI
        /// </summary>
        Random rand = new Random();
        public Distributions()
        {

        }
        /// <summary>
        /// Distribution for the player
        /// </summary>
        /// <param name="player">This is the player</param>
        /// <param name="selectedIdCard">This is the stack of cards</param>
        public void getDistributionPlayer(Players player, List<int> selectedIdCard)
        {
            do
            {
                int index = rand.Next(0, selectedIdCard.Count);
                player.Cartes.Add(selectedIdCard[index]);
                selectedIdCard.RemoveAt(index);
            } while (player.Cartes.Count < 7);
        }
        /// <summary>
        /// Distribution for the AI
        /// </summary>
        /// <param name="ia">This is the ai</param>
        /// <param name="selectedIdCard">This is the stack of cards</param>
        public void getDistributionIA(IA ia, List<int> selectedIdCard)
        {
            do
            {
                int index = rand.Next(0, selectedIdCard.Count);
                ia.Cartes.Add(selectedIdCard[index]);
                selectedIdCard.RemoveAt(index);
            } while (ia.Cartes.Count < 7);
        }
    }
}
