using System;
using System.Threading;

namespace Automat
{
    class Automat
    {
        private Coffee coffee;

        private int collectedMoney;
        private int currentDebet;
        private int expectedMoney;
        
        private bool isCoffeeWithMilk;
        private int sugarQuantity;

        public void SetCoffeeType(int type)
        {
            isCoffeeWithMilk = type == 2;
        }

        public void SetSugarQuantity(int quantity)
        {
            sugarQuantity = quantity;
        }

        public void ShowCoffeSize()
        {
            Console.WriteLine("Wybierz kawe: ");
            Console.WriteLine("1) Mala");
            Console.WriteLine("2) Srednia");
            Console.WriteLine("3) Duza");
        }

        public void ShowCoffeType()
        {
            Console.WriteLine("Wybierz rodzaj kawy:");
            Console.WriteLine("1) Czarna");
            Console.WriteLine("2) Biala");
        }

        public void ShowSugarInfo()
        {
            Console.WriteLine("Wybierz ile chcesz cukru:");
        }

        public void AskForMoney()
        {
            var balance = expectedMoney - currentDebet;
            Console.WriteLine("Wrzuć " + balance + " pieniedzy");
        }

        public void ComputeCoffeePrice()
        {
            expectedMoney = 3;
            if (isCoffeeWithMilk)
                expectedMoney += 5;

            expectedMoney += sugarQuantity;
        }

        public bool ReceiveMoneyAndCheckIfEnough(int money)
        {
            currentDebet += money;
            if (currentDebet < expectedMoney)
            {
                return false;
            }

            collectedMoney += expectedMoney;
            currentDebet -= expectedMoney;
            return true;
        }

        public void PrepereCoffee()
        {
            Console.WriteLine("Przygotowywanie kawy");

            coffee = new Coffee();
            if(isCoffeeWithMilk)
                coffee.AddMilk();

            coffee.AddSugar(sugarQuantity);

            for (int i = 0; i < 7; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }

            Console.WriteLine();
            Console.WriteLine("Kawa gotowa");
        }

        public Coffee GiveCoffee()
        {
            var currentCoffee = coffee;
            coffee = null;
            return currentCoffee;
        }
    }
}
