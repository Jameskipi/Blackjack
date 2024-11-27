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
            PlayerDeck.show();
            EnemyDeck.show();

            // Load save data
            try
            {
                string playerdata = File.ReadAllText(@"../../JSON/PlayerData.json");
                string enemydata = File.ReadAllText(@"../../JSON/EnemyData.json");

                PlayerStats = JsonConvert.DeserializeObject<data.Player>(playerdata);
                EnemyStats = JsonConvert.DeserializeObject<data.Enemy>(enemydata);

                Console.WriteLine(PlayerStats.getMoneyAmount());
                Console.WriteLine(EnemyStats.getMoneyAmount());
            } 
            catch (FileNotFoundException)
            {
                Console.WriteLine("ERROR: Save file not found. Progress will be restarted");
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
                PictureBox Container = PlayerCardsContainer[(52 - PlayerDeck.getSize())];
                PlayerCard = PlayerDeck.draw();

                if (PlayerCard == null)
                {
                    Container.ImageLocation = "../../img/nullcard.png";
                }
                else
                {
                    Container.ImageLocation = $"../../{PlayerCard.getImgPath()}";
                }

                Container.Load();
                MoveCards(true);
            }
            else
            {
                PictureBox Container = EnemyCardsContainer[(52 - EnemyDeck.getSize())];
                EnemyCard = EnemyDeck.draw();

                if (EnemyCard == null)
                {
                    Container.ImageLocation = "../../img/nullcard.png";
                }
                else
                {
                    Container.ImageLocation = $"../../{EnemyCard.getImgPath()}";
                }

                Container.Load();
                MoveCards(false);
            }
        }

        private void MoveCards(bool isPlayer)
        {
            int cardnumber;

            if (isPlayer)
            {
                cardnumber = 51 - PlayerDeck.getSize();

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
                cardnumber = 51 - EnemyDeck.getSize();

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

        private void Reset_Click(object sender, EventArgs e)
        {
            PlayerDeck.reset();
            EnemyDeck.reset();
            Application.Restart();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            if ((52 - PlayerDeck.getSize()) >= 10)
            {
                return;
            }

            DrawCard(true);
        }

        private void EnemyDraw_Click(object sender, EventArgs e)
        {
            if ((52 - EnemyDeck.getSize()) >= 10)
            {
                return;
            }

            DrawCard(false);
        }
    }
}
