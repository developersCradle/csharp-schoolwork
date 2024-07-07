using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Lisää ohjelmaan vielä metodit muuta_maara sekä muuta_hinta, jolla voidaan muuttaa kyseiset arvot.
Kokeile muuttaa testiohjelmalla arvoja.
Tee toinen rakentajafunktio, jolla voidaan muuttaa suoraan uuden tietokoneen hintaa
alustuksen yhteydessä. 
 */
namespace KoeTeht9
{
    class Program
    {
        class Tietokone
        {
            private string tyyppi, valmistaja;
            private double hinta;
            private int maara;

            public Tietokone() // Rakentaja
            {
                tyyppi = "OptiPlex 7010";
                valmistaja = "DELL";
                hinta = 977;
                maara = 1;

            }
            public Tietokone(double x)
            {
                hinta = x;

            }

            public void kysy_tiedot()
            {
                Console.Write("Anna tyyppi  : ");
                tyyppi = Console.ReadLine();
                Console.Write("Anna valmistaja : ");
                valmistaja = Console.ReadLine();
                Console.Write("Hinta : ");
                hinta = Convert.ToInt16(Console.ReadLine());
                Console.Write("Määrä : ");
                maara = Convert.ToInt16(Console.ReadLine());
            }
            public void tulosta_tiedot()
            {
                Console.WriteLine("Tyyppi = {0}", tyyppi);
                Console.WriteLine("Valmistaja = {0}", valmistaja);
                Console.WriteLine("Hinta = {0}", hinta);
                Console.WriteLine("Lukumäärä = {0}", maara);
            }

            public void muuta_maara()
            {
                Console.WriteLine("Anna uusi lukumäärä: ");
                maara = Convert.ToUInt16(Console.ReadLine());
            }

            public void muuta_hinta()
            {
                Console.WriteLine("Anna uusi hinta: ");
                hinta = Convert.ToUInt16(Console.ReadLine());
            }


        }
        static void Main(string[] args)
        {
            double temp = 0;
            Console.WriteLine("Anna \"Hinta\" arvo rakentajalle: ");
            temp = Convert.ToInt16(Console.ReadLine());
            
            Tietokone x = new Tietokone(temp); // passataan rakentjalle temp arvo
            Console.WriteLine("Tulostetaan arvot: ");
            x.tulosta_tiedot();
            x.muuta_hinta();
            x.muuta_maara();
            x.tulosta_tiedot();

            Console.ReadLine();
        }
    }
}
