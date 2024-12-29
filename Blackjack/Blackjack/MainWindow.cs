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
            EnemyDraw_Click(sender, new EventArgs());

            EnemyCard1.ImageLocation = "../../img/mysterycard.png";
            EnemyCard1.Load();
            EnemyCard1.Visible = true;
            EnemyCard0.Left = ((this.ClientSize.Width - EnemyCard1.Width) / 2) - 53;
            EnemyCard1.Left = ((this.ClientSize.Width - EnemyCard1.Width) / 2) + 53;
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

        private void DrawCard(bool isPlayer)
        {
            if (isPlayer)
            {
                PictureBox Container = PlayerCardsContainer[(52 - PlayerDeck.GetSize())];
                PlayerCard = PlayerDeck.Draw();
                PlayerActiveCards[(51 - PlayerDeck.GetSize())] = PlayerCard;

                if (PlayerCard == null)
                {
                    Container.ImageLocation = "../../img/nullcard.png";
                }
                else
                {
                    Container.ImageLocation = $"../../{PlayerCard.GetImgPath()}";
                }

                Container.Load();
                MoveCards(true);
                UpdateScore(true);
            }
            else
            {
                PictureBox Container = EnemyCardsContainer[(52 - EnemyDeck.GetSize())];
                EnemyCard = EnemyDeck.Draw();
                EnemyActiveCards[(51 - EnemyDeck.GetSize())] = EnemyCard;

                if (EnemyCard == null)
                {
                    Container.ImageLocation = "../../img/nullcard.png";
                }
                else
                {
                    Container.ImageLocation = $"../../{EnemyCard.GetImgPath()}";
                }

                Container.Load();
                MoveCards(false);
                UpdateScore(false);
            }
        }

        private void MoveCards(bool isPlayer)
        {
            int cardnumber;

            if (isPlayer)
            {
                cardnumber = 51 - PlayerDeck.GetSize();

                PlayerCardsContainer[cardnumber].Left = ((this.ClientSize.Width - PlayerCardsContainer[cardnumber].Width) / 2) + 53;
                PlayerCardsContainer[cardnumber].Visible = true;

                for (int i = 0; i < cardnumber; i++)
                {
                    PlayerCardsContainer[cardnumber].Left = PlayerCardsContainer[cardnumber].Left + 53;
                }

                foreach (PictureBox box in PlayerCardsContainer)
                {
                    box.Left = box.Left - 53;
                }
            }
            else
            {
                cardnumber = 51 - EnemyDeck.GetSize();

                // Fixed mystery card position
                if (cardnumber == 1)
                {
                    EnemyCard0.Left = EnemyCard0.Left + 53;
                }

                EnemyCardsContainer[cardnumber].Left = ((this.ClientSize.Width - EnemyCardsContainer[cardnumber].Width) / 2) + 53;
                EnemyCardsContainer[cardnumber].Visible = true;

                for (int i = 0; i < cardnumber; i++)
                {
                    EnemyCardsContainer[cardnumber].Left = EnemyCardsContainer[cardnumber].Left + 53;
                }

                foreach (PictureBox box in EnemyCardsContainer)
                {
                    box.Left = box.Left - 53;
                }
            }
        }

        private void UpdateScore(bool isPlayer)
        {
            if (isPlayer)
            {
                // Player score
                int playerscore = 0;
                Card[] Aces = new Card[4];
                int aces_index = 0;

                foreach (Card playercard in PlayerActiveCards)
                {
                    if (playercard != null)
                    {
                        if (playercard.GetValue() == 1)
                        {
                            // Skip aces
                            Aces[aces_index] = playercard;
                            aces_index++;
                        }
                        else
                        {
                            playerscore += playercard.GetValue();
                        }
                    }
                }

                // Aces value change
                foreach(Card playercard in Aces)
                {
                    if (playercard != null)
                    {
                        int after_score = playerscore + 11;

                        if (after_score <= 21)
                        {
                            playerscore += playercard.GetValue() + 10;
                        }
                        else
                        {
                            playerscore += playercard.GetValue();
                        }
                    }
                }

                // Show score
                player_scorebox.Text = playerscore.ToString();

                // If player busts
                if (playerscore > 21)
                {
                    player_scorebox.ForeColor = Color.Red;
                    Hit.Enabled = false;
                    Stand.Enabled = false;
                    Console.WriteLine(PlayerDeck.GetSize());
                    PlayerBust();
                }
                else if (playerscore == 21 && PlayerDeck.GetSize() != 50)
                {
                    Hit.Enabled = false;
                }
                else if (playerscore == 21 && PlayerDeck.GetSize() == 50)
                {
                    Natural();
                }
            }
            else
            {
                // Enemy score
                int enemyscore = 0;
                Card[] Aces = new Card[4];
                int aces_index = 0;

                foreach (Card enemycard in EnemyActiveCards)
                {
                    if (enemycard != null)
                    {
                        if (enemycard.GetValue() == 1)
                        {
                            // Skip aces
                            Aces[aces_index] = enemycard;
                            aces_index++;
                        }
                        else
                        {
                            enemyscore += enemycard.GetValue();
                        }
                    }
                }

                // Aces value change
                foreach (Card enemycard in Aces)
                {
                    if (enemycard != null)
                    {
                        int after_score = enemyscore + 11;

                        if (after_score <= 21)
                        {
                            enemyscore += enemycard.GetValue() + 10;
                        }
                        else
                        {
                            enemyscore += enemycard.GetValue();
                        }
                    }
                }

                // Show score
                enemy_scorebox.Text = enemyscore.ToString();

                // If enemy busts
                if (enemyscore > 21)
                {
                    enemy_scorebox.ForeColor = Color.Red;
                    EnemyDraw.Enabled = false;
                }
                else if (enemyscore == 21)
                {
                    EnemyDraw.Enabled = false;
                }
            }
        }

        private void PlayerBust()
        {
            Hit.Enabled = false;
            Stand.Enabled = false;
            ScoreResultBox.Text = "BUST";
            ScoreResultBox.ForeColor = Color.Red;
        }

        private void Natural()
        {
            Hit.Enabled = false;
            Stand.Enabled = false;
            ScoreResultBox.Text = "BLACKJACK";

            int firstcardvalue = EnemyActiveCards[0].GetValue();

            // Check if enemy doesn't have blackjack too
            if (firstcardvalue == 10 || firstcardvalue == 11) {
                Stand_Click(this, new EventArgs());
            }
        }

        private void Wait(int milliseconds)
        {
            var timer = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer.Interval = milliseconds;
            timer.Enabled = true;
            timer.Start();

            timer.Tick += (s, e) =>
            {
                timer.Enabled = false;
                timer.Stop();
            };

            while (timer.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            PlayerDeck.Reset();
            EnemyDeck.Reset();

            PlayerCardsContainer = new PictureBox[10];
            EnemyCardsContainer = new PictureBox[10];

            PlayerActiveCards = new Card[10];
            EnemyActiveCards = new Card[10];

            enemy_scorebox.ForeColor = Color.Black;
            player_scorebox.ForeColor = Color.Black;

            ScoreResultBox.ForeColor = Color.Black;
            ScoreResultBox.Text = "";

            Hit.Enabled = true;
            Stand.Enabled = true;

            UpdateScore(true);

            Blackjack_Load(this, new EventArgs());
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            if ((52 - PlayerDeck.GetSize()) >= 10)
            {
                return;
            }

            DrawCard(true);
        }

        private void EnemyDraw_Click(object sender, EventArgs e)
        {
            if ((52 - EnemyDeck.GetSize()) >= 10)
            {
                return;
            }

            DrawCard(false);
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            Hit.Enabled = false;
            Stand.Enabled = false;

            while (Int32.Parse(enemy_scorebox.Text) < 17)
            {
                if (Int32.Parse(enemy_scorebox.Text) > Int32.Parse(player_scorebox.Text))
                {
                    break;
                }

                DrawCard(false);
                Wait(1000);
            }

            int enemyscore = Int32.Parse(enemy_scorebox.Text);
            int playerscore = Int32.Parse(player_scorebox.Text);

            if (enemyscore > playerscore && enemyscore <= 21)
            {
                ScoreResultBox.Text = "LOSE";
            }
            else if (enemyscore == playerscore)
            {
                ScoreResultBox.Text = "DRAW";
            }
            else
            {
                ScoreResultBox.Text = "WIN";
            }
        }
    }
}
