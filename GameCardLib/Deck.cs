﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Deck
    {
        private List<Card> cards;

        public List<Card> Cards { get => cards; set => cards = value; }

        public Deck()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void DeleteAllCards()
        {
            cards.Clear();
        }

        public void Shuffle()
        {
            Cards = Cards.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public Card getAt(int index)
        {
            return cards[index];
        }

        public Card getCard()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public List<Card> getTwoCards()
        {
            List<Card> car = new List<Card>();
            Card card = cards[0];
            Card card1 = cards[1];
            car.Add(card);
            car.Add(card1);
            cards.RemoveAt(0);
            cards.RemoveAt(1);
            return car;
        }

        public int NumberOfCards()
        {
            return Cards.Count;
        }

        public void GenerateCards()
        {
            int index = 0;
            foreach (Enums.Suit suit in Enum.GetValues(typeof(Enums.Suit)))
            {
                foreach (Enums.Values value in Enum.GetValues(typeof(Enums.Values)))
                {
                    Card card = new Card(suit, value);
                    cards.Add(card);
                    index++;
                }
            }
            Shuffle();
        }


    }
}
