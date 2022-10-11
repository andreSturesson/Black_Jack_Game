using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    internal class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            GenerateCards();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void DeleteAllCards()
        {
            cards = null;
        }

        public Card getAt(int index)
        {
            return cards[index];
        }

        public int NumberOfCards()
        {
            return cards.Count;
        }

        public void GenerateCards()
        {
            int index = 0;
            foreach (Enums.Suit suit in Enum.GetValues(typeof(Enums.Suit)))
            {
                foreach (Enums.Values value in Enum.GetValues(typeof(Enums.Values)))
                {
                    Card card = new Card(suit, value);
                    cards[index] = card;
                    index++;
                }
            }
        }


    }
}
