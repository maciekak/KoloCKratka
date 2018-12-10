using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sposob dodawania elementów - normalny i nienormalny
            //Dać metodę wypisującą
            //Pokazać różne interfejsy -> rzutowanie
            //Pokazać array, List, dictionary, linkedlist
            //Pokazać filtrowanie (Program) - where%, where< i select*
            //Pokazać LINQ
            //Pokazać że jest leniwe
            //Dodać logowanie konsolowe
            //Zmienić referencje

            //            var array = new Photo[4];
            //
            //            var list = new List<Photo>();
            //            list.Add(new Photo());
            //
            //            var dictionary = new Dictionary<string, Photo>();
            //            dictionary.Add("Swieta", new Photo());
            //            dictionary.Add("Wakacje", new Photo());
            //
            //            var list = new List<int>(20);
            //
            //            for (var i = 0; i < 20; i++)
            //            {
            //                list.Add(i);
            //            }
            //
            //            ShowCollection(list);



            //            var list2 = (IEnumerable<int>) list;
            //
            //            var a = list2[1];
            //            list2.Add(1);
            //            foreach (var item in list2)
            //            {
            //                Console.Write(item + ", ");
            //            }


            //            var list = new Dictionary<string, int>(20);
            //            for (var i = 0; i < 20; i++)
            //            {
            //                list.Add(i.ToString(), 20-i);
            //            }
            //
            //            Console.WriteLine(list["4"]);

            //            var list = new List<int>(20);
            //            for (var i = 0; i < 20; i++)
            //            {
            //                list.Add(i);
            //            }
            //
            //            var list2 = new List<int>();
            //            foreach (var item in list)
            //            {
            //                if (item < 10)
            //                {
            //                    list2.Add(item);
            //                }
            //            }
            //            ShowCollection(list2);
            //
            //
            //            var list3 = new List<int>();
            //            foreach (var item in list2)
            //            {
            //                if (item % 3 == 0)
            //                {
            //                    list3.Add(item);
            //                }
            //            }



            var list = new List<int>(20);
            for (var i = 0; i < 20; i++)
            {
                list.Add(i);
            }

            var list3 = list
                .Where(x =>
                {
                    Console.WriteLine("Dupa " + x);
                    return x < 10;
                })
                .Where(x =>
                {
                    Console.WriteLine("Dupa2 " + x);
                    return x % 3 == 0;
                });



            ShowCollection(list3);

            Console.ReadKey();
        }

        private static void ShowCollection(IEnumerable<int> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
        }
    }

    class Photo
    {

    }
}
