using System.Collections.Generic;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class Card
    {
        public static Card Parse(string input)
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

            var card = new Card();
            card.Value = mapCharacterToCardValue[input[0]];

            var mapCharacterToCardColor = new Dictionary<char, CardColor>()
            {
                {'S', CardColor.Spades},
                {'H', CardColor.Hearts},
                {'C', CardColor.Clubs},
                {'D', CardColor.Diamonds},
            };
            card.Color = mapCharacterToCardColor[input[1]];

            // TODO: Split this function
            return card;
        }

        public CardColor Color { get; private set; } = CardColor.Hearts;

        public CardValue Value { get; private set; } = CardValue.Two;
    }
}