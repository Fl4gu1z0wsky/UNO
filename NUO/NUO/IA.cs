/**
 * \file      IA.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Class for the AI.
 *
 * \details   This class create an object IA and give him a stack of cards. 
 */
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
        public List<int> Cartes { get; set; }
        public string Pseudo { get; set; }
        public int Score { get; set; }
        public decimal Timing { get; set; }
    }
}
