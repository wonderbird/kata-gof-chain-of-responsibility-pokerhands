namespace kata_gof_chain_of_responsibility_pokerhands
{
    public interface IHandClassifier
    {
        public IHandClassifier Next { get; set; }

        HandClassification Classify(Hand hand);
    }
}