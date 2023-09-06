﻿using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try //Hataya sebebiyet verme ihtimali olan kod 
            {
                Console.WriteLine("bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.Write("girmiş olduğunuz sayı:" + sayi);
            }
            catch(Exception ex) //Hata ile karşılaşıldığında ne yapılacağı buraya yazılır
            {
                Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            finally //Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}