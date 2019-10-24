using System;
using System.Collections.Generic;
using System.Text;

namespace dva
{
    class Tabule
    {
        public void Tab()
        {
        int[,] a = new int[2, 3] { { 5, 6, 8 }, { 7, 8, 5 } };
        Console.WriteLine(a[1, 2]);  
        }
    }
}

