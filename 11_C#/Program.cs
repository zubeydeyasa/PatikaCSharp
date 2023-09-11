﻿﻿using System;
using Microsoft.VisualBasic;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = {23,33,45,78,99,1,3,5,9};
            Console.WriteLine("******Sırasız Dizi******");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("******Sırasız Dizi******");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("******Array Clear******");
            Array.Clear(sayiDizisi,2,2);//sayiDizisinin 2.indexten itibaren 2 tanesine 0 atar.
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse
            Console.WriteLine("******Array Reverse******");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //İndexof
            Console.WriteLine("******Array IndexOf******");
            Console.WriteLine(Array.IndexOf(sayiDizisi,99));
        }
    }
}