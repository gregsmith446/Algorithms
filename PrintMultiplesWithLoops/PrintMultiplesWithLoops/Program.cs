using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMultiplesWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number plz:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = n * i;

                Console.Write(n);
                Console.Write(" x ");
                Console.Write(i);
                Console.Write(" = ");
                Console.WriteLine(result);

                // Console.WriteLine("{n} x {i} = {result}");
            }
        }
    }
}
