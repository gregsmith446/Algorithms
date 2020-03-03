using System;

// Another code block that would solve the challenge but relies on Array.Reverse

/*
public class AltSolution
{
    bool checkPalindrome(string inputString)
    {
        char[] charArr = inputString.ToCharArray();

        Array.Reverse(charArr);

        string reverse = new string(charArr);

        if (inputString == reverse)
        {
            return true;
        }
        return false;
    }

    bool result = checkPalindrome("aabaa");
    Console.WriteLine(result);
}
*/