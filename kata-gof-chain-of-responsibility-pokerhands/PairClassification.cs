namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class PairClassification : HandClassification
    {
        private readonly CardValue _cardValue;

        public PairClassification(CardValue cardValue, string name)
            : base(Rank.Pair, name)
        {
            _cardValue = cardValue;
        }

        protected override bool IsBetterThanHandWithSameRank(HandClassification otherHand)
        {
            var otherHandCast = (PairClassification) otherHand;
            return _cardValue > otherHandCast._cardValue;
        }

        public override string ToWinnerString()
        {
                var message = $"{Name} wins. - with pair: {_cardValue}";
                return message;
        }
    }
}