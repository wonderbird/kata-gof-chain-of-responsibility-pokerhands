using System.Linq;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class PairClassifier : IHandClassifier
    {
        public IHandClassification Classify(Hand hand)
        {
            var nOfAKindCategorizer = new NOfAKindCategorizer(hand);

            if (nOfAKindCategorizer.HasNOfAKind(2))
            {
                var pairCardValue = nOfAKindCategorizer.NOfAKindValues(2).First();
                return new PairClassification(pairCardValue);
            }

            return Next.Classify(hand);
        }

        public IHandClassifier Next { get; set; }
    }
}