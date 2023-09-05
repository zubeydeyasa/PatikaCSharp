using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Girin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Girin: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname); //birleştirmek için + kullandık.



        }
    }
}