using System.Media;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GameCardLib;
using UtilitiesLib;
namespace BlackJackGame
{
    public partial class Form1 : Form
    {
        NewGame ngf = new NewGame();
        public static bool startGame;
        public static int playerCount;
        public static int NumberOfDecks;
        public static List<String> playerNames;
        private int highestScore;
        private Player current;
        Game game;
        int currentPlayer;

        public Form1()
        {
            InitializeComponent();
            playerNames = new List<String>();
            game = new Game(NumberOfDecks);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Newgame()
        {
            game = new Game(NumberOfDecks);
            Hit.Enabled = true;
            Stand.Enabled = true;
            Shuffle.Enabled = true;
            highestScore = 0;
            currentPlayer = 0;
            game.init(playerNames);
            current = game.next();
            updateGUI();
            updateDealer();
        }

        public void gameOver()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to start a new round with same players?", "Play Again", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Newgame();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        public void checkWin()
        {
            if (currentPlayer >= playerCount)
            {
                game.DealerHit();
                updateDealer();
                List<Player> Winners = game.returnWinner();
                String names = "";
                String scores = "";
                foreach (Player player in Winners)
                {
                    names += ", " + player.Name1;
                    scores += ", " + player.Hand.Score;
                }
                if (Winners.Count == 0)
                {
                    MessageBox.Show("Its a draw!", "Game Over");
                }
                else
                {
                    Logger log = new Logger("Winner(s) is:" + names + " With a score of: " + scores);
                    MessageBox.Show("Winner(s) is:" + names + "\nWith a score of: " + scores, "Game Over");
                }
                gameOver();
            }
        }

        public PictureBox newPictureBox(Card card)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\img\\" + card.Value.ToString() + card.Suit.ToString() + ".png"))
            {
                PictureBox pb = new PictureBox()
                {
                    Name = card.Value.ToString() + " " + card.Suit.ToString(),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(75, 90),
                };
                if(card.Visible)
                    pb.ImageLocation = Directory.GetCurrentDirectory() + "\\img\\" + card.Value.ToString() + card.Suit.ToString() + ".png";
                else
                    pb.ImageLocation = Directory.GetCurrentDirectory() + "\\img\\" + "back.png";
                return pb;
            }
            return new PictureBox();
        }

        public void updateDealer()
        {
            DealerCardImages.Controls.Clear();
            int score = game.Dealer.Hand.Score;
            foreach (Card card in game.Dealer.Hand.Deck.Cards)
            {
                DealerCardImages.Controls.Add(newPictureBox(card));
                if (!card.Visible)
                    score = score - (int)card.Value;
                card.Visible = true;
            }
            DealerScore.Text = "Dealer Score: " + score;
        }

        public void updatePlayer()
        {
            PlayerCardImages.Controls.Clear();
            PlayerNameBox.Text = current.Name1 + " [" + currentPlayer + " out of " + playerCount + " players]";
            PlayerScore.Text = "Player Score: " + current.Hand.Score;
            foreach (Card card in current.Hand.Deck.Cards)
            {
                PlayerCardImages.Controls.Add(newPictureBox(card));
            }
            if (current.Hand.Score > 21)
            {
                Hit.Enabled = false;
                Shuffle.Enabled = false;
            } else
            {
                Hit.Enabled = true;
                Shuffle.Enabled = true;
            }
            game.isHighScore(current);
        }

        public void updateGUI()
        {
            checkWin();
            updatePlayer();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            ngf.ShowDialog();
            if (startGame)
                Newgame();

        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to shuffle?", "Shuffle Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                game.MainDeck.Shuffle();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void Hit_Click(object sender, EventArgs e)
        {
            if (current.Hand.Score >= 21)
            {
                game.Players[currentPlayer].IsFinished = true;
                updateGUI();
                return;
            }
            game.hit(current);
            updateGUI();
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            game.stand(current);
            current.IsFinished = true;
            currentPlayer++;
            current = game.next();
            updateGUI();
        }

        private void DealerScore_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayerNameBox_Enter(object sender, EventArgs e)
        {

        }

        private void DealerCardImages_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
