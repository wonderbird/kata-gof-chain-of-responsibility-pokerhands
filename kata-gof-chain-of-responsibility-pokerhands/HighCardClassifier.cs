using System;
using System.Linq;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class HighCardClassifier : IHandClassifier
    {
        public IHandClassifier Next
        {
            get =>
                throw new InvalidOperationException(
                    "Invalid call to property \"Next\". HighCardClassifier is the last classifier in the chain.");
            set =>
                throw new InvalidOperationException(
                    "Invalid call to property \"Next\". HighCardClassifier is the last classifier in the chain.");
        }

        public HandClassification Classify(Hand hand)
        {
            var highCard = hand.CardValues.Max();
            return new HighCardClassification(highCard, hand.Name);
        }
    }
}