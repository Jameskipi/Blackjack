using Blackjack.cards;
using Blackjack.data;
using System.Windows.Forms;

namespace Blackjack
{
    partial class Blackjack
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        // Create decks for cards
        private Deck PlayerDeck = new Deck();
        private Card PlayerCard;

        private Deck EnemyDeck = new Deck();
        private Card EnemyCard;

        // Create card pictures containers
        private PictureBox[] PlayerCardsContainer = new PictureBox[10];
        private PictureBox[] EnemyCardsContainer = new PictureBox[10];

        // Create active cards containers
        private Card[] PlayerActiveCards = new Card[10];
        private Card[] EnemyActiveCards = new Card[10];

        // Create data for saving purposes
        private Player PlayerStats = new Player();
        private Enemy EnemyStats = new Enemy();


        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Draw = new System.Windows.Forms.Button();
            this.PlayerCard0 = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.Button();
            this.EnemyCard0 = new System.Windows.Forms.PictureBox();
            this.EnemyCard1 = new System.Windows.Forms.PictureBox();
            this.PlayerCard1 = new System.Windows.Forms.PictureBox();
            this.EnemyDraw = new System.Windows.Forms.Button();
            this.PlayerCard2 = new System.Windows.Forms.PictureBox();
            this.PlayerCard5 = new System.Windows.Forms.PictureBox();
            this.PlayerCard4 = new System.Windows.Forms.PictureBox();
            this.PlayerCard3 = new System.Windows.Forms.PictureBox();
            this.PlayerCard6 = new System.Windows.Forms.PictureBox();
            this.PlayerCard9 = new System.Windows.Forms.PictureBox();
            this.PlayerCard8 = new System.Windows.Forms.PictureBox();
            this.PlayerCard7 = new System.Windows.Forms.PictureBox();
            this.EnemyCard3 = new System.Windows.Forms.PictureBox();
            this.EnemyCard2 = new System.Windows.Forms.PictureBox();
            this.EnemyCard5 = new System.Windows.Forms.PictureBox();
            this.EnemyCard4 = new System.Windows.Forms.PictureBox();
            this.EnemyCard7 = new System.Windows.Forms.PictureBox();
            this.EnemyCard6 = new System.Windows.Forms.PictureBox();
            this.EnemyCard9 = new System.Windows.Forms.PictureBox();
            this.EnemyCard8 = new System.Windows.Forms.PictureBox();
            this.player_scorebox = new System.Windows.Forms.Label();
            this.player_maxbox = new System.Windows.Forms.Label();
            this.enemy_maxbox = new System.Windows.Forms.Label();
            this.enemy_scorebox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard8)).BeginInit();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(12, 479);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // PlayerCard0
            // 
            this.PlayerCard0.Location = new System.Drawing.Point(93, 395);
            this.PlayerCard0.Name = "PlayerCard0";
            this.PlayerCard0.Size = new System.Drawing.Size(100, 154);
            this.PlayerCard0.TabIndex = 1;
            this.PlayerCard0.TabStop = false;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(1153, 479);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // EnemyCard0
            // 
            this.EnemyCard0.Location = new System.Drawing.Point(93, 12);
            this.EnemyCard0.Name = "EnemyCard0";
            this.EnemyCard0.Size = new System.Drawing.Size(100, 154);
            this.EnemyCard0.TabIndex = 3;
            this.EnemyCard0.TabStop = false;
            // 
            // EnemyCard1
            // 
            this.EnemyCard1.Location = new System.Drawing.Point(199, 12);
            this.EnemyCard1.Name = "EnemyCard1";
            this.EnemyCard1.Size = new System.Drawing.Size(100, 154);
            this.EnemyCard1.TabIndex = 5;
            this.EnemyCard1.TabStop = false;
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.Location = new System.Drawing.Point(199, 395);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Size = new System.Drawing.Size(100, 154);
            this.PlayerCard1.TabIndex = 6;
            this.PlayerCard1.TabStop = false;
            // 
            // EnemyDraw
            // 
            this.EnemyDraw.Location = new System.Drawing.Point(12, 65);
            this.EnemyDraw.Name = "EnemyDraw";
            this.EnemyDraw.Size = new System.Drawing.Size(75, 23);
            this.EnemyDraw.TabIndex = 7;
            this.EnemyDraw.Text = "EnemyDraw";
            this.EnemyDraw.UseVisualStyleBackColor = true;
            this.EnemyDraw.Click += new System.EventHandler(this.EnemyDraw_Click);
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.Location = new System.Drawing.Point(305, 395);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Size = new System.Drawing.Size(100, 154);
            this.PlayerCard2.TabIndex = 8;
            this.PlayerCard2.TabStop = false;
            // 
            // PlayerCard5
            // 
            this.PlayerCard5.Location = new System.Drawing.Point(623, 395);
            this.PlayerCard5.Name = "PlayerCard5";
            this.PlayerCard5.Size = new System.Drawing.Size(100, 154);
            this.PlayerCard5.TabIndex = 11;
            this.PlayerCard5.TabStop = false;
            // 
            // PlayerCard4
            // 
            this.PlayerCard4.Location = new System.Drawing.Point(517, 395);
            this.PlayerCard4.Name = "PlayerCard4";
            this.PlayerCard4.Size = new System.Drawing.Size(100, 154);
            this.PlayerCard4.TabIndex = 10;
            this.PlayerCard4.TabStop = false;
            // 
            // PlayerCard3
            // 
            this.PlayerCard3.Location = new System.Drawing.Point(411, 395);
            this.PlayerCard3.Name = "PlayerCard3";
            this.PlayerCard3.Size = new System.Drawing.Size(100, 154);
            this.PlayerCard3.TabIndex = 9;
            this.PlayerCard3.TabStop = false;
            // 
            // PlayerCard6
            // 
            this.PlayerCard6.Location = new System.Drawing.Point(729, 395);
            this.PlayerCard6.Name = "PlayerCard6";
            this.PlayerCard6.Size = new System.Drawing.Size(100, 154);
            this.PlayerCard6.TabIndex = 12;
            this.PlayerCard6.TabStop = false;
            // 
            // PlayerCard9
            // 
            this.PlayerCard9.Location = new System.Drawing.Point(1047, 395);
            this.PlayerCard9.Name = "PlayerCard9";
            this.PlayerCard9.Size = new System.Drawing.Size(100, 154);
            this.PlayerCard9.TabIndex = 15;
            this.PlayerCard9.TabStop = false;
            // 
            // PlayerCard8
            // 
            this.PlayerCard8.Location = new System.Drawing.Point(941, 395);
            this.PlayerCard8.Name = "PlayerCard8";
            this.PlayerCard8.Size = new System.Drawing.Size(100, 154);
            this.PlayerCard8.TabIndex = 14;
            this.PlayerCard8.TabStop = false;
            // 
            // PlayerCard7
            // 
            this.PlayerCard7.Location = new System.Drawing.Point(835, 395);
            this.PlayerCard7.Name = "PlayerCard7";
            this.PlayerCard7.Size = new System.Drawing.Size(100, 154);
            this.PlayerCard7.TabIndex = 13;
            this.PlayerCard7.TabStop = false;
            // 
            // EnemyCard3
            // 
            this.EnemyCard3.Location = new System.Drawing.Point(411, 12);
            this.EnemyCard3.Name = "EnemyCard3";
            this.EnemyCard3.Size = new System.Drawing.Size(100, 154);
            this.EnemyCard3.TabIndex = 17;
            this.EnemyCard3.TabStop = false;
            // 
            // EnemyCard2
            // 
            this.EnemyCard2.Location = new System.Drawing.Point(305, 12);
            this.EnemyCard2.Name = "EnemyCard2";
            this.EnemyCard2.Size = new System.Drawing.Size(100, 154);
            this.EnemyCard2.TabIndex = 16;
            this.EnemyCard2.TabStop = false;
            // 
            // EnemyCard5
            // 
            this.EnemyCard5.Location = new System.Drawing.Point(623, 12);
            this.EnemyCard5.Name = "EnemyCard5";
            this.EnemyCard5.Size = new System.Drawing.Size(100, 154);
            this.EnemyCard5.TabIndex = 19;
            this.EnemyCard5.TabStop = false;
            // 
            // EnemyCard4
            // 
            this.EnemyCard4.Location = new System.Drawing.Point(517, 12);
            this.EnemyCard4.Name = "EnemyCard4";
            this.EnemyCard4.Size = new System.Drawing.Size(100, 154);
            this.EnemyCard4.TabIndex = 18;
            this.EnemyCard4.TabStop = false;
            // 
            // EnemyCard7
            // 
            this.EnemyCard7.Location = new System.Drawing.Point(835, 12);
            this.EnemyCard7.Name = "EnemyCard7";
            this.EnemyCard7.Size = new System.Drawing.Size(100, 154);
            this.EnemyCard7.TabIndex = 21;
            this.EnemyCard7.TabStop = false;
            // 
            // EnemyCard6
            // 
            this.EnemyCard6.Location = new System.Drawing.Point(729, 12);
            this.EnemyCard6.Name = "EnemyCard6";
            this.EnemyCard6.Size = new System.Drawing.Size(100, 154);
            this.EnemyCard6.TabIndex = 20;
            this.EnemyCard6.TabStop = false;
            // 
            // EnemyCard9
            // 
            this.EnemyCard9.Location = new System.Drawing.Point(1047, 12);
            this.EnemyCard9.Name = "EnemyCard9";
            this.EnemyCard9.Size = new System.Drawing.Size(100, 154);
            this.EnemyCard9.TabIndex = 23;
            this.EnemyCard9.TabStop = false;
            // 
            // EnemyCard8
            // 
            this.EnemyCard8.Location = new System.Drawing.Point(941, 12);
            this.EnemyCard8.Name = "EnemyCard8";
            this.EnemyCard8.Size = new System.Drawing.Size(100, 154);
            this.EnemyCard8.TabIndex = 22;
            this.EnemyCard8.TabStop = false;
            // 
            // player_scorebox
            // 
            this.player_scorebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player_scorebox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.player_scorebox.Location = new System.Drawing.Point(573, 361);
            this.player_scorebox.Name = "player_scorebox";
            this.player_scorebox.Size = new System.Drawing.Size(44, 31);
            this.player_scorebox.TabIndex = 24;
            this.player_scorebox.Text = "0";
            this.player_scorebox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // player_maxbox
            // 
            this.player_maxbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player_maxbox.Location = new System.Drawing.Point(623, 361);
            this.player_maxbox.Name = "player_maxbox";
            this.player_maxbox.Size = new System.Drawing.Size(52, 31);
            this.player_maxbox.TabIndex = 25;
            this.player_maxbox.Text = "/21";
            // 
            // enemy_maxbox
            // 
            this.enemy_maxbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemy_maxbox.Location = new System.Drawing.Point(623, 169);
            this.enemy_maxbox.Name = "enemy_maxbox";
            this.enemy_maxbox.Size = new System.Drawing.Size(52, 31);
            this.enemy_maxbox.TabIndex = 27;
            this.enemy_maxbox.Text = "/21";
            // 
            // enemy_scorebox
            // 
            this.enemy_scorebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemy_scorebox.Location = new System.Drawing.Point(573, 169);
            this.enemy_scorebox.Name = "enemy_scorebox";
            this.enemy_scorebox.Size = new System.Drawing.Size(44, 31);
            this.enemy_scorebox.TabIndex = 26;
            this.enemy_scorebox.Text = "0";
            this.enemy_scorebox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.enemy_maxbox);
            this.Controls.Add(this.enemy_scorebox);
            this.Controls.Add(this.player_maxbox);
            this.Controls.Add(this.player_scorebox);
            this.Controls.Add(this.EnemyCard9);
            this.Controls.Add(this.EnemyCard8);
            this.Controls.Add(this.EnemyCard7);
            this.Controls.Add(this.EnemyCard6);
            this.Controls.Add(this.EnemyCard5);
            this.Controls.Add(this.EnemyCard4);
            this.Controls.Add(this.EnemyCard3);
            this.Controls.Add(this.EnemyCard2);
            this.Controls.Add(this.PlayerCard9);
            this.Controls.Add(this.PlayerCard8);
            this.Controls.Add(this.PlayerCard7);
            this.Controls.Add(this.PlayerCard6);
            this.Controls.Add(this.PlayerCard5);
            this.Controls.Add(this.PlayerCard4);
            this.Controls.Add(this.PlayerCard3);
            this.Controls.Add(this.PlayerCard2);
            this.Controls.Add(this.EnemyDraw);
            this.Controls.Add(this.PlayerCard1);
            this.Controls.Add(this.EnemyCard1);
            this.Controls.Add(this.EnemyCard0);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.PlayerCard0);
            this.Controls.Add(this.Draw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Blackjack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Blackjack_FormClosing);
            this.Load += new System.EventHandler(this.Blackjack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCard8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.PictureBox PlayerCard0;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.PictureBox EnemyCard0;
        private System.Windows.Forms.PictureBox EnemyCard1;
        private PictureBox PlayerCard1;
        private Button EnemyDraw;
        private PictureBox PlayerCard2;
        private PictureBox PlayerCard5;
        private PictureBox PlayerCard4;
        private PictureBox PlayerCard3;
        private PictureBox PlayerCard6;
        private PictureBox PlayerCard9;
        private PictureBox PlayerCard8;
        private PictureBox PlayerCard7;
        private PictureBox EnemyCard3;
        private PictureBox EnemyCard2;
        private PictureBox EnemyCard5;
        private PictureBox EnemyCard4;
        private PictureBox EnemyCard7;
        private PictureBox EnemyCard6;
        private PictureBox EnemyCard9;
        private PictureBox EnemyCard8;
        private Label player_scorebox;
        private Label player_maxbox;
        private Label enemy_maxbox;
        private Label enemy_scorebox;
    }
}

