using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptaki
{
    class Golab : Ptak, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Jestem golabiem i latam fruuu fruuu");
        }
    }
}
