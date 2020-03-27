namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class HighCardClassification : IHandClassification
    {
        private readonly CardValue _cardValue;

        public HighCardClassification(CardValue cardValue)
        {
            _cardValue = cardValue;
        }

        public override string ToString()
        {
            var message = $"High card: {_cardValue}";
            return message;
        }
    }
}