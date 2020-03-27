namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class StraightFlushClassifier : IHandClassifier
    {
        public IHandClassifier Next { get; set; }
        public IHandClassification Classify(Hand hand)
        {
            throw new System.NotImplementedException();
        }
    }
}