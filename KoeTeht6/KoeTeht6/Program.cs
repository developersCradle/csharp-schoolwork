using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
Tee while –silmukalla ohjelma, joka kysyy taulukkoon numeroita käyttäjältä,
kunnes käyttäjä antaa negatiivisen luvun. Luvut tulostetaan käänteisessä
järjestyksessä taulukosta
 */ 

namespace KoeTeht6
{
    class Program
    {

    public static System.Array KasvataTaul (System.Array VanhaTaul, int UusiKoko)
    {
        int VanhaKoko = VanhaTaul.Length;
        System.Type ElementinTyyppi = VanhaTaul.GetType().GetElementType(); //Ottaa muistiin vanhanTaulukon elementti tyypin
        System.Array UusiTaul = System.Array.CreateInstance(ElementinTyyppi, UusiKoko); //Luo uuden taulukon käyttäjän antamista arvoista

        int säilytäPituus = System.Math.Min(VanhaKoko, UusiKoko); //Palauttaa pienemmän arvon

        if (säilytäPituus > 0)
        {
            System.Array.Copy(VanhaTaul, UusiTaul, säilytäPituus); //Kopioi vanhan talukon tiedot uuteen
        }
        


        return UusiTaul;
    }

    public static void Tulosta(int kerta,System.Array Taulukko,int pointteri)
    {
        
        for (int i = kerta; i >= 0;i--)
        {
            if (pointteri > 0)
            {
                pointteri--;
            }
           
            Console.WriteLine(Taulukko.GetValue(pointteri));
          
        }
        
    }

  
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy taulukkoon numeroita käyttäjältä, kunnes käyttäjä antaa negatiivisen luvun");
            double luku = 0;
            double[] Taul = new double[1];
            int pointteri = 0;
            int uusikoko = 1;
            bool ajo = true;
            while (ajo)
            {
                Console.WriteLine("Anna luku:");
                luku = Convert.ToDouble(Console.ReadLine());
                
                if (luku <= 0)
                {
                    
                    Tulosta(pointteri,Taul,pointteri);
                    ajo = false;
                }


                Taul = (double[])KasvataTaul(Taul, uusikoko);
                Taul[pointteri] = luku;

                
                Console.WriteLine(Taul[pointteri]);
                pointteri++;
                uusikoko++;     
            }
            Console.ReadLine();

           

        }
    }
}
