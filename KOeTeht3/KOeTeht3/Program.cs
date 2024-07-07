using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Tee ohjelma, joka kysyy käyttäjältä nimiä (max. 20kpl) string –tyyppiseen
taulukkoon. Nimien kysely lopetetaan joko tiettyyn merkkiin tai alussa kysytään,
montako nimeä halutaan syöttää. Nimet tulostetaan foreach –silmukan avulla
taulukosta.
 */
namespace KOeTeht3
{
    class Program
    {
       
        static  void Main(string[] args)
        {
            string[] Taulukko;
            int anto = 0;
            int o = 0;
            
            
           
            
                Console.WriteLine("Kuinka monta nimeä haluat antaa?");
                anto = Convert.ToInt16(Console.ReadLine());

                if (anto >= 0 && anto <= 20)
                {
                    Taulukko = new string[anto];






                    for (int i = 0; i < anto; i++)
                    {
                        Console.WriteLine("Anna solulle {0}. Nimi", i);
                        Taulukko[i] = Convert.ToString(Console.ReadLine());

                    }


                    foreach (string nimi in Taulukko)
                    {
                        Console.WriteLine("Solu {0}. Sisälti nimen:", o);
                        Console.WriteLine(nimi);
                        o++;
                    }

                }
                else
                {
                    Console.WriteLine("Arvo oli virheellinen. Muistithan antaa luvun 0-20 välissä");
                }
            




            Console.WriteLine("<Paina jotain näppäintä jatkaaksesi>");
            Console.ReadKey();
        }
    }

}

