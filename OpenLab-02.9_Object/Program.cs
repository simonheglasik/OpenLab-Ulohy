using System;
using Nam;
namespace OpenLab_02._9_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Simon";
            string last = "Heglasík";
            Names name;
            name = new Names();
            name.Name(first, last);
        }
    }
}
