using System;
using Microsoft.VisualBasic;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**************ekrandan girilen sayıya kadar olan tek sayıları yazdıran bir program:**************
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayac = int.Parse(Console.ReadLine());
            Console.WriteLine("Girilen sayı :" + sayac);
            Console.WriteLine("Girilen sayıya kadar olan bütün tek sayılar");
            for(int i = 1; i<= sayac; i++)
            {
                if(i%2 == 1)
                    Console.WriteLine(i);
            }

            //**************Break - Continue**************
            for (int i = 1; i<10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }
            for(int i = 1; i<10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}