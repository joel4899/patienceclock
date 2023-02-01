using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace card
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // Keep looping as long as the input is not equal to "#"
            while (input != "#")
            {
                // Splits the input into an array of strings, then concatenates four arrays of string from the Console.ReadLine();
             
                string[] cards = input.Split().Concat(Console.ReadLine().Split())
                    .Concat(Console.ReadLine().Split())
                    .Concat(Console.ReadLine().Split())
                    .ToArray();

                // Creates an integer array with 13 elements, initializing each element to 4
                int[] piles = new int[13];
                for (int i = 0; i < 13; i++)
                {
                    piles[i] = 4;
                }

                // Sets the starting pile index to 12 and the number of exposed cards to 4
                int currentPile = 12;
                int exposed = 4;

                // Stores the last exposed card as a string, initializing it to null
                string lastExposed = null;

                // Loops through the cards in reverse order
                for (int i = cards.Length - 1; i >= 0; i--)
                {
                    //int rank = "23456789TJQKA".IndexOf(cards[i][0]);
                    // Decrements the count of the current pile
                    piles[currentPile]--;
                    // Increases the number of exposed cards
                    exposed++;
                    // Stores the last exposed card
                    lastExposed = cards[exposed - 1];
                    // If the count of the current pile reaches 0, breaks out of the loop
                    if (piles[currentPile] == 0)
                    {
                        break;
                    }
                    // Updates the index of the current pile
                    currentPile = (currentPile + 1) % 13;
                }
                // Writes the number of exposed cards and the last exposed card to the console
                Console.WriteLine("{0:D2},{1}", exposed, lastExposed);
                input = Console.ReadLine();
            }
        }
    }
}


