using System.Linq;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class FullHouseClassifier : HandClassifier
    {
        public override IHandClassification Classify(Hand hand)
        {
            var nOfAKind = new NOfAKind(hand);

            var hasThreeOfAKind = nOfAKind.HasNOfAKind(3);
            var hasTwoOfAKind = nOfAKind.HasNOfAKind(2);
            var isFullHouse = hasThreeOfAKind && hasTwoOfAKind;

            if (isFullHouse)
            {
                var tripletCardValue = nOfAKind.NOfAKindValues(3).First();
                var pairCardValue = nOfAKind.NOfAKindValues(2).First();

                return new FullHouseClassification(tripletCardValue, pairCardValue);
            }

            return Next.Classify(hand);
        }
    }
}