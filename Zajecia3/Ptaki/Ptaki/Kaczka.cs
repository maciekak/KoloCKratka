using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptaki
{
    class Kaczka : Ptak, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Jestem kaczka i latam fru fru");
        }

        public override void PrzedstawSie()
        {
            Console.WriteLine("Jestem kaczka");
        }
    }
}
