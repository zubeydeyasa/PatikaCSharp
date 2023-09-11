﻿﻿using System;
using Microsoft.VisualBasic;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = new string[5];
            
            string[] hayvanlar = {"Kedi", "Köpek", "Maymun"};

            int[] dizi;
            dizi= new int[5];

            //Dizilere değer atama ve erişme
            renkler[0] = "Mavi";
            dizi[3]= 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]); 

            //Döngülerle dizi kullanımı 
            //Klavyeden girilen n tane rakamın ortalamasını alan bir program
            Console.WriteLine("Lütfen kaç eleman olduğunu yazınız.");
            int uzunluk = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[uzunluk];

            for(int i = 0; i < uzunluk; i++)
            {
                Console.WriteLine("Lütfen {0}. sayısını giriniz.", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach(var sayi in sayiDizisi)
                toplam += sayi;

            
            Console.WriteLine("Ortalama :" + toplam/uzunluk);
        }
    }
}