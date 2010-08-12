using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackSimulator
{
    internal class Player
    {
        internal const int DefaultBet = 10;
        private const int DefaultMoney = 100;
        public const int MaxBet = 2560;

        public List<Card> Cards { get; set; }

        public Player()
        {
            Money = DefaultMoney;
            Bet = DefaultBet;
            Cards = new List<Card>();
        }

        public void GiveCard(Card card)
        {
            Cards.Add(card);
        }


        public int Total
        {
            get
            {
                var highTotal = HighTotal;
                var lowTotal = LowTotal;

                return highTotal <= 21 && highTotal > lowTotal ? highTotal : lowTotal;
            }
        }

        public int HighTotal
        {
            get
            {
                var total = 0;
                foreach (var card in Cards)
                {
                    total += card.HighValue;
                }
                return total;
            }
        }

        public int LowTotal
        {
            get
            {
                var total = 0;
                foreach (var card in Cards)
                {
                    total += card.LowValue;
                }
                return total;
            }
        }

        public int LastBet { get; set; }

        public int Bet { get; set; }

        public int Money { get; set; }

        public bool HasAce()
        {
            return Cards.Count(c => c.CardType == CardTypes.Ace) > 0;
        }

        public bool IsSoft()
        {
            if(!HasAce())
                return false;

            if (Total == LowTotal && Total != HighTotal)
                return true;

            return false;
        }

        public void NewHand()
        {
            Cards = new List<Card>();
            LastBet = Bet;
        }

    }
}