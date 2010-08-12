using System;
using System.Collections.Generic;

namespace BlackjackSimulator
{
    internal class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            CardTypes types;
            for (var i = 0; i < 4; i++)
            {
                foreach (var type in Enum.GetValues(typeof(CardTypes)))
                {
                    Cards.Add(new Card((CardTypes)type));
                }
            }
        }
    }
}