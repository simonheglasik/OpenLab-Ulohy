using System;

namespace OpenLab_02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                int aa = int.Parse(a);
                int bb = int.Parse(b);
                int remainder = aa % bb;
                Console.WriteLine($"Remainder is {remainder}");
            }

        }
    }
}
