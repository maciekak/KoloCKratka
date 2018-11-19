using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzeta
{
    abstract class Zwierze
    {
        protected string Imie;

        public Zwierze(string imie)
        {
            Imie = imie;
        }

        public abstract void DajGlos();
    }
}
