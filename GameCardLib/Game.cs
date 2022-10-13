using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Game
    {
        private List<Player> players;
        private Player dealer;
        private Deck mainDeck;
        private int round;

        public List<Player> Players { get => players; set => players = value; }
        public Player Dealer { get => dealer; set => dealer = value; }
        public Deck MainDeck { get => mainDeck; set => mainDeck = value; }

        public Game()
        {
            this.round = 0;
            this.dealer = new Player(Guid.NewGuid(), "Dealer");
            this.players = new List<Player>();
            this.mainDeck = new Deck();
            this.mainDeck.GenerateCards();
        }

        public bool isWinner(Player player)
        {
            return true;
        }

        public void hit(Player player)
        {
            Card card = mainDeck.getCard();
            player.Hand.AddCard(card);
        }

        public void stand(Player player)
        {
            player.IsFinished = true;
        }




        public void init(int playerCount)
        {
            this.Dealer = new Player(Guid.NewGuid(), "Dealer");
            for (int i = 1; i < playerCount+1; i++)
            {
                Guid id = Guid.NewGuid();
                Player p = new Player(id, "Player " + i);
                p.Hand.AddCard(mainDeck.getCard());
                p.Hand.AddCard(mainDeck.getCard());
                players.Add(new Player(id, "Player " + i));
            }
            dealer.Hand.AddCard(mainDeck.getCard());


        }
    }
}
