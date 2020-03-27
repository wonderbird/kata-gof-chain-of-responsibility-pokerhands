using System;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class HandClassifierChain
    {
        private readonly IHandClassifier _root;

        public HandClassifierChain()
        {
            throw new Exception("Fix the //TODOs");
            // TODO: Make the chain initialization more beautiful
            _root = new StraightFlushClassifier();
            _root.Next = new FullHouseClassifier();
            _root.Next.Next = new PairClassifier();
            _root.Next.Next.Next = new HighCardClassifier();
        }

        public IHandClassification Classify(string handString)
        {
            var hand = Hand.Parse(handString);
            return _root.Classify(hand);
        }
    }
}