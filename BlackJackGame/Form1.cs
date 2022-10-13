using System.Media;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GameCardLib;
namespace BlackJackGame
{
    public partial class Form1 : Form
    {
        NewGame ngf = new NewGame();
        public static bool startGame;
        public static int playerCount;
        private int highestScore;
        Game game;
        int currentPlayer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool isWinner(Player player)
        {
            return true;
        }

        public void Newgame()
        {
            Hit.Enabled = true;
            Stand.Enabled = true;
            Shuffle.Enabled = true;
            game = new Game();
            game.init(playerCount);
            updateGUI();
        }

        public void gameOver()
        {
            MessageBox.Show(winnerLabel.Text, "Game Over");
            currentPlayer = 0;
            highestScore = 0;
            playerCount = 0;
            DialogResult dialogResult = MessageBox.Show("Do you want to start a new round with same players?", "Play Again", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                game.MainDeck = new Deck();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        public void checkWin()
        {
            if (currentPlayer >= playerCount)
            {
                while (true)
                {
                    if (game.Dealer.Hand.Score > 13)
                        break;
                    game.hit(game.Dealer);
                }
                game.stand(game.Dealer);
                updateDealer();
                int score = 0;
                foreach (Player player in game.Players)
                {
                    if (player.Hand.Score <= 21 && player.Hand.Score >= highestScore)
                        if (game.Dealer.Hand.Score <= 21 && game.Dealer.Hand.Score > highestScore)
                        {
                            game.Dealer.IsWinner = true;
                            winnerLabel.Visible = true;
                            winnerLabel.Text = "Winner is: " + game.Dealer.Name1 + " With a score of: " + game.Dealer.Hand.Score;
                        }
                        else
                        {
                            player.IsWinner = true;
                            winnerLabel.Visible = true;
                            winnerLabel.Text = "Winner is: " + player.Name1 + " With a score of: " + player.Hand.Score + "HighestScore: " + highestScore;
                        }
                }
                gameOver();
            }
        }

        public void updateDealer()
        {
            DealerCardImages.Controls.Clear();
            DealerScore.Text = "Dealer Score: " + game.Dealer.Hand.Score;
            foreach (Card card in game.Dealer.Hand.Deck.Cards)
            {
                PictureBox pb = new PictureBox()
                {
                    Name = card.Value.ToString() + " " + card.Suit.ToString(),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(75, 90),
                    ImageLocation = Directory.GetCurrentDirectory() + "\\img\\" + card.Value.ToString() + card.Suit.ToString() + ".png"
                };
                DealerCardImages.Controls.Add(pb);
            }
        }

        public void updatePlayer()
        {
            PlayerCardImages.Controls.Clear();
            PlayerNameBox.Text = game.Players[currentPlayer].Name1;
            PlayerScore.Text = "Player Score: " + game.Players[currentPlayer].Hand.Score;
            foreach (Card card in game.Players[currentPlayer].Hand.Deck.Cards)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\img\\" + card.Value.ToString() + card.Suit.ToString() + ".png"))
                {
                    PictureBox pb = new PictureBox()
                    {
                        Name = card.Value.ToString() + " " + card.Suit.ToString(),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new Size(75, 90),
                        ImageLocation = Directory.GetCurrentDirectory() + "\\img\\" + card.Value.ToString() + card.Suit.ToString() + ".png"
                    };
                    PlayerCardImages.Controls.Add(pb);
                }
            }
        }

        public void updateGUI()
        {
            checkWin();
            updateDealer();
            updatePlayer();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            ngf.ShowDialog();
            if (startGame)
                Newgame();

        }

        private void PlayerCards_Click(object sender, EventArgs e)
        {

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
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void isHighScore()
        {
            if (game.Players[currentPlayer].Hand.Score > highestScore && game.Players[currentPlayer].Hand.Score < 21)
            {
                highestScore = game.Players[currentPlayer].Hand.Score;
            }
        }

        private void Hit_Click(object sender, EventArgs e)
        {
            if (game.Players[currentPlayer].Hand.Score >= 21)
            {
                game.Players[currentPlayer].IsFinished = true;
                isHighScore();
                updateGUI();
            }
            game.hit(game.Players[currentPlayer]);
            updateGUI();
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            game.stand(game.Players[currentPlayer]);
            game.Players[currentPlayer].IsFinished = true;
            isHighScore();
            currentPlayer++;
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
    }
}
