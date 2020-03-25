using System;
using System.Collections.Generic;
using System.Linq;

namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class FullHouseClassifier : IHandClassifier
    {
        public IHandClassifier Next { get; set;  }
        public HandClassification Classify(Hand hand)
        {
            throw new Exception("Consolidate this method with the PairClassifier");
            hand.CardValues.Sort();

            var buckets = new Dictionary<CardValue, int>
            {
                { CardValue.Two, 0 },
                { CardValue.Three, 0 },
                { CardValue.Four, 0 },
                { CardValue.Five, 0 },
                { CardValue.Six, 0 },
                { CardValue.Seven, 0 },
                { CardValue.Eight, 0 },
                { CardValue.Nine, 0 },
                { CardValue.Ten, 0 },
                { CardValue.Jack, 0 },
                { CardValue.Queen, 0 },
                { CardValue.King, 0 },
                { CardValue.Ace, 0 },
            };

            foreach (var cardValue in hand.CardValues)
            {
                buckets[cardValue]++;
            }

            const int TRIPLET = 3;
            const int PAIR = 2;

            var hasThreeOfAKind = buckets.Any(valueCountPair => valueCountPair.Value == TRIPLET);
            var hasTwoOfAKind = buckets.Any(valueCountPair => valueCountPair.Value == PAIR);
            var isFullHouse = hasThreeOfAKind && hasTwoOfAKind;

            if (isFullHouse)
            {
                var tripletCardValue = buckets.First(valueCountPair => valueCountPair.Value == TRIPLET).Key;
                var pairCardValue = buckets.First(valueCountPair => valueCountPair.Value == PAIR).Key;

                return new FullHouseClassification(tripletCardValue, pairCardValue, hand.Name);
            }

            return Next.Classify(hand);
        }
    }
}