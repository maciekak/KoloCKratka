using System;

namespace Automat
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
        
        public void DecideSugarQuantity()
        {
            var suggarQuantity = int.Parse(Console.ReadLine());
            automat.SetSugarQuantity(suggarQuantity);
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
