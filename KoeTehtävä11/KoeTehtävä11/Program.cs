using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
/*
Tee Windows –tyylinen ohjelma (graafinen käyttöliittymä), jossa tehdään
valuuttamuunnos. Käyttäjä syöttää halutun euromäärän, jonka jälkeen valitaan,
mihin valuuttaan nähden muutos tehdään esim.: kruunut, ruplat tai US –dollari.
Tulos näkyy ikkunassa, kun painetaan muunna -nappia. 
 */
namespace KoeTehtävä11
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
