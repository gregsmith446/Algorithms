using System;

namespace HighLowDeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Card
    {
        public int Rank;
        public int Suit;

        public Card(int rank, int suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }

}

/*
  function(int currentCard, int guess)
 
      current card is an integer value of a card, 0-12, Low Ace-King

      guess is either "high/low" or a 0, 1 to represent high, low

   v1.0 compare current card + guess against static value
   v1.1 randomly pick a card 0-12 to apply to the round
   v1.2 update current card object to an object suit + value keys, suit = 0,1,2,3
   v1.3 update the card picker to pick a suit as well
   v1.4 ensure the new card does not match the current one
   
   v2.0 create an encompassing function to control the game
   v2.1 ask user for high or low + print result
   v2.2 keep track of the # of correct guesses (+ print when game over?)
 */ 