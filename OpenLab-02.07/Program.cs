using System;

namespace OpenLab_02._07
{
    class Program
    {
        static void Main(string[] args)
        {
          bool a = true;
          a = DateTime.Now == new DateTime(2019, 12, 24);
          Console.WriteLine(a);
        }

    }
}
