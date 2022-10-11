namespace GameCardLib
{
    public class Card
    {
        private Enums.Suit suit;
        private Enums.Values value;

        public Card(Enums.Suit suit, Enums.Values value)
        {
            this.suit = suit;
            this.value = value;
        }


        public Enums.Suit Suit { get => suit; set => suit = value; }
        public Enums.Values Value { get => value; set => this.value = value; }
    }
}