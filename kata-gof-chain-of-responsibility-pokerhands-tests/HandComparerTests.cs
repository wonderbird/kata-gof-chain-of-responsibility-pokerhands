using kata_gof_chain_of_responsibility_pokerhands;
using Xunit;

namespace kata_gof_chain_of_responsibility_pokerhands_tests
{
    public class HandComparerTests
    {
        [Theory]
        [InlineData("White wins. - with high card: Ace",  "Black: 2H 3D 5S 9C KD  White: 2C 3H 4S 8C AH")]
        [InlineData("White wins. - with high card: King", "Black: 2H 3D 5S 9C QD  White: 2C 3H 4S 8C KH")]
        public void Compare_HighCard_BlackWinsWithAce(string expected, string input)
        {
            var comparer = new HandComparer();
            var actual = comparer.Compare(input);
            Assert.Equal(expected, actual);
        }
    }
}
