using System.Collections.Generic;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class Hand
    {
        private const int NumberOfCards = 5;

        // TODO: Replace the two lists by a single List<Card>

        public List<CardValue> CardValues { get; } = new List<CardValue>();
        public List<CardColor> CardColors { get; set; } = new List<CardColor>();

        public static Hand Parse(string playerInput)
        {
            var inputArray = playerInput.Split(' ');

            var hand = new Hand();

            for (var cardIndex = 0; cardIndex < NumberOfCards; cardIndex++)
            {
                var card = Card.Parse(inputArray[cardIndex]);
                hand.CardValues.Add(card.Value);
                hand.CardColors.Add(card.Color);
            }
            return hand;
        }

        private Hand()
        {
        }
    }
}