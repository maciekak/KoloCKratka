using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzeta
{
    class Doberman : Pies
    {
        public Doberman(string imie) : base(imie)
        {
        }

        public void GonListonosza()
        {
            Console.WriteLine("Wlasnie gonie listonosza");
        }

        public override void DajGlos()
        {
            Console.WriteLine("Hau hauu jestem dobermanem");
        }
    }
}
