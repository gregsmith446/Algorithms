using System;


// create a fuction that will take an integer and reverse the order

// ex
// Input: 21445 Output: 54412

// Input: 145263 Output: 362541

namespace ReverseIntOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = ReversedOrder(21445);
        }

        static int ReversedOrder(int num)
        {
            // retrieve the 'ones' int from the given int by doing % 10
            int ones = num % 10;

            // integer division always results in an integer - it forces out decimals
            // using int division, divide the given int by 10 - it chops off the last digit - the ones position.
            int intNoOnes = num / 10;

            int tens = intNoOnes % 10;

            // start making the int we will return
            // add the ones modulo digit, then make it into an even tens digit, by doing (ones * 10), then add the other digits 
            int reversedInt = (ones * 10) + tens;

            Console.WriteLine(reversedInt);

            return reversedInt;

            // need to know how many positions our given int has the start?
            // how to retrive the digits at the other locations: 100s 1000s 10000s
            // how to add the other digits to the reverse int correctly
        }
    }
}
