using System.Text;

namespace BlackjackSimulator
{
    internal enum CardTypes
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    class Card
    {
        public CardTypes CardType { get; private set; }

        public Card(CardTypes cardtype)
        {
            CardType = cardtype;
        }

        public override string ToString()
        {
            return CardType.ToString();
        }

        public int HighValue
        {
            get
            {
                switch (CardType)
                {
                    case CardTypes.Jack:
                    case CardTypes.Queen:
                    case CardTypes.King:
                    case CardTypes.Ten:
                        return 10;
                    case CardTypes.Ace:
                        return 11;
                    default:
                        return (int)CardType;
                }
            }
        }  
        
        public int LowValue
        {
            get
            {
                switch (CardType)
                {
                    case CardTypes.Jack:
                    case CardTypes.Queen:
                    case CardTypes.King:
                    case CardTypes.Ten:
                        return 10;
                    default:
                        return (int)CardType;
                }
            }
        }
    }
}
