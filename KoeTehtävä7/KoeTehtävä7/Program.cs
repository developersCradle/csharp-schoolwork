using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Tee luokka Tietokone, joka sisältää seuraavat yksityiset muuttujat (alkiot, jäsenet):
string -tyyppiset tyyppi ja valmistaja, double -tyyppinen hinta, int -tyyppinen
maara. Tee myös julkiset metodit kysy_tiedot sekä tulosta_tiedot, joissa kysytään
ja tulostetaan arvot Tietokone –luokan muuttujille
 */ 
namespace KoeTehtävä7
{
    class Program
    {

        
      
        class Tietokone
        {
            private string tyyppi, valmistaja;
            private double hinta;
            private int maara;

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
            x.kysy_tiedot();
            x.tulosta_tiedot();

            Console.ReadLine();
        }
    }
}
