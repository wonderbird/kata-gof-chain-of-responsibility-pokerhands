using System.Linq;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class StraightFlushClassifier : HandClassifier
    {
        public override IHandClassification Classify(Hand hand)
        {
            var areValuesAscending = AreValuesAscending(hand);
            var areColorsSame = AreColorsSame(hand);
            var isStraitFlush = areValuesAscending && areColorsSame;

            if (isStraitFlush)
            {
                var highCard = hand.CardValues.Max();
                return new StraightFlushClassification(highCard);
            }

            return Next.Classify(hand);
        }

        private bool AreColorsSame(Hand hand)
        {
            var areColorsSame = true;

            var colorEnumerator = hand.CardColors.GetEnumerator();
            colorEnumerator.MoveNext();
            var firstColor = colorEnumerator.Current;

            while (colorEnumerator.MoveNext())
            {
                areColorsSame = areColorsSame && (firstColor == colorEnumerator.Current);
            }

            return areColorsSame;
        }

        private bool AreValuesAscending(Hand hand)
        {
            var sortedCardValues = hand.CardValues.ToList();
            sortedCardValues.Sort();

            var areValuesAscending = true;
            for (var index = 1; index < sortedCardValues.Count; index++)
            {
                var previousValue = sortedCardValues[index - 1];
                var currentValue = sortedCardValues[index];
                areValuesAscending = areValuesAscending && (currentValue == previousValue + 1);
            }

            return areValuesAscending;
        }
    }
}