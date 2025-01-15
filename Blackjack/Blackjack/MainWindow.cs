using Blackjack.cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Blackjack
{
    public partial class Blackjack : Form
    {
        public Blackjack()
        {
            InitializeComponent();
        }

        internal void Blackjack_Load(object sender, EventArgs e)
        {
            // Start
            Console.WriteLine("Started");

            // Load save data
            try
            {
                string playerdata = File.ReadAllText(@"../../JSON/PlayerData.json");
                string enemydata = File.ReadAllText(@"../../JSON/EnemyData.json");

                PlayerStats = JsonConvert.DeserializeObject<data.Player>(playerdata);
                EnemyStats = JsonConvert.DeserializeObject<data.Enemy>(enemydata);

                Console.WriteLine(PlayerStats.GetMoneyAmount());
                Console.WriteLine(EnemyStats.GetMoneyAmount());
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("ERROR: Save file not found. Progress will be restarted");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex}");
            }

            // Add PictureBoxes to containers
            PlayerCardsContainer[0] = PlayerCard0;
            PlayerCardsContainer[1] = PlayerCard1;
            PlayerCardsContainer[2] = PlayerCard2;
            PlayerCardsContainer[3] = PlayerCard3;
            PlayerCardsContainer[4] = PlayerCard4;
            PlayerCardsContainer[5] = PlayerCard5;
            PlayerCardsContainer[6] = PlayerCard6;
            PlayerCardsContainer[7] = PlayerCard7;
            PlayerCardsContainer[8] = PlayerCard8;
            PlayerCardsContainer[9] = PlayerCard9;

            foreach (PictureBox box in PlayerCardsContainer){
                box.Visible = false;
            }

            EnemyCardsContainer[0] = EnemyCard0;
            EnemyCardsContainer[1] = EnemyCard1;
            EnemyCardsContainer[2] = EnemyCard2;
            EnemyCardsContainer[3] = EnemyCard3;
            EnemyCardsContainer[4] = EnemyCard4;
            EnemyCardsContainer[5] = EnemyCard5;
            EnemyCardsContainer[6] = EnemyCard6;
            EnemyCardsContainer[7] = EnemyCard7;
            EnemyCardsContainer[8] = EnemyCard8;
            EnemyCardsContainer[9] = EnemyCard9;

            foreach (PictureBox box in EnemyCardsContainer)
            {
                box.Visible = false;
            }

            // Draw first enemy cards
            DrawEnemyCard();

            EnemyCard1.ImageLocation = "../../img/mysterycard.png";
            EnemyCard1.Load();
            EnemyCard1.Visible = true;
            EnemyCard0.Left = ((this.ClientSize.Width - EnemyCard1.Width) / 2) - 53;
            EnemyCard1.Left = ((this.ClientSize.Width - EnemyCard1.Width) / 2) + 53;

            // Force player to bet
            Hit.Enabled = false;
            Stand.Enabled = false;
        }

        private void Blackjack_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save data on form closing
            string playerdata = JsonConvert.SerializeObject(PlayerStats);
            string enemydata = JsonConvert.SerializeObject(EnemyStats);

            File.WriteAllText(@"../../JSON/PlayerData.json", playerdata);
            File.WriteAllText(@"../../JSON/EnemyData.json", enemydata);

            Console.WriteLine("Progress saved successfully");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            // Next round function

            PlayerDeck.Reset();
            EnemyDeck.Reset();

            PlayerCardsContainer = new PictureBox[10];
            EnemyCardsContainer = new PictureBox[10];

            PlayerActiveCards = new Card[10];
            EnemyActiveCards = new Card[10];

            EnemyScoreBox.ForeColor = Color.Black;
            PlayerScoreBox.ForeColor = Color.Black;

            ResultBox.ForeColor = Color.Black;
            ResultBox.Text = "";

            StakeBox.ForeColor = Color.DarkGreen;
            StakeBox.Text = "10$";
            CustomBet.Value = 10;

            Plus10Button.Visible = true;
            Plus100Button.Visible = true;
            Plus1000Button.Visible = true;
            Minus10Button.Visible = true;
            Minus100Button.Visible = true;
            Minus1000Button.Visible = true;
            CustomBet.Visible = true;
            BetButton.Visible = true;

            CustomBet.Value = previous_bet;

            UpdatePlayerScore();
            UpdateEnemyScore();

            Blackjack_Load(this, new EventArgs());
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            if ((52 - PlayerDeck.GetSize()) >= 10)
            {
                return;
            }

            DrawPlayerCard();
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            Hit.Enabled = false;
            Stand.Enabled = false;

            while (Int32.Parse(EnemyScoreBox.Text) < 17)
            {
                if (Int32.Parse(EnemyScoreBox.Text) > Int32.Parse(PlayerScoreBox.Text))
                {
                    break;
                }

                DrawEnemyCard();
                Wait(1000);
            }

            int enemyscore = Int32.Parse(EnemyScoreBox.Text);
            int playerscore = Int32.Parse(PlayerScoreBox.Text);

            if (enemyscore > playerscore && enemyscore <= 21)
            {
                ResultBox.Text = "LOSE";
            }
            else if (enemyscore == playerscore)
            {
                ResultBox.Text = "DRAW";
            }
            else
            {
                ResultBox.Text = "WIN";
            }
        }

        private void Plus10Button_Click(object sender, EventArgs e)
        {
            ChangeBet(10);
        }

        private void Plus100Button_Click(object sender, EventArgs e)
        {
            ChangeBet(100);
        }

        private void Plus1000Button_Click(object sender, EventArgs e)
        {
            ChangeBet(1000);
        }

        private void Minus10Button_Click(object sender, EventArgs e)
        {
            ChangeBet(-10);
        }

        private void Minus100Button_Click(object sender, EventArgs e)
        {
            ChangeBet(-100);
        }

        private void Minus1000Button_Click(object sender, EventArgs e)
        {
            ChangeBet(-1000);
        }

        private void BetButton_Click(object sender, EventArgs e)
        {
            BetConfirm(CustomBet.Value);
        }

        private void CustomBet_ValueChanged(object sender, EventArgs e)
        {
            UpdateBet();
        }

        private void CustomBet_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateBet();
        }
    }
}
