namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class FullHouseClassification : IHandClassification
    {
        private readonly CardValue _tripletCardValue;
        private readonly CardValue _pairCardValue;

        public FullHouseClassification(CardValue tripletCardValue, CardValue pairCardValue)
        {
            _tripletCardValue = tripletCardValue;
            _pairCardValue = pairCardValue;
        }

        public override string ToString()
        {
            var message = $"Full house: {_tripletCardValue} over {_pairCardValue}";
            return message;
        }
    }
}