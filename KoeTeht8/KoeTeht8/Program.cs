using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Lisää tehtävään 7 rakentajametodi, jolla alustetaan tietokoneen tiedot seuraavilla
arvoilla:
tietokoneen tyyppi: OptiPlex 7010
valmistaja: DELL
hinta: 977.00€
sekä määrä: 1 
Luo pääohjelmassa testiolio, jolla testaat, että Tietokone -luokka ja sen metodit toimivat. 
 */ 
namespace KoeTeht8
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
        }
        static void Main(string[] args)
        {
            Tietokone x = new Tietokone();
            Console.WriteLine("Tulostan rakentajan antamat arvot ->");
            x.tulosta_tiedot();
            Console.WriteLine("Anna uudet arvot ->");
            x.kysy_tiedot();
            Console.WriteLine("Tulostan antamasi arvot ->");
            x.tulosta_tiedot();

            Console.ReadLine();
        }
    }
}
