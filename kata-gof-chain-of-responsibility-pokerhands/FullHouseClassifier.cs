using System.Linq;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class FullHouseClassifier : IHandClassifier
    {
        public IHandClassifier Next { get; set;  }
        public IHandClassification Classify(Hand hand)
        {
            var nOfAKindCategorizer = new NOfAKindCategorizer(hand);

            var hasThreeOfAKind = nOfAKindCategorizer.HasNOfAKind(3);
            var hasTwoOfAKind = nOfAKindCategorizer.HasNOfAKind(2);
            var isFullHouse = hasThreeOfAKind && hasTwoOfAKind;

            if (isFullHouse)
            {
                var tripletCardValue = nOfAKindCategorizer.NOfAKindValues(3).First();
                var pairCardValue = nOfAKindCategorizer.NOfAKindValues(2).First();

                return new FullHouseClassification(tripletCardValue, pairCardValue);
            }

            return Next.Classify(hand);
        }
    }
}