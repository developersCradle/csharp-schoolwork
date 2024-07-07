using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Tee ohjelma, joka laskee do-while –silmukan avulla kolme lukua yhteen ja laskee
lukujen keskiarvon. Hyväksyttävät luvut on oltava välillä 4 – 10.
 */

namespace KoeTeht4
{

    class Program
    {
       

        static private Double LaskeYht(Double Num1, Double Num2, Double Num3)
        {
            double vastaus = 0;
           
            vastaus = Num1 + Num2 + Num3;
            
            return vastaus;
        }


        
         static public Double LaskeKesk(Double vastaus)
         {

             double KeskiArvo = 0;
             
              KeskiArvo = vastaus/3;
             
             return KeskiArvo;
         }
         
            
        


        public static void Main(string[] args)
        {




            
            double[] Taulukko;
            bool run = true;
            Taulukko = new Double[3];
            double Vast = 0;
            double Luku = 0;

            Console.WriteLine("Anna 3 lukua jotka ovat 4 - 10 välillä");
            do
            {

                for (int i = 0; i < 3; i++)
                {
               
                Alku:
                    Console.WriteLine("Anna {0}.luku", i);
                    Luku = Convert.ToDouble(Console.ReadLine());
                    if (Luku < 4 || Luku > 10)
                    {
                        Console.WriteLine("luku ei ollut 4 - 10 välissä \n Yritä uudelleen");
                        goto Alku;
                    }
                    else
                    {
                        Taulukko[i] = Luku;
                    }

                    
                }
               
                Vast = LaskeYht(Taulukko[0], Taulukko[1], Taulukko[2]);

                Console.WriteLine("Lukujen summa on {0}" , Vast);
                Console.WriteLine("Lukujen keski arvo : ");
                Console.WriteLine(LaskeKesk(Vast));

                run = false;
            }
            while (run);



            Console.ReadKey();

        }
    }

}
     
        
        
   

    

