using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5;         //1 byte
            sbyte c = 5;        //1 byte

            short s = 5;        //2 byte
            ushort us = 5;      //2 byte

            Int16 i16 = 2;      //2 byte
            int i = 2;          //4 byte
            Int32 i32 = 2;      //4 byte
            Int64 i64 = 2;      //8 byte

            uint ui = 2;        //4 byte
            long l = 2;         //8 byte
            ulong ul = 2;       //8 byte

            //Reel Sayılar
            float f = 5;        //4 byte
            double d = 5;       //8 byte
            decimal de = 5;     //16 byte

            char ch = 'c';       //2 byte
            string str = "yasa";     //sinirsiz

            bool bl1 = true;        
            bool bl2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            //String ifadeler
            string str1 = string.Empty;
            str1 = "Zubeyde Yasa";
            string ad = "Zubeyde";
            string soyad = "Yasa";
            string tamad = ad + " " + soyad;

            //Integer tanımlama
            int integer1 = 2;
            int integer2 = 3;
            int toplam = integer1 + integer2;

            //boolen
            bool bool1 = 10<2;

            //Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yenideger = str20 + int20.ToString(); //çıktı 2020

            int yeniDeger = int20 + Convert.ToInt32(str20); //çıktı 40 



        }
    }
}