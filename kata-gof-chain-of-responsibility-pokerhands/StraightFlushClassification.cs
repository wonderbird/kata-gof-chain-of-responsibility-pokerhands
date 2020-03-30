namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class StraightFlushClassification : IHandClassification
    {
        private readonly CardValue _highCard;

        public StraightFlushClassification(CardValue highCard)
        {
            _highCard = highCard;
        }

        public override string ToString()
        {
            var message = $"Straight flush: {_highCard}";
            return message;
        }
    }
}