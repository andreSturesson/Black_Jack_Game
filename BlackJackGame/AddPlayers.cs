using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGame
{
    public partial class AddPlayers : Form
    {
        public static int number;
        public AddPlayers()
        {
            InitializeComponent();
        }

        private void AddPlayers_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < Form1.playerCount; i++)
            {
                Label label = new Label();
                label.Text = "Player: " + i;
                TextBox textBox = new TextBox();
                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(textBox);
            }
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            List<String> players = new List<string>();
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("All players should have a name", "Error!");
                        break;
                    }
                    if (players.Contains(item.Text))
                    {
                        MessageBox.Show("No player can have the same name. \n" + item.Text, "Error!");
                        break;
                    }
                    players.Add(item.Text);
                }
            }
            Form1.startGame = true;
            Form1.playerNames = players;
            this.Close();
        }
    }
}
