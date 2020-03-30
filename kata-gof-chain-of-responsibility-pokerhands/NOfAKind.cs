using System.Collections.Generic;
using System.Linq;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class NOfAKind
    {
        private readonly Dictionary<CardValue, int> _mapCardValueToOccurrences = new Dictionary<CardValue, int>
        {
            {CardValue.Two, 0},
            {CardValue.Three, 0},
            {CardValue.Four, 0},
            {CardValue.Five, 0},
            {CardValue.Six, 0},
            {CardValue.Seven, 0},
            {CardValue.Eight, 0},
            {CardValue.Nine, 0},
            {CardValue.Ten, 0},
            {CardValue.Jack, 0},
            {CardValue.Queen, 0},
            {CardValue.King, 0},
            {CardValue.Ace, 0},
        };

        public NOfAKind(Hand hand)
        {
            foreach (var cardValue in hand.CardValues)
            {
                _mapCardValueToOccurrences[cardValue]++;
            }
        }

        public bool HasNOfAKind(int n)
        {
            return _mapCardValueToOccurrences.Any(valueCountPair => valueCountPair.Value == n);
        }

        public IEnumerable<CardValue> NOfAKindValues(int n)
        {
            return _mapCardValueToOccurrences.Where(valueCountPair => valueCountPair.Value == n)
                .Select(valueCountPair => valueCountPair.Key);
        }

    }
}