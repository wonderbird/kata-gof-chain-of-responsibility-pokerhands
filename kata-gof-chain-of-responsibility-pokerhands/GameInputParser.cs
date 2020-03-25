namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class GameInputParser
    {
        private const int Hand1Index = 0;
        private const int Hand2Index = 1;
        public Hand Hand1;
        public Hand Hand2;


        public void Parse(string input)
        {
            var playersInput = input.Split("  ");

            Hand1 = Hand.Parse(playersInput[Hand1Index]);
            Hand2 = Hand.Parse(playersInput[Hand2Index]);
        }
    }
}