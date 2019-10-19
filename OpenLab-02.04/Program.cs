using System;

namespace OpenLab_Uloha_02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = 1;
            int cow = 1;
            int pig = 1;

            int sum = s(chicken, cow, pig);
            Console.WriteLine(sum);
        }
        public static int s(int a, int b, int c)
        {
            return (a * 2) + (b * 4) + (c * 4);
        }
    }
}
