using System;

namespace Test1Automat
{
    class Program
    {
        static void Main(string[] args)
        {
            var automat = new Automat();
            var client = new Client(automat);
            
            automat.ShowCoffeType();
            client.DecideCoffeeType();

            automat.ShowSugarInfo();
            client.DecideSugarQuantity();

            automat.ComputeCoffeePrice();
            int money;
            do
            {
                automat.AskForMoney();
                money = client.Pay();

            } while (!automat.ReceiveMoneyAndCheckIfEnough(money));

            automat.PrepereCoffee();
            client.GetCoffee();

            Console.ReadKey();
        }
    }
}
