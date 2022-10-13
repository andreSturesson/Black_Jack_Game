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
        public NewGame()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startGame_Click(object sender, EventArgs e)
        {
            Form1.startGame = true;
            Form1.playerCount = Int32.Parse(playerCount.Text);
            this.Close();
        }

        private void NewGame_Load(object sender, EventArgs e)
        {

        }
    }
}
