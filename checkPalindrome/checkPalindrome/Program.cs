using System;

// Mostly Objectified checkPalindrome Challenge from CodeSignal
// 2 Functions: 1st Reverse a String Directly Via Loops
// 2nd Determines whether the initial string is = to the reversed string, aka is it a palindrome or not? + returns a bool.

namespace checkPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "zabbatyui";

            // REVERSE STRING
            string ReverseStringDirect(string s)
            {
                char[] charArr = new char[s.Length];

                int forward = 0;

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    charArr[forward++] = s[i];
                }
                string flipped = new string(charArr);
                Console.WriteLine(flipped);
                return flipped;
            }

            // COMPARE REVERSE STRING TO ORIGINAL
            bool checkPalindrome(string inputString, string backwardString)
            {
                if (inputString == backwardString)
                {
                    return true;
                }
                return false;
            }

            // CALL BOTH FUNCTIONS SEPARATELY, CW THE RESULT
            string reverse = ReverseStringDirect(testString);
            bool boolResult = checkPalindrome(testString, reverse);
            Console.WriteLine(boolResult);
        }
    }
}
