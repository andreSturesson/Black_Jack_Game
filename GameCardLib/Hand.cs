using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Hand
    {
        private Deck deck;
        private int noCards;
        private int score;

        public Hand()
        {
            this.deck = new Deck();
            this.NoCards = 0;
            this.Score = 0;
        }

        public int NoCards { get => noCards; set => noCards = value; }
        public int Score { get => score; set => score = value; }
        public Deck Deck { get => deck; set => deck = value; }

        public void AddCard(Card card)
        {
            deck.AddCard(card);
            noCards++;
            score += (int)card.Value;
        }

    }
}
