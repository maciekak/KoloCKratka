using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzeta
{
    class Jamnik : Pies
    {
        public Jamnik(string imie) : base(imie)
        {
        }

        public override void DajGlos()
        {
            Console.WriteLine("Hau hau jestem jamnik");
        }
    }
}
