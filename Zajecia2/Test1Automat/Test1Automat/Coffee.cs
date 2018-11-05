using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Test1Automat
{
    class Coffee
    {
        private bool withMilk;
        private int howManySuggar;

        public void AddMilk()
        {
            withMilk = true;
        }

        public void AddSuggar(int quantity)
        {
            howManySuggar = quantity;
        }

        public bool CheckIfWithMilk()
        {
            return withMilk;
        }

        public int GetHowManySuggar()
        {
            return howManySuggar;
        }
    }
}
