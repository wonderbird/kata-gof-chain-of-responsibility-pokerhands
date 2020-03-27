using System.Collections.Generic;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class Hand
    {
        private const int NumberOfCards = 5;

        public List<CardValue> CardValues { get; } = new List<CardValue>();

        public static Hand Parse(string playerInput)
        {
            var inputArray = playerInput.Split(' ');

            var hand = new Hand();

            for (var cardIndex = 0; cardIndex < NumberOfCards; cardIndex++)
            {
                var card = Card.Parse(inputArray[cardIndex]);
                hand.CardValues.Add(card.Value);
            }
            return hand;
        }

        private Hand()
        {
        }
    }
}