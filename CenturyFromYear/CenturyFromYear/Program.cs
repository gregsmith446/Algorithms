using System;

namespace CenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = CenturyFromYear(1700);
        }
        static int CenturyFromYear(int year)
        {
            if (year % 100 == 0)
            {
                return (year / 100);
            }
            else
            {
                return ((year / 100) + 1);
            }
        }
    }
}
