using System;
using System.Collections.Generic;
using System.Text;

namespace Test1Automat
{
    class Client
    {
        private Automat automat;
        private Coffee coffee;

        public Client(Automat automat)
        {
            this.automat = automat;
        }

        public void DecideCoffeeType()
        {
            var coffeeType = int.Parse(Console.ReadLine());
            automat.SetCoffeeType(coffeeType);
        }
        
        public void DecideSuggarQuantity()
        {
            var suggarQuantity = int.Parse(Console.ReadLine());
            automat.SetSuggarQuantity(suggarQuantity);
        }
        
        public int Pay()
        {
            return int.Parse(Console.ReadLine());
        }

        public void GetCoffee()
        {
            coffee = automat.GiveCoffee();

            Console.WriteLine("Ale dobra kawa");
        }
    }
}
