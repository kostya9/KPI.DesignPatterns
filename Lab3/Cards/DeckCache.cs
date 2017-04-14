using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Cards
{
    class DeckCache
    {
        private static DeckCache _instance;
        public static DeckCache Instance => _instance ?? (_instance = new DeckCache());

        private readonly Card _spades;
        private readonly Card _hearts;
        private readonly Card _diamonds;
        private readonly Card _clubs;


        private DeckCache()
        {
            _spades = new Card(CardSuite.Spades);
            _clubs = new Card(CardSuite.Clubs);
            _diamonds = new Card(CardSuite.Diamonds);
            _hearts = new Card(CardSuite.Hearts);
        }

        public Card Spades()
        {
            return _spades.Clone();
        }

        public Card Hearts()
        {
            return _hearts.Clone();
        }

        public Card Diamonds()
        {
            return _diamonds.Clone();
        }

        public Card Clubs()
        {
            return _clubs.Clone();
        }
    }
}
