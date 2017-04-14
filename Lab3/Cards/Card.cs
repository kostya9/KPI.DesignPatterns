using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Cards
{
    public class Card
    {
        public CardRank Rank { get; set; }
        public CardSuite Suite { get; private set; }

        public Card(CardSuite suite)
        {
            Suite = suite;
        }

        public Card Clone()
        {
            return this.MemberwiseClone() as Card;
        }

        public override string ToString()
        {
            return string.Format("Rank: {0}\n Suite: {1}", Rank, Suite);
        }
    }
}
