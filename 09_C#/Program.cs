﻿using System;
using Microsoft.VisualBasic;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While
            //consoldan alınan sayıdan (sayı dahil) ortalama döndüren program
            Console.WriteLine("lütfen bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac<=sayi)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            // a dan z ye kadar tüm harfleri konsole yazdıran bir program
            char a = 'a';
            while(a<='z')
            {
                Console.Write(a);
                a++;
            }

            //Foreach
            Console.WriteLine("********Foreach**********");
            string[] arabalar = {"BMV", "Nissan", "Toyota", "Ford"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}