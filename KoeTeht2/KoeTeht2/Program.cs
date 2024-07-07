using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 
 Lisää tehtävän 1 ohjelmaan ominaisuus, että se hyväksyy ainoastaan välillä 1 – 15
 olevat luvut.
 
 */
namespace KoeTeht2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Anna 10 lukua. Luvut pitää olla 1 - 15 numeroavaruuden sisällä.");
            //(elä syötä mitään muuta :D)
            int luku = 0;
            int anto = 0;
            for (int i = 1; i <= 10; i++ )
            {
                Console.WriteLine("Anna {0}. luku.", i);

                anto = Convert.ToInt16(Console.ReadLine());

                if (anto >= 1 && anto <= 15)
                {
                    luku += Convert.ToInt16(anto);
                }
                else
                {
                    Console.WriteLine("Luku on invalidi");
                    i -= 1;               
                }
            }

            Console.WriteLine("Lukujen yhteis-summa: {0}",luku);
            Console.WriteLine("Paina jotain näppäintä jatkaaksesi");
            Console.ReadKey();
        
        }
    }
}
