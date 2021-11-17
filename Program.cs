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

            // foreach (var d in deck)
            // {
            //     Console.WriteLine(d.rank + "of" + d.suit);


            string[] deck = {"Ace of hearts", "2 of hearts", "3 of hearts", "4 of hearts", "5 of hearts", "6 of hearts", "7 of hearts", "8 of hearts", "9 of hearts", "10 of hearts",
                "Jack of hearts", "Queen of hearts", "King of hearts", "Ace of diamonds", "2 of diamonds", "3 of diamonds", "4 of diamonds", "5 of diamonds", "6 of diamonds", "7 of diamonds", "8 of diamonds", "9 of diamonds",
                 "10 of diamonds", "Jack of diamonds", "Queen of diamonds", "King of diamonds", "Ace of spades", "2 of spades", "3 of spades", "4 of spades", "5 of spades", "6 of spades", "7 of spades", "8 of spades", "9 of spades", "10 of spades",
                 "Jack of spades", "Queen of spades", "King of spades", "Ace of clubs", "2 of clubs", "3 of clubs", "4 of clubs", "5 of clubs", "6 of clubs", "7 of clubs", "8 of clubs", "9 of clubs", "10 of clubs",
                "Jack of clubs", "Queen of clubs", "King of clubs"};

            foreach (var card in deck)
            {
                Console.WriteLine(card);
            }

            // numberOfCards = length of our deck
            var numberOfCards = deck.Length;
            // for rightIndex from numberOfCards - 1 down to 1 do:
            var rightIndex = numberOfCards - 1;
            //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")
            var leftIndex = new Random();
            // Console.WriteLine("\n");
            // Console.WriteLine(leftIndex.Next(numberOfCards));
            // Console.WriteLine(deck[rightIndex]);

            //   Now swap the values at rightIndex and leftIndex by doing this:
            //     leftCard = the value from deck[leftIndex]
            var leftCard = deck[leftIndex.Next(rightIndex)];
            Console.WriteLine(leftCard);
            //     rightCard = the value from deck[rightIndex]
            //     deck[rightIndex] = leftCard
            //     deck[leftIndex] = rightCard
        }

    }
}

