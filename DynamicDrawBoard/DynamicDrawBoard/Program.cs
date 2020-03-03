using System;

namespace DynamicDrawBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            // get input data
            Console.WriteLine("Give Width - Must be 3 or more.");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give Cell Height - Must be 2 or more.");
            int height = Convert.ToInt32(Console.ReadLine());
            

            // create instance + call functions
            var makeInstance = new GameTime();
            makeInstance.DrawBoard(width, height);
        }
    }

    class GameTime
    {
        public string fullCell = " | ";
        public string halfCell = "| ";

        public string oneLine = "-+-";
        public string halfLine = "+-";

        public void DrawBoard(int width, int height)
        {
            if (width >=  3 && height >= 2)
            {
                Console.WriteLine("Drawing board...");

                Console.WriteLine(fullCell + halfCell);
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine(oneLine + halfLine);
                    for (int i = 0; i < height; i++)
                    {
                        Console.WriteLine(fullCell + halfCell);
                    }
                }
                Console.WriteLine(fullCell + halfCell);
            }
        }
    }
}

