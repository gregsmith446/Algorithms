using System;

namespace BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var runFunction = new Binary();

            int answer = runFunction.binaryConversions(13);

            Console.WriteLine(answer);
        }

        public class Binary
        {
            public int binaryConversions(int n)
            {
                // convert integer to binary using Convert override method to binary
                string binaryString = Convert.ToString(n, 2);

                // 2 variables to hold the count of 1s in the binary
                int tempMax = 0;
                int totalMax = 0;

                foreach (char num in binaryString)
                {
                    if (num == '1')
                    {
                        tempMax++;
                        if (tempMax > totalMax)
                        {
                            totalMax = tempMax;
                        }
                    }
                    else
                    {
                        tempMax = 0;
                    }
                }
                return totalMax;
            }
        }
    }
}
