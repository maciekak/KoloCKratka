using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzeta
{
    class Program
    {
        static void Main(string[] args)
        {
            Jamnik jamnik  = new Jamnik("Hot Dog");
            Doberman doberman = new Doberman("Burek");

//            jamnik.GryzKapcie();
//            doberman.GryzKapcie();
//            doberman.GonListonosza();

//            Zwierze pies = new Zwierze("Pies");

            Pies pies = jamnik;
            pies.DajGlos();

            pies = doberman;
            pies.DajGlos();
            
            var pies2 = (Pies) doberman;
            pies2.GryzKapcie();


//            jamnik.DajGlos();
//            doberman.DajGlos();

            Console.ReadKey();
        }
    }
}
