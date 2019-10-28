using System;
using System.Collections.Generic;
using System.Text;

namespace OpenLab_03._02_Object
{
    class Class1
    {
        public void Tab()
        {
            string[,] tab = new string[2, 3] { { "jozef", "Fero", "Karol" }, { "Ahoj", "je", "prec" } };
            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                     Console.Write((tab[a, b]) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
