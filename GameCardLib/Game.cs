using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;

namespace GameCardLib
{
    public class Game
    {
        private List<Player> players;
        private Player dealer;
        private Deck mainDeck;
        private int highestScore;
        private int round;
        private Events e;

        public List<Player> Players { get => players; set => players = value; }
        public Player Dealer { get => dealer; set => dealer = value; }
        public Deck MainDeck { get => mainDeck; set => mainDeck = value; }

        public Game(int NumberOfDecks)
        {
            e = new Events();
            this.round = 0;
            this.dealer = new Player(Guid.NewGuid(), "Dealer");
            this.players = new List<Player>();
            this.mainDeck = new Deck();
            this.mainDeck.NumberOfDecks = NumberOfDecks;
            this.mainDeck.GenerateCards();
        }

        public bool isWinner(Player player)
        {
            return true;
        }

        public void hit(Player player)
        {
            var events = new Events();
            Card card = mainDeck.getCard();
            foreach (Card c in player.Hand.Deck.Cards) {
                if(c == card)
                {
                    mainDeck.AddCard(c);
                    card = mainDeck.getCard();
                }
            }
            player.Hand.AddCard(card);
            e.OnHit(player, card);
        }

        public void stand(Player player)
        {
            player.IsFinished = true;
            e.OnStand(player);
        }

        public Player next()
        {
            foreach (Player player in this.players)
            {
                if (!player.IsFinished)
                    return player;
            }
            return dealer;
        }

        public void DealerHit()
        {
            while (true)
            {
                if (Dealer.Hand.Score > 14)
                    break;
                hit(Dealer);
            }
            stand(Dealer);
        }

        public void isHighScore(Player current)
        {
            if (current.Hand.Score > highestScore && current.Hand.Score <= 21)
            {
                highestScore = current.Hand.Score;
            }
        }

        public List<Player> returnWinner()
        {
            List<Player> Winners = new List<Player>();
            foreach (Player player in Players)
            {
                if (player.Hand.Score <= 21)
                {
                    if (Dealer.Hand.Score <= 21 && player.Hand.Score > Dealer.Hand.Score)
                    {
                        player.IsWinner = true;
                        Winners.Add(player);
                    }
                }
            }
            if (Dealer.Hand.Score <= 21 && Dealer.Hand.Score > highestScore)
            {
                Winners.Clear();
                Dealer.IsWinner = true;
                Winners.Add(Dealer);
            }
            return Winners;
        }

        public void init(List<String> playerNames)
        {
            this.Dealer = new Player(Guid.NewGuid(), "Dealer");
            foreach (String play in playerNames)
            {
                Guid id = Guid.NewGuid();
                Player p = new Player(id, play);
                p.Hand.AddCard(mainDeck.getCard());
                p.Hand.AddCard(mainDeck.getCard());
                players.Add(p);
            }
            dealer.Hand.AddCard(mainDeck.getCard());
            Card card = mainDeck.getCard();
            card.Visible = false;
            dealer.Hand.AddCard(card);
            e.PlayerEvent += (s, args) =>
            {
                Logger log = new Logger(args.Info);
            };


        }
    }
}
