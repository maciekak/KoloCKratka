using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptaki
{
    abstract class Ptak
    {
        public virtual void PrzedstawSie()
        {
            Console.WriteLine("To ja ptak");
        }
    }
}
