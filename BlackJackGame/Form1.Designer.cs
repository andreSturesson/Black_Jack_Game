namespace BlackJackGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewGame = new System.Windows.Forms.Button();
            this.Shuffle = new System.Windows.Forms.Button();
            this.Hit = new System.Windows.Forms.Button();
            this.Stand = new System.Windows.Forms.Button();
            this.DealerScore = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.PlayerCardImages = new System.Windows.Forms.FlowLayoutPanel();
            this.DealerCardImages = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerNameBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.PlayerNameBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(713, 143);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Shuffle
            // 
            this.Shuffle.Enabled = false;
            this.Shuffle.Location = new System.Drawing.Point(713, 194);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(75, 23);
            this.Shuffle.TabIndex = 2;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // Hit
            // 
            this.Hit.Enabled = false;
            this.Hit.Location = new System.Drawing.Point(713, 258);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(75, 23);
            this.Hit.TabIndex = 3;
            this.Hit.Text = "Hit";
            this.Hit.UseVisualStyleBackColor = true;
            this.Hit.Click += new System.EventHandler(this.Hit_Click);
            // 
            // Stand
            // 
            this.Stand.Enabled = false;
            this.Stand.Location = new System.Drawing.Point(713, 313);
            this.Stand.Name = "Stand";
            this.Stand.Size = new System.Drawing.Size(75, 23);
            this.Stand.TabIndex = 4;
            this.Stand.Text = "Stand";
            this.Stand.UseVisualStyleBackColor = true;
            this.Stand.Click += new System.EventHandler(this.Stand_Click);
            // 
            // DealerScore
            // 
            this.DealerScore.AutoSize = true;
            this.DealerScore.Location = new System.Drawing.Point(0, 380);
            this.DealerScore.Name = "DealerScore";
            this.DealerScore.Size = new System.Drawing.Size(78, 15);
            this.DealerScore.TabIndex = 8;
            this.DealerScore.Text = "Dealer Score: ";
            this.DealerScore.Click += new System.EventHandler(this.DealerScore_Click);
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Location = new System.Drawing.Point(6, 376);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(77, 15);
            this.PlayerScore.TabIndex = 9;
            this.PlayerScore.Text = "Player Score: ";
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(296, 27);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(51, 15);
            this.winnerLabel.TabIndex = 10;
            this.winnerLabel.Text = "Winner: ";
            this.winnerLabel.Visible = false;
            // 
            // PlayerCardImages
            // 
            this.PlayerCardImages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayerCardImages.Location = new System.Drawing.Point(6, 23);
            this.PlayerCardImages.Name = "PlayerCardImages";
            this.PlayerCardImages.Size = new System.Drawing.Size(332, 350);
            this.PlayerCardImages.TabIndex = 11;
            this.PlayerCardImages.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // DealerCardImages
            // 
            this.DealerCardImages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DealerCardImages.Location = new System.Drawing.Point(6, 22);
            this.DealerCardImages.Name = "DealerCardImages";
            this.DealerCardImages.Size = new System.Drawing.Size(312, 354);
            this.DealerCardImages.TabIndex = 12;
            this.DealerCardImages.Paint += new System.Windows.Forms.PaintEventHandler(this.DealerCardImages_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DealerCardImages);
            this.groupBox1.Controls.Add(this.DealerScore);
            this.groupBox1.Location = new System.Drawing.Point(29, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 403);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dealer";
            // 
            // PlayerNameBox
            // 
            this.PlayerNameBox.Controls.Add(this.PlayerCardImages);
            this.PlayerNameBox.Controls.Add(this.PlayerScore);
            this.PlayerNameBox.Location = new System.Drawing.Point(363, 31);
            this.PlayerNameBox.Name = "PlayerNameBox";
            this.PlayerNameBox.Size = new System.Drawing.Size(344, 399);
            this.PlayerNameBox.TabIndex = 15;
            this.PlayerNameBox.TabStop = false;
            this.PlayerNameBox.Text = "Player Name";
            this.PlayerNameBox.Enter += new System.EventHandler(this.PlayerNameBox_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PlayerNameBox);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.Stand);
            this.Controls.Add(this.Hit);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.NewGame);
            this.Name = "Form1";
            this.Text = "A Blackjack game by André Sturesson";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PlayerNameBox.ResumeLayout(false);
            this.PlayerNameBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button NewGame;
        private Button Shuffle;
        private Button Hit;
        private Button Stand;
        private Label DealerScore;
        private Label PlayerScore;
        private Label winnerLabel;
        private FlowLayoutPanel PlayerCardImages;
        private FlowLayoutPanel DealerCardImages;
        private GroupBox groupBox1;
        private GroupBox PlayerNameBox;
    }
}