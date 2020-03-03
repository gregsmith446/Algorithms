using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvensAndOdds
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("give int between 1 and 100");
                int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 != 0)
            {
                Console.WriteLine("{0} is Weird", N);
            }
            else if (N % 2 == 0 && N <= 5 && N >= 2)
            {
                Console.WriteLine("{0} is Not Weird", N);
            } else if (N % 2 == 0 && N <= 20 && N >= 6)
            {
                Console.WriteLine("{0} is Weird", N);
            } else if (N % 2 == 0 && N > 20)
            {
                Console.WriteLine("{0} is Not Weird", N);
            }
        }
    }
}
