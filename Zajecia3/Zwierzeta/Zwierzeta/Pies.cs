using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzeta
{
    abstract class Pies : Zwierze
    {
        public Pies(string imie) : base(imie)
        {
        }
        public void GryzKapcie()
        {
            Console.WriteLine("Jestem psem, wabię się " + base.Imie + " i gryzę kapcie");
        }
    }
}
