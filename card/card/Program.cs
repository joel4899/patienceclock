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
            while (input != "#")
            {
                string[] cards = input.Split().Concat(Console.ReadLine().Split())
                    .Concat(Console.ReadLine().Split())
                    .Concat(Console.ReadLine().Split())
                    .ToArray();
                int[] piles = new int[13];
                for (int i = 0; i < 13; i++)
                {
                    piles[i] = 4;
                }
                int currentPile = 12;
                int exposed = 4;
                string lastExposed = null;
                for (int i = cards.Length - 1; i >= 0; i--)
                {
                    //int rank = "23456789TJQKA".IndexOf(cards[i][0]);
                    piles[currentPile]--;
                    exposed++;
                    lastExposed = cards[exposed - 1];
                    if (piles[currentPile] == 0)
                    {
                        break;
                    }

                    currentPile = (currentPile + 1) % 13;
                }
                Console.WriteLine("{0:D2},{1}", exposed, lastExposed);
                input = Console.ReadLine();
            }
        }
    }
}


