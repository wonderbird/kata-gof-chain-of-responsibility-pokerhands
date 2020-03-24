using System;
using static System.String;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class HandComparer
    {
        private readonly PlayerParser _playerParser = new PlayerParser();

        public string Compare(string input)
        {
            _playerParser.Parse(input);
            var player1 = _playerParser.Player1;
            var player2 = _playerParser.Player2;

            var winnerMessage = PairClassifier(player2);

            if (IsNullOrEmpty(winnerMessage))
            {
                winnerMessage = HighCardClassifier(player1, player2);
            }

            throw new Exception("Clean up the HandComparer class, extract classifiers, make classifiers per Player");

            return winnerMessage;
        }

        private static string HighCardClassifier(Hand player1, Hand player2)
        {
            var winner = player1.HighCard > player2.HighCard ? player1 : player2;
            var winnerMessage = $"{winner.Name} wins. - with high card: {winner.HighCard}";
            return winnerMessage;
        }

        private static string PairClassifier(Hand player2)
        {
            player2.CardValues.Sort();

            var isPair = false;
            var cardIndex = 1;
            while (!isPair && cardIndex < player2.CardValues.Count)
            {
                isPair = player2.CardValues[cardIndex] == player2.CardValues[cardIndex - 1];
                cardIndex++;
            }

            var winnerMessage = Empty;

            if (isPair)
            {
                winnerMessage = $"{player2.Name} wins. - with pair: Ace";
            }

            return winnerMessage;
        }
    }
}