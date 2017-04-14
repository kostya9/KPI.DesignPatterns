using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Cards
{
    public class Deck
    {
        public IReadOnlyCollection<Card> Cards { get; private set; }

        public Deck()
        {
            var list = new List<Card>();
            foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
            {
                var clubs = DeckCache.Instance.Clubs();
                clubs.Rank = rank;
                var diamonds = DeckCache.Instance.Diamonds();
                diamonds.Rank = rank;
                var hearts = DeckCache.Instance.Hearts();
                hearts.Rank = rank;
                var spades = DeckCache.Instance.Spades();
                spades.Rank = rank;
                list.AddRange(new [] {clubs, diamonds, hearts, spades});

                Cards = list.AsReadOnly();
            }
        }
    }
}
