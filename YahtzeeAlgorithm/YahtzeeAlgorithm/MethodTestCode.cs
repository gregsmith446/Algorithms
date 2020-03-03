// Main Method Tests


// test v.1
/*
int result = dice.RollOneDice();
*/

// test v1.2
/*
int[] rollResult = cup.RollFiveDiceOnce(numberOfDice);

foreach (int number in rollResult)
{
    Console.WriteLine(number);
}

int userPick = 4;

int choice = cup.UserPicksOneDie(rollResult, userPick);

Console.WriteLine("The user chose this one " + choice);
*/

// test v1.3
/*
int[,] result = cup.RollAllFiveDiceThreeTimes(numberOfRolls, numberOfDice);

Console.WriteLine("The dice results are as followed.");

foreach (int roll in result)
{
    Console.Write("{0} ", roll);
}
*/

// test v1.4
/*
int[] rollResult = cup.RollFiveDiceOnce(numberOfDice);

Console.WriteLine("The dice results are as follows");

foreach (int roll in rollResult)
{
    Console.WriteLine("{0} ", roll);
}

int[] picks = new int[] { 0, 2, 4 };

int[] picksPrinted = cup.UserPicksMultipleDieToReroll(rollResult, 3, picks);

Console.WriteLine("The user's picks are as follows");

foreach (int pick in picksPrinted)
{
    Console.WriteLine("{0} ", pick);
}
*/

// test v1.5
/*
int[][] whichDiceToReroll = new int[][]
{
    new int[] { 0 },
    new int[] { 1, 3 },
};

int[] numOfDiceRolling = new int[] { 5, 4, 3 };

int[][] result = cup.RollDiceThreeTimesAskingWhichToReroll(whichDiceToReroll, numOfDiceRolling);

foreach (int[] roll in result)
{
    foreach (int number in roll)
    {
        Console.WriteLine("{0} ", number);
    }
}
*/