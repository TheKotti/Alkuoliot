﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Card
    {
        public string Suite { get; set; }
        public int Number { get; set; }

        public Card()
        {

        }

        public override string ToString()
        {
            return Number + " of " + Suite;
        }
    }

    //PAKKA
    class Deck
    {
        public Card[] Cards;
        private Random _random = new Random();

        public Deck()
        {
            Cards = new Card[52];
            int i = 0;
            for (i = 0; i < 13; i++)
            {
                Cards[i] = new Card() { Suite = "Spades", Number = i + 1 };
            }
            for (i = 0; i < 13; i++)
            {
                Cards[i+13] = new Card() { Suite = "Hearts", Number = i + 1 };
            }
            for (i = 0; i < 13; i++)
            {
                Cards[i+26] = new Card() { Suite = "Clubs", Number = i + 1 };
            }
            for (i = 0; i < 13; i++)
            {
                Cards[i+39] = new Card() { Suite = "Diamonds", Number = i + 1 };
            }
        }
        public void Shuffle()
        {
            int n = Cards.Length-1;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(_random.NextDouble() * (n - i));
                Card t = Cards[r];
                Cards[r] = Cards[i];
                Cards[i] = t;
            }
        }
    }
}
