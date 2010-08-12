using System;
using System.Collections.Generic;

namespace BlackjackSimulator
{
    internal class Shoe
    {
        private List<Deck> Decks { get; set; }

        public List<Card> Cards { get; set; }

        public Shoe()
        {
            Decks = new List<Deck>();
            Cards = new List<Card>();
            for (int i = 0; i < 6; i++)
            {
                Decks.Add(new Deck());
            }
            //create cards
            foreach (var deck in Decks)
            {
                Cards.InsertRange(0, deck.Cards);
            }
        }


        public Card GetCard()
        {
            if (Cards.Count == 0)
            {
                throw new InvalidOperationException();
            }
            var index = RandomNumber(0, Cards.Count - 1);
            var card = Cards[index];
            Cards.RemoveAt(index);
            return card;
        }

        private static int RandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }

    }
}