using System.Linq;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class PairClassifier : HandClassifier
    {
        public override IHandClassification Classify(Hand hand)
        {
            var nOfAKind = new NOfAKind(hand);

            if (nOfAKind.HasNOfAKind(2))
            {
                var pairCardValue = nOfAKind.NOfAKindValues(2).First();
                return new PairClassification(pairCardValue);
            }

            return Next.Classify(hand);
        }
    }
}