using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Tee switch –lauseen avulla ohjelma, joka muuttaa syötetyn kirjaimen morse –
merkiksi (viisi kirjainta riittää). Merkistön löydät osoitteesta
http://wiki.ham.fi/Morse.mespace KoeTeht5
 */


namespace KoeTeht5
{
    class Program
    {
        static void Main(string[] args)
        {
            string luku;
            string luku1;
            string vastaus = "Anna jokin aakkonen niin muutan sen MORSE koodiksi (Tässä esimerkissä a-e, pääset pois ohjelmasta kirjoittamalla 'poistu')"; // Kysy mikse tulee "Use of unassigned local variable" kun ei määritä 'vastaus' muuttujaa?
            string[] Morse;
            bool Juoksu = true;
            Morse = new String[5]{"A .-","B -...","C -.-.","D -..","E ."};
            
            do
            {
                Console.Clear();
                Console.WriteLine("{0}", vastaus);
                luku1 = Convert.ToString(Console.ReadLine());
                luku = luku1.ToLower();
                Console.WriteLine("{0}", luku);
                switch (luku)
                {
                    case "a": //Miksi ei voi case 'a' || 'A':
                        vastaus = Morse[0];
                        break;

                    case "b":
                        vastaus = Morse[1];
                        break;

                    case "c":
                        vastaus = Morse[2];
                        break;

                    case "d":
                        vastaus = Morse[3];
                        break;

                    case "e":
                        vastaus = Morse[4];
                        break;
                    case "poistu":
                        Juoksu = false;
                        break;

                    default:
                        
                        break;

                }
            
            } while (Juoksu);

            
            
 
          

        }
    }
}
