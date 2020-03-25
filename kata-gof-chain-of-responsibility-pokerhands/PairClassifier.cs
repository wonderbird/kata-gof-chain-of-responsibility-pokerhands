namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class PairClassifier : IHandClassifier
    {
        public IHandClassifier Next { get; set; }

        public PairClassifier()
        {
            Next = new HighCardClassifier();
        }

        // TODO: I know the PairClassifier is incomplete.
        public HandClassification Classify(Hand hand)
        {
            hand.CardValues.Sort();

            var isPair = false;
            var pairCardValue = CardValue.Two;

            var cardIndex = 1;
            while (!isPair && cardIndex < hand.CardValues.Count)
            {
                var currentCardValue = hand.CardValues[cardIndex];
                var previousCardValue = hand.CardValues[cardIndex - 1];

                isPair = currentCardValue == previousCardValue;
                pairCardValue = currentCardValue;
                
                cardIndex++;
            }

            if (isPair)
                return new PairClassification(pairCardValue, hand.Name);

            return Next.Classify(hand);
        }
    }
}