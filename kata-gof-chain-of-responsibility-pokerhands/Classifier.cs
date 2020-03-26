namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class Classifier
    {
        private readonly IHandClassifier _root;

        public Classifier()
        {
            _root = new FullHouseClassifier();
            _root.Next = new PairClassifier();
            _root.Next.Next = new HighCardClassifier();
        }

        public HandClassification Classify(Hand hand)
        {
            return _root.Classify(hand);
        }
    }
}