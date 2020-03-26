using System.Collections.Generic;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public abstract class HandClassification
    {
        protected string Name { get; }
        private Rank Rank { get; }

        protected HandClassification(Rank rank, string name)
        {
            Rank = rank;
            Name = name;
        }

        public bool IsBetterThan(HandClassification otherHand)
        {
            if (Rank == otherHand.Rank)
            {
                return IsBetterThanHandWithSameRank(otherHand);
            }
            return Rank > otherHand.Rank;
        }

        public bool IsEqualTo(HandClassification otherHand)
        {
            return !IsBetterThan(otherHand) && !otherHand.IsBetterThan(this);
        }

        protected abstract bool IsBetterThanHandWithSameRank(HandClassification otherHand);
        
        public abstract string ToWinnerString();

    }
}