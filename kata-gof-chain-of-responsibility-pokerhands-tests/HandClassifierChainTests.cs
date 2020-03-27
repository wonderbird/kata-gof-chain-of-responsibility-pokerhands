using kata_gof_chain_of_responsibility_pokerhands;
using Xunit;

namespace kata_gof_chain_of_responsibility_pokerhands_tests
{
    public class HandClassifierChainTests
    {
        [Theory]
        [InlineData("High card: Ace", "2C 3H 4S 8C AH")]
        [InlineData("High card: King", "2C 3H 4S 8C KH")]
        [InlineData("High card: Seven", "2C 3H 4S 5C 7H")]
        public void Classify_HighCard(string expected, string input)
        {
            var classifier = new HandClassifierChain();
            var actual = classifier.Classify(input).ToString();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Pair: Ace", "2C 3H 4S AC AH")]
        [InlineData("Pair: Five", "2H 3D 5S 5C AD")]
        public void Classify_Pair(string expected, string input)
        {
            var classifier = new HandClassifierChain();
            var actual = classifier.Classify(input).ToString();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Full house: Four over Two", "2H 4S 4C 2D 4H")]
        [InlineData("Full house: King over Jack", "JS KS JS KS KS")]
        public void Classify_FullHouse(string expected, string input)
        {
            var classifier = new HandClassifierChain();
            var actual = classifier.Classify(input).ToString();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Straight flush: Ace", "TH JH QH KH AH")]
        [InlineData("High card: Ace", "TH JH QD KC AS")]
        public void Classify_StraightFlush(string expected, string input)
        {
            var classifier = new HandClassifierChain();
            var actual = classifier.Classify(input).ToString();
            Assert.Equal(expected, actual);
        }
    }
}