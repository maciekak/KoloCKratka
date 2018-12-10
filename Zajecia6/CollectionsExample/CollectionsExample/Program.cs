using System;
using System.Collections.Generic;

namespace CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sposob dodawania elementów - normalny i nienormalny
            //Dać metodę wypisującą
            //Pokazać różne interfejsy
            //Pokazać array, List, dictionary, linkedlist
            //Pokazać filtrowanie (Program) - where%, where< i select*
            //Pokazać LINQ
            //Pokazać że jest leniwe
            //Dodać logowanie konsolowe
            //Zmienić referencje
            var a = (IEnumerable<int>) (new List<int> {1, 2});
            Console.ReadKey();
        }
    }
}
