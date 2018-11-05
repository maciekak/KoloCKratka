using System;
using System.Threading;

namespace Metin2
{
    class Program
    {
        static void Main(string[] args)
        {
            Wojownik wojownik1 = new Wojownik("GoToSleep", 4, 200, 20, 1);

            Ninja ninja = new Ninja("TheLegend3000", 9001, 300, 21, 0, false);
            
            wojownik1.PokazSzczegoloweInfoPostaci();
            ninja.PokazSzczegoloweInfoPostaci();
            Thread.Sleep(2000);

            //runda1 
            while (ninja.punktyZycia > 0 && wojownik1.punktyZycia > 0)
            {
                wojownik1.ZaatakujNinje(ninja);
                ninja.ZaatakujWojownika(wojownik1);
                wojownik1.PokazSzczegoloweInfoPostaci();
                ninja.PokazSzczegoloweInfoPostaci();
                Console.WriteLine();
                Thread.Sleep(2000);
            }


            Console.ReadKey();
        }
    }
}
