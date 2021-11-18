using System;
using System.Collections.Generic;
using System.Linq;


namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // OBJECTIVES
            //   Demonstrate usage of List or arrays to model resources.
            //   Understand and implement algorithms.
            //   Understand loops.

            // var suits = new[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            // var ranks = new[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            // var deck = ranks.Zip(ranks, (r, s) => new { rank = r, suit = s });

            // foreach (var card in deck)
            // {
            //     Console.WriteLine(card.rank + " of " + card.suit);
            // }

            // string[] rank = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            // string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };

            // var deck = rank.Zip(suit, (first, second) => first + " of " + second);

            // foreach (var item in deck)
            // {
            //     Console.WriteLine(item);
            // }



            // foreach (string card1 in rank)
            // {
            //     foreach (string card2 in suit)
            //     {
            //         Program test = new Program();
            //         String printer = test.concatString(card1, card2);

            //         Console.WriteLine(printer);
            //     }
            // }

            // string[] deck = {"Ace of hearts", "2 of hearts", "3 of hearts", "4 of hearts", "5 of hearts", "6 of hearts", "7 of hearts", "8 of hearts", "9 of hearts", "10 of hearts",
            //     "Jack of hearts", "Queen of hearts", "King of hearts", "Ace of diamonds", "2 of diamonds", "3 of diamonds", "4 of diamonds", "5 of diamonds", "6 of diamonds", "7 of diamonds", "8 of diamonds", "9 of diamonds",
            //      "10 of diamonds", "Jack of diamonds", "Queen of diamonds", "King of diamonds", "Ace of spades", "2 of spades", "3 of spades", "4 of spades", "5 of spades", "6 of spades", "7 of spades", "8 of spades", "9 of spades", "10 of spades",
            //      "Jack of spades", "Queen of spades", "King of spades", "Ace of clubs", "2 of clubs", "3 of clubs", "4 of clubs", "5 of clubs", "6 of clubs", "7 of clubs", "8 of clubs", "9 of clubs", "10 of clubs",
            //     "Jack of clubs", "Queen of clubs", "King of clubs"};

            // foreach (var card in deck)
            // {
            //     Console.WriteLine(card);
            // }

            // // numberOfCards = length of our deck
            // var numberOfCards = deck.Length;
            // // for rightIndex from numberOfCards - 1 down to 1 do:
            // var rightIndex = numberOfCards - 1;
            // //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")
            // var leftIndex = new Random();
            // // Console.WriteLine("\n");
            // // Console.WriteLine(leftIndex.Next(numberOfCards));
            // // Console.WriteLine(deck[rightIndex]);

            // //   Now swap the values at rightIndex and leftIndex by doing this:
            // //     leftCard = the value from deck[leftIndex]
            // var leftCard = deck[leftIndex.Next(rightIndex)];
            // Console.WriteLine(leftCard);
            // //     rightCard = the value from deck[rightIndex]
            // //     deck[rightIndex] = leftCard
            //     deck[leftIndex] = rightCard





            // PEDAC Process Algorithm B

            //   - Make a list of the 4 suits and call this list `suits`
            var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };

            //   - Make a list of the 13 ranks and call this list `ranks`
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            //   - Make a new list of strings named `deck` 
            var deck = new List<string>();

            //   - Make a loop that goes through the list `suits`
            foreach (var suit in suits)
            {
                //     - Make a loop that goes through the list `ranks`
                foreach (var rank in ranks)
                {
                    //       -For each rank, make a new string, called "card", of the form $"{rank} of {suit}"
                    var card = $"{rank} of {suit}";
                    //       -Add that newly formed string to the end of the deck list. 
                    deck.Add(card);
                    Console.WriteLine(card);
                }
            }

            // PEDAC Process Algorithm A 

            //   - Make a new list of strings `deck`


            //   - Initialize the list strings with 52 explicity stated cards from Example Section
            // // var deck = new List<string>(){
            // "Ace of Clubs",
            // "2 of Clubs",
            // "3 of Clubs",
            // "4 of Clubs",
            // "5 of Clubs",
            // "6 of Clubs",
            // "7 of Clubs",
            // "8 of Clubs",
            // "9 of Clubs",
            // "10 of Clubs",
            // "Jack of Clubs",
            // "Queen of Clubs",
            // "King of Clubs",
            // "Ace of Diamonds"
            // // };
            // //   - Shuffle them with Fisher Yates (paste algo here)
            // //       numberOfCards = length of our deck
            var numberOfCards = deck.Count;

            // //       for rightIndex from numberOfCards - 1 down to 1 do:
            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                //     //       leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                //     //       Now swap the values at rightIndex and leftIndex by doing this:
                //     //       leftCard = the value from deck[leftIndex]
                var leftCard = deck[leftIndex];
                //     //       rightCard = the value from deck[rightIndex]
                var rightCard = deck[rightIndex];
                //     //       deck[rightIndex] = leftCard
                deck[rightIndex] = leftCard;
                //     //       deck[leftIndex] = rightCard
                deck[leftIndex] = rightCard;

            }



            // //   - first card = deck[0]
            var firstCard = deck[0];
            // //   - second card = deck[1]
            var secondCard = deck[1];
            // //   - print first and second card
            Console.WriteLine($"Your first card is: {firstCard} ");
            Console.WriteLine($"Your second card is: {secondCard} ");
        }


    }
}

