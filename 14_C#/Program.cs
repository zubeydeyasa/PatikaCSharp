namespace  recursive_extention_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive 
            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            Works works = new();
            Console.WriteLine(works.Expo(3,4));

            //Extension metodlar
            string ifade = "zubeyde yasa";
            bool sonuc;
            sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

        }
    }
    public class Works
    {
        public int Expo(int sayi, int üs)
        {
            if(üs < 2)
                return sayi;
            return Expo(sayi, üs-1) * sayi;
        }

        public static class Extension
        {
            public static bool CheckSpaces(string param)
            {
                return param.Contains(" ");
            }
            
        }
    }
    
}