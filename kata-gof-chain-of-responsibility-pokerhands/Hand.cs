using System.Collections.Generic;
using System.Linq;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class Hand
    {
        private const int NumberOfCards = 5;

        public List<Card> Cards { get; } = new List<Card>();
        public IEnumerable<CardValue> CardValues => Cards.Select(c => c.Value);
        public IEnumerable<CardColor> CardColors => Cards.Select(c => c.Color);

        public static Hand Parse(string playerInput)
        {
            var inputArray = playerInput.Split(' ');

            var hand = new Hand();

            for (var cardIndex = 0; cardIndex < NumberOfCards; cardIndex++)
            {
                var card = Card.Parse(inputArray[cardIndex]);
                hand.Cards.Add(card);
            }

            return hand;
        }

        private Hand()
        {
        }
    }
}