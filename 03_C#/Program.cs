using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama
            int x = 3;
            int y = 4;
            y = y+2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x *=2;
            Console.WriteLine(x);

            //Mantıksal operatörler
            bool issuc = true;
            bool iscom = false;

            if(issuc && iscom)
                Console.WriteLine("Perfect");
            if(issuc || iscom)
                Console.WriteLine("Great");
            if(issuc && !iscom)
                Console.WriteLine("fine");

            //İlişkisel operatörler
            int a = 3;
            int b = 4;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            //Aritmatik operatörler
            int sayi1 = 2;
            int sayi2 = 4;
            int sonuc2 = sayi1 + sayi2;

            Console.WriteLine(sonuc2);
            sonuc2 = sayi1-sayi2;
            Console.WriteLine(sonuc2);
            sonuc2 = sayi1*sayi2;
            Console.WriteLine(sonuc2);
            sonuc2 = 20%3;
            Console.WriteLine(sonuc2);
        }
    }
}