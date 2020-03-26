namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class HandComparer
    {
        private readonly GameInputParser _gameInputParser = new GameInputParser();

        public string Compare(string input)
        {
            _gameInputParser.Parse(input);
            var hand1 = _gameInputParser.Hand1;
            var hand2 = _gameInputParser.Hand2;

            var classifierChain = new FullHouseClassifier();
            classifierChain.Next = new PairClassifier();
            classifierChain.Next.Next = new HighCardClassifier();


            var classificationPlayer1 = classifierChain.Classify(hand1);
            var classificationPlayer2 = classifierChain.Classify(hand2);

            var winner = classificationPlayer1.IsBetterThan(classificationPlayer2)
                ? classificationPlayer1
                : classificationPlayer2;
            var winnerMessage = winner.ToWinnerString();

            return winnerMessage;
        }
    }
}