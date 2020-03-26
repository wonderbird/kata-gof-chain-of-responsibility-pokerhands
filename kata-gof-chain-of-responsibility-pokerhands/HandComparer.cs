using System;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class HandComparer
    {
        private readonly GameInputParser _gameInputParser = new GameInputParser();
        private HandClassifierChain _handClassifierChain;

        public string Compare(string input)
        {
            _gameInputParser.Parse(input);

            _handClassifierChain = new HandClassifierChain();

            var inputSplitByHand = input.Split("  ");
            var classificationPlayer1 = ClassifyHand(inputSplitByHand[0]);
            var classificationPlayer2 = ClassifyHand(inputSplitByHand[1]);

            throw new Exception("Continue: Change the scope of the kata to just classify a single hand. Otherwise the composition of patterns gets more complex.");

            var winner = classificationPlayer1.IsBetterThan(classificationPlayer2)
                ? classificationPlayer1
                : classificationPlayer2;
            var winnerMessage = winner.ToWinnerString();

            return winnerMessage;
        }

        private HandClassification ClassifyHand(string input)
        {
            var classificationPlayer1 = _handClassifierChain.Classify(input);
            return classificationPlayer1;
        }
    }
}