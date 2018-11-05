using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace Test1Automat
{
    class Automat
    {
        private Coffee coffee;

        private int collectedMoney;
        private int currentDebet;
        private int expectedMoney;
        
        private bool coffeeWithMilk;
        private int suggarQuantity;

        public void SetCoffeeType(int type)
        {
            coffeeWithMilk = type == 2;
        }

        public void SetSuggarQuantity(int quantity)
        {
            suggarQuantity = quantity;
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

        public void ShowSuggarInfo()
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
            if (coffeeWithMilk)
                expectedMoney += 5;

            expectedMoney += suggarQuantity;
        }

        public bool ReceiveMoneyAndCheckIfEnough(int money)
        {
            currentDebet += money;
            if (currentDebet < expectedMoney)
            {
                AskForMoney();
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
            if(coffeeWithMilk)
                coffee.AddMilk();

            coffee.AddSuggar(suggarQuantity);

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
