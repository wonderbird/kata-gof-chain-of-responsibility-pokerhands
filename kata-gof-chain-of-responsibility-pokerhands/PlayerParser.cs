namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class PlayerParser
    {
        private const int Player1Index = 0;
        private const int Player2Index = 1;
        public Hand Player1;
        public Hand Player2;


        public void Parse(string input)
        {
            var playersInput = input.Split("  ");

            Player1 = Hand.Parse(playersInput[Player1Index]);
            Player2 = Hand.Parse(playersInput[Player2Index]);
        }
    }
}