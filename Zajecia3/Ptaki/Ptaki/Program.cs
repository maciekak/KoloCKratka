using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptaki
{
    class Program
    {
        static void Main(string[] args)
        {
            var golab = new Golab();
            var kura = new Kura();
            Ptak kaczka = new Kaczka();
            kaczka.PrzedstawSie();
            //kura.PrzedstawSie();

//            IFlyable fly = golab;
//            fly.Fly();
//            var fly2 = (INoFlyable) kura;
//            fly2.NoFly();

//            golab.Fly();
//            kaczka.Fly();
//            kura.NoFly();

            Console.ReadKey();
        }
    }
}
