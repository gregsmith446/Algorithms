using System;
using System.Linq;

namespace AnotherReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("size of array - int");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} space separated integers", n);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}
