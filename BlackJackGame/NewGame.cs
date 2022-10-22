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
    public partial class NewGame : Form
    {
        private AddPlayers ap = new AddPlayers();
        public NewGame()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startGame_Click(object sender, EventArgs e)
        {
            if (!playerCount.Text.Equals("")|| !numberOfDecks.Text.Equals(""))
            {
                Form1.playerCount = Int32.Parse(playerCount.Text);
                Form1.NumberOfDecks = Int32.Parse(numberOfDecks.Text);
                ap.ShowDialog();
                this.Close();
            }
            else
            {
                //SEND LOGGER EVENT MSG
                //NO TEXTBOXES CAN BE EMPTY...
            }

        }

        private void NewGame_Load(object sender, EventArgs e)
        {

        }
    }
}
