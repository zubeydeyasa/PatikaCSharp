﻿using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implict conversion (bilinçsiz dönüşüm)
            byte a = 4;
            sbyte b = 2;
            short c = 3;

            int d = a+b+c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "zubeyde";
            char z = 'z';
            object g = e+z+d;
            Console.WriteLine("g:" + g);

            //Explict conversion (bilinçli dönüşüm)
            int x = 3;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            float f = 13.3f;
            byte v = (byte)f;
            Console.WriteLine("v:" + v);

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string s1="10", s2="20";
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            int toplam = sayi1+sayi2;
            Console.WriteLine("toplam:" + toplam);

            //Parse
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = double.Parse(metin2);

            Console.WriteLine("rakam1:" + rakam1);
            Console.WriteLine("double1:" + double1);
        }
    }
}