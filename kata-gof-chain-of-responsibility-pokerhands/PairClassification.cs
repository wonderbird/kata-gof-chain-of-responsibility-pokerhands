namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class PairClassification : IHandClassification
    {
        private readonly CardValue _cardValue;

        public PairClassification(CardValue cardValue)
        {
            _cardValue = cardValue;
        }

        public override string ToString()
        {
            var message = $"Pair: {_cardValue}";
            return message;
        }
    }
}