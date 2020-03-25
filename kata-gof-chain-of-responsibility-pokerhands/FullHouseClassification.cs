namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class FullHouseClassification : HandClassification
    {
        private CardValue _tripletCardValue;
        private CardValue _pairCardValue;

        public FullHouseClassification(CardValue tripletCardValue, CardValue pairCardValue, string name)
            : base(Rank.FullHouse, name)
        {
            _tripletCardValue = tripletCardValue;
            _pairCardValue = pairCardValue;
        }

        protected override bool IsBetterThanHandWithSameRank(HandClassification otherHand)
        {
            return false;
        }

        public override string ToWinnerString()
        {
            return $"{Name} wins. - with full house: {_tripletCardValue} over {_pairCardValue}";
        }
    }
}