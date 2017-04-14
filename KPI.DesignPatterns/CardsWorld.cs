using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab3.Cards;

namespace KPI.DesignPatterns
{
    class CardsWorld : World
    {
        private readonly Deck _deck;
        public CardsWorld()
        {
            _deck = new Deck();
        }

        protected override void RunIteration()
        {
            Console.WriteLine("Type in the number of the card or 'exit'");
            string command;
            while ((command = Console.ReadLine()) != "exit")
            {
                try
                {
                    var number = int.Parse(command);
                    Console.WriteLine(_deck.Cards.ElementAt(number));
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect format.");
                    continue;
                }
            }
        }
    }
}
