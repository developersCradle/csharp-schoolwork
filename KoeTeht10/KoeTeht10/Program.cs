using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
/*

Tee graafinen käyttöliittymä ohjelmalle, missä lasketaan huoneen pinta-ala ja tilavuus.
Lomakkeella syötetään huoneen mitat (leveys, pituus ja korkeus), jonkajälkeen laske –nappia painettaessa saadaan selville
huoneen pinta-ala ja tilavuus. 
 */ 

namespace KoeTeht10
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
            Application.Run(new KoeTeht10());
        }
    }
}
