﻿using System;

namespace OpenLab_Uloha_02._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                string a = Console.ReadLine();
                int b = int.Parse(a);
                bool c = true;
                c = (b % 5 == 0);
                Console.WriteLine(c);
            }
        }
    }
}
