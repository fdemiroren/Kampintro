using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> {"Fatih", "Sinem", "Beren" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);

            isimler2.Add("Muslera");

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[3]);
            
            


        }
    }
}
