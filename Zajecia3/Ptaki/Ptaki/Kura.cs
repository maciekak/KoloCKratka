using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptaki
{
    class Kura : Ptak, INoFlyable
    {
        public void NoFly()
        {
            Console.WriteLine("Jestem kura i nie latam ==((((((((((((");
        }
    }
}
