namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class HighCardClassification : HandClassification
    {
        private readonly CardValue _cardValue;

        public HighCardClassification(CardValue cardValue, string name)
            : base(Rank.HighCard, name)
        {
            _cardValue = cardValue;
        }

        protected override bool IsBetterThanHandWithSameRank(HandClassification otherHand)
        {
            var otherHandCast = (HighCardClassification) otherHand;
            return _cardValue > otherHandCast._cardValue;
        }

        public override string ToWinnerString()
        {
            var message = $"{Name} wins. - with high card: {_cardValue}";
            return message;
        }
    }
}