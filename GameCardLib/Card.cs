namespace GameCardLib
{
    public class Card
    {
        private Enums.Suit suit;
        private Enums.Values value;
        private bool visible;

        public Card(Enums.Suit suit, Enums.Values value)
        {
            this.suit = suit;
            this.value = value;
            this.visible = true;
        }


        public Enums.Suit Suit { get => suit; set => suit = value; }
        public Enums.Values Value { get => value; set => this.value = value; }
        public bool Visible { get => visible; set => visible = value; }

        public String cardToString()
        {
            return this.suit.ToString() + " " + this.value.ToString();
        }
    }
}