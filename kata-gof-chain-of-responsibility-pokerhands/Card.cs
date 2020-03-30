using System.Collections.Generic;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class Card
    {
        public static Card Parse(string input)
        {
            var color = ParseColor(input);
            var value = ParseValue(input);
            var card = new Card {Color = color, Value = value };
            return card;
        }

        private static CardColor ParseColor(string input)
        {
            var mapCharacterToCardColor = new Dictionary<char, CardColor>()
            {
                {'S', CardColor.Spades},
                {'H', CardColor.Hearts},
                {'C', CardColor.Clubs},
                {'D', CardColor.Diamonds},
            };

            var color = mapCharacterToCardColor[input[1]];
            return color;
        }

        private static CardValue ParseValue(string input)
        {
            var mapCharacterToCardValue = new Dictionary<char, CardValue>()
            {
                {'2', CardValue.Two},
                {'3', CardValue.Three},
                {'4', CardValue.Four},
                {'5', CardValue.Five},
                {'6', CardValue.Six},
                {'7', CardValue.Seven},
                {'8', CardValue.Eight},
                {'9', CardValue.Nine},
                {'T', CardValue.Ten},
                {'J', CardValue.Jack},
                {'Q', CardValue.Queen},
                {'K', CardValue.King},
                {'A', CardValue.Ace},
            };

            var value = mapCharacterToCardValue[input[0]];
            return value;
        }

        public CardColor Color { get; private set; } = CardColor.Hearts;

        public CardValue Value { get; private set; } = CardValue.Two;
    }
}