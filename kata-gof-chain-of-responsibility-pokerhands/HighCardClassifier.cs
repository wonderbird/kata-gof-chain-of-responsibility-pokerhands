using System.Linq;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class HighCardClassifier : HandClassifier
    {
        public override IHandClassification Classify(Hand hand)
        {
            var highCard = hand.CardValues.Max();
            return new HighCardClassification(highCard);
        }
    }
}