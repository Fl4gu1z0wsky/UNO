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
