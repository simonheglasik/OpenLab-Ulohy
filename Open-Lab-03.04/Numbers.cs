using System;

namespace Open_Lab_03._04
{
    public class Numbers
    {
        public string EvenOrOdd(int number)
        {
            bool a = number % 2 == 0;
            if (a =!a)
            {
                return "odd";
            }
            else
            {
                return "even";
            }
            
        }
    }
}
