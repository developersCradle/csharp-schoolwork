using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Tee ohjelma, joka kysyy käyttäjältä 10 lukua ja las
kee syötettyjen lukujen
summan. 
 */ 
namespace KoeTeht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna 10 lukua: ");
            int luku = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Anna {0}. luku.", i);
                luku += Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Lukujen yhteis-summa: {0}",luku);
            Console.WriteLine("Paina jotain näppäintä jatkaaksesi");
            Console.ReadKey();
        }

    }
}
