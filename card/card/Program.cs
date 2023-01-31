﻿using System;
using System.Collections.Generic;

namespace card
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "TS QC 8S 8D QH 2D 3H KH 9H 2H TH KS KC" +
                           "\n9D JH 7H JD 2S QS TD 2C 4H 5H AD 4D 5D" +
                           "\n6D 4S 9S 5S 7S JS 8H 3D 8C 3S 4C 6S 9C" +
                           "\nAS 7C AH 6H KD JC 7D AC 5C TC QD 6C 3C" +
                           "\n#";
            string[] decks = input.Split('#')[0].Split('\n');
            foreach (string deck in decks)
            {Console.WriteLine(deck);
              }

            Console.ReadLine();
            
        }
    }
}
