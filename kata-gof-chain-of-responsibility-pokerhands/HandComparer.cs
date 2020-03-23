namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class HandComparer
    {
        private readonly PlayerParser _playerParser = new PlayerParser();

        public string Compare(string input)
        {
            _playerParser.Parse(input);
            var player1 = _playerParser.Player1;
            var player2 = _playerParser.Player2;

            var winner = $"{player2.Name} wins. - with high card: {player2.HighCard}";
            return winner;
        }
    }
}