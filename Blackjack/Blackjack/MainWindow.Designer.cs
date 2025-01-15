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
            this.Hit = new System.Windows.Forms.Button();
            this.PlayerCard0 = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.Button();
            this.EnemyCard0 = new System.Windows.Forms.PictureBox();
            this.EnemyCard1 = new System.Windows.Forms.PictureBox();
            this.PlayerCard1 = new System.Windows.Forms.PictureBox();
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
            this.PlayerScoreBox = new System.Windows.Forms.Label();
            this.PlayerMaxBox = new System.Windows.Forms.Label();
            this.EnemyMaxBox = new System.Windows.Forms.Label();
            this.EnemyScoreBox = new System.Windows.Forms.Label();
            this.Stand = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.Label();
            this.StakeLabel = new System.Windows.Forms.Label();
            this.StakeBox = new System.Windows.Forms.Label();
            this.Minus10Button = new System.Windows.Forms.Button();
            this.Minus100Button = new System.Windows.Forms.Button();
            this.Minus1000Button = new System.Windows.Forms.Button();
            this.Plus1000Button = new System.Windows.Forms.Button();
            this.Plus100Button = new System.Windows.Forms.Button();
            this.Plus10Button = new System.Windows.Forms.Button();
            this.BetButton = new System.Windows.Forms.Button();
            this.CustomBet = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.CustomBet)).BeginInit();
            this.SuspendLayout();
            // 
            // Hit
            // 
            this.Hit.Location = new System.Drawing.Point(12, 395);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(75, 23);
            this.Hit.TabIndex = 0;
            this.Hit.Text = "Hit";
            this.Hit.UseVisualStyleBackColor = true;
            this.Hit.Click += new System.EventHandler(this.Draw_Click);
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
            this.Reset.Location = new System.Drawing.Point(1153, 395);
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
            // PlayerScoreBox
            // 
            this.PlayerScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerScoreBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayerScoreBox.Location = new System.Drawing.Point(517, 361);
            this.PlayerScoreBox.Name = "PlayerScoreBox";
            this.PlayerScoreBox.Size = new System.Drawing.Size(100, 31);
            this.PlayerScoreBox.TabIndex = 24;
            this.PlayerScoreBox.Text = "0";
            this.PlayerScoreBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayerMaxBox
            // 
            this.PlayerMaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerMaxBox.Location = new System.Drawing.Point(623, 361);
            this.PlayerMaxBox.Name = "PlayerMaxBox";
            this.PlayerMaxBox.Size = new System.Drawing.Size(100, 31);
            this.PlayerMaxBox.TabIndex = 25;
            this.PlayerMaxBox.Text = "/21";
            this.PlayerMaxBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnemyMaxBox
            // 
            this.EnemyMaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnemyMaxBox.Location = new System.Drawing.Point(623, 169);
            this.EnemyMaxBox.Name = "EnemyMaxBox";
            this.EnemyMaxBox.Size = new System.Drawing.Size(100, 31);
            this.EnemyMaxBox.TabIndex = 27;
            this.EnemyMaxBox.Text = "/21";
            this.EnemyMaxBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnemyScoreBox
            // 
            this.EnemyScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnemyScoreBox.Location = new System.Drawing.Point(517, 169);
            this.EnemyScoreBox.Name = "EnemyScoreBox";
            this.EnemyScoreBox.Size = new System.Drawing.Size(100, 31);
            this.EnemyScoreBox.TabIndex = 26;
            this.EnemyScoreBox.Text = "0";
            this.EnemyScoreBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Stand
            // 
            this.Stand.Location = new System.Drawing.Point(12, 424);
            this.Stand.Name = "Stand";
            this.Stand.Size = new System.Drawing.Size(75, 23);
            this.Stand.TabIndex = 29;
            this.Stand.Text = "Stand";
            this.Stand.UseVisualStyleBackColor = true;
            this.Stand.Click += new System.EventHandler(this.Stand_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ResultBox.Location = new System.Drawing.Point(517, 250);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(206, 31);
            this.ResultBox.TabIndex = 30;
            this.ResultBox.Text = " ";
            this.ResultBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StakeLabel
            // 
            this.StakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.StakeLabel.Location = new System.Drawing.Point(517, 281);
            this.StakeLabel.Name = "StakeLabel";
            this.StakeLabel.Size = new System.Drawing.Size(100, 31);
            this.StakeLabel.TabIndex = 31;
            this.StakeLabel.Text = "Stake:";
            this.StakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StakeBox
            // 
            this.StakeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.StakeBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.StakeBox.Location = new System.Drawing.Point(607, 281);
            this.StakeBox.Name = "StakeBox";
            this.StakeBox.Size = new System.Drawing.Size(170, 31);
            this.StakeBox.TabIndex = 32;
            this.StakeBox.Text = "10$";
            this.StakeBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Minus10Button
            // 
            this.Minus10Button.Location = new System.Drawing.Point(796, 239);
            this.Minus10Button.Name = "Minus10Button";
            this.Minus10Button.Size = new System.Drawing.Size(75, 23);
            this.Minus10Button.TabIndex = 33;
            this.Minus10Button.Text = "-10$";
            this.Minus10Button.UseVisualStyleBackColor = true;
            this.Minus10Button.Click += new System.EventHandler(this.Minus10Button_Click);
            // 
            // Minus100Button
            // 
            this.Minus100Button.Location = new System.Drawing.Point(796, 268);
            this.Minus100Button.Name = "Minus100Button";
            this.Minus100Button.Size = new System.Drawing.Size(75, 23);
            this.Minus100Button.TabIndex = 34;
            this.Minus100Button.Text = "-100$";
            this.Minus100Button.UseVisualStyleBackColor = true;
            this.Minus100Button.Click += new System.EventHandler(this.Minus100Button_Click);
            // 
            // Minus1000Button
            // 
            this.Minus1000Button.Location = new System.Drawing.Point(796, 297);
            this.Minus1000Button.Name = "Minus1000Button";
            this.Minus1000Button.Size = new System.Drawing.Size(75, 23);
            this.Minus1000Button.TabIndex = 35;
            this.Minus1000Button.Text = "-1000$";
            this.Minus1000Button.UseVisualStyleBackColor = true;
            this.Minus1000Button.Click += new System.EventHandler(this.Minus1000Button_Click);
            // 
            // Plus1000Button
            // 
            this.Plus1000Button.Location = new System.Drawing.Point(877, 297);
            this.Plus1000Button.Name = "Plus1000Button";
            this.Plus1000Button.Size = new System.Drawing.Size(75, 23);
            this.Plus1000Button.TabIndex = 38;
            this.Plus1000Button.Text = "+1000$";
            this.Plus1000Button.UseVisualStyleBackColor = true;
            this.Plus1000Button.Click += new System.EventHandler(this.Plus1000Button_Click);
            // 
            // Plus100Button
            // 
            this.Plus100Button.Location = new System.Drawing.Point(877, 268);
            this.Plus100Button.Name = "Plus100Button";
            this.Plus100Button.Size = new System.Drawing.Size(75, 23);
            this.Plus100Button.TabIndex = 37;
            this.Plus100Button.Text = "+100$";
            this.Plus100Button.UseVisualStyleBackColor = true;
            this.Plus100Button.Click += new System.EventHandler(this.Plus100Button_Click);
            // 
            // Plus10Button
            // 
            this.Plus10Button.Location = new System.Drawing.Point(877, 239);
            this.Plus10Button.Name = "Plus10Button";
            this.Plus10Button.Size = new System.Drawing.Size(75, 23);
            this.Plus10Button.TabIndex = 36;
            this.Plus10Button.Text = "+10$";
            this.Plus10Button.UseVisualStyleBackColor = true;
            this.Plus10Button.Click += new System.EventHandler(this.Plus10Button_Click);
            // 
            // BetButton
            // 
            this.BetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BetButton.Location = new System.Drawing.Point(877, 333);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(75, 23);
            this.BetButton.TabIndex = 39;
            this.BetButton.Text = "Bet";
            this.BetButton.UseVisualStyleBackColor = true;
            this.BetButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // CustomBet
            // 
            this.CustomBet.Location = new System.Drawing.Point(796, 336);
            this.CustomBet.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CustomBet.Name = "CustomBet";
            this.CustomBet.Size = new System.Drawing.Size(75, 20);
            this.CustomBet.TabIndex = 40;
            this.CustomBet.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CustomBet.ValueChanged += new System.EventHandler(this.CustomBet_ValueChanged);
            this.CustomBet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CustomBet_KeyUp);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.CustomBet);
            this.Controls.Add(this.BetButton);
            this.Controls.Add(this.Plus1000Button);
            this.Controls.Add(this.Plus100Button);
            this.Controls.Add(this.Plus10Button);
            this.Controls.Add(this.Minus1000Button);
            this.Controls.Add(this.Minus100Button);
            this.Controls.Add(this.Minus10Button);
            this.Controls.Add(this.StakeBox);
            this.Controls.Add(this.StakeLabel);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.Stand);
            this.Controls.Add(this.EnemyMaxBox);
            this.Controls.Add(this.EnemyScoreBox);
            this.Controls.Add(this.PlayerMaxBox);
            this.Controls.Add(this.PlayerScoreBox);
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
            this.Controls.Add(this.PlayerCard1);
            this.Controls.Add(this.EnemyCard1);
            this.Controls.Add(this.EnemyCard0);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.PlayerCard0);
            this.Controls.Add(this.Hit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Blackjack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
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
            ((System.ComponentModel.ISupportInitialize)(this.CustomBet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Hit;
        private System.Windows.Forms.PictureBox PlayerCard0;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.PictureBox EnemyCard0;
        private System.Windows.Forms.PictureBox EnemyCard1;
        private PictureBox PlayerCard1;
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
        private Label PlayerScoreBox;
        private Label PlayerMaxBox;
        private Label EnemyMaxBox;
        private Label EnemyScoreBox;
        private Button Stand;
        private Label ResultBox;
        private Label StakeLabel;
        private Label StakeBox;
        private Button Minus10Button;
        private Button Minus100Button;
        private Button Minus1000Button;
        private Button Plus1000Button;
        private Button Plus100Button;
        private Button Plus10Button;
        private Button BetButton;
        private NumericUpDown CustomBet;
    }
}

