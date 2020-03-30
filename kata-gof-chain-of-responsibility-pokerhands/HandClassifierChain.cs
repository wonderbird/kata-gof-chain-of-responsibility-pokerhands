namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class HandClassifierChain
    {
        private readonly HandClassifier _root;

        public HandClassifierChain()
        {
            _root = new StraightFlushClassifier();

            _root.RegisterNext(new FullHouseClassifier())
                .RegisterNext(new PairClassifier())
                .RegisterNext(new HighCardClassifier());
        }

        public IHandClassification Classify(string handString)
        {
            var hand = Hand.Parse(handString);
            return _root.Classify(hand);
        }
    }
}