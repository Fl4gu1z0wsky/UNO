/**
 * \file      Program.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Main class of the program.
 *
 * \details   This class launch the game. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUO
{
    /// <summary>
    /// The main program to launch the game
    /// </summary>
    static class Program
    {
        //We keep the name of the player for the other forms
        public static string playerName;

        /// <summary>
        /// Principal entry point of the app
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLaunch());
        }
    }
}
