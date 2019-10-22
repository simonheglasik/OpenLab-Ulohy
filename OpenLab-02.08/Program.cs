using System;
using IsEmpty;

namespace OpenLab_02._08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                Empty empty;
                empty = new Empty();
                string a = Console.ReadLine();
                empty.Ep(a);
            }

        }
    }
}