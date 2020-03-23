namespace kata_gof_chain_of_responsibility_pokerhands
{
    public class Hand
    {
        private const int NameFieldIndex = 0;
        private const int NumberOfCards = 5;

        public string Name { get; }
        public CardValue HighCard { get; private set; }

        public static Hand Parse(string playerInput)
        {
            var inputArray = playerInput.Split(' ');

            var name = inputArray[NameFieldIndex].Remove(inputArray[NameFieldIndex].Length - 1);
            var hand = new Hand(name);

            for (var cardIndex = 1; cardIndex <= NumberOfCards; cardIndex++)
            {
                var card = Card.Parse(inputArray[cardIndex]);
                hand.Add(card);
            }
            return hand;
        }

        private Hand(string name)
        {
            Name = name;
        }

        private void Add(Card card)
        {
            HighCard = CardValue.Ace;
        }
    }
}