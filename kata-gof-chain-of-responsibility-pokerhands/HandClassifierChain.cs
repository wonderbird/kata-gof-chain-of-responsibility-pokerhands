namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class HandClassifierChain
    {
        private readonly IHandClassifier _root;

        public HandClassifierChain()
        {
            _root = new FullHouseClassifier();
            _root.Next = new PairClassifier();
            _root.Next.Next = new HighCardClassifier();
        }

        public IHandClassification Classify(string handString)
        {
            var hand = Hand.Parse(handString);
            return _root.Classify(hand);
        }
    }
}