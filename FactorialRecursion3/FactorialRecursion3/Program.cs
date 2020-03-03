using System;

namespace FactorialRecursion3
{
    class Program
    {
        static void Main(string[] args)
        {
            // to test the recursive factorial function below, change the int in the () + write to console
            int result = factorial(3);
        }


        static int factorial(int n)
        {
            if (n < 1)
            {
                return 1;
            } else
            {
                int total = n * factorial(n - 1);
                return total;
            }
        }

    }
}
