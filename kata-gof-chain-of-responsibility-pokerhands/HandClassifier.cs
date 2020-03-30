namespace kata_gof_chain_of_responsibility_pokerhands
{
    public abstract class HandClassifier
    {
        protected HandClassifier Next { get; private set; }

        public abstract IHandClassification Classify(Hand hand);

        public HandClassifier RegisterNext(HandClassifier next)
        {
            Next = next;
            return Next;
        }
    }
}