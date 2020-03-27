using System.Net.Http;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class StraightFlushClassifier : IHandClassifier
    {
        public IHandClassifier Next { get; set; }
        public IHandClassification Classify(Hand hand)
        {
            hand.CardValues.Sort();

            var isStraitFlush = true;
            for (var index = 1; index < hand.CardValues.Count; index++)
            {
                var previousValue = hand.CardValues[index - 1];
                var currentValue = hand.CardValues[index];
                isStraitFlush = isStraitFlush && (currentValue == previousValue + 1);

                var previousColor = hand.CardColors[index - 1];
                var currentColor = hand.CardColors[index];
                isStraitFlush = isStraitFlush && (currentColor == previousColor);
            }

            if (isStraitFlush)
            {
                var highCard = hand.CardValues[^1];
                return new StraightFlushClassification(highCard);
            }

            return Next.Classify(hand);
        }
    }

    public class StraightFlushClassification : IHandClassification
    {
        private CardValue _highCard;

        public StraightFlushClassification(CardValue highCard)
        {
            _highCard = highCard;
        }

        public override string ToString()
        {
            var message = $"Straight flush: {_highCard}";
            return message;
        }
    }
}