﻿using Blackjack.cards;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    // Dummy class to prevent opening this file as a form designer
    [System.ComponentModel.DesignerCategory("")]
    public class MainDummy { }

    // MainWindow scripts
    public partial class Blackjack : Form
    {
        private void DrawPlayerCard()
        {
            // Draws card for the player

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
            MovePlayerCards();
            UpdatePlayerScore();
        }

        private void DrawEnemyCard()
        {
            // Draws card for the enemy

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
            MoveEnemyCards();
            UpdateEnemyScore();
        }

        private void MovePlayerCards()
        {
            // Centers the player cards

            int cardnumber = 51 - PlayerDeck.GetSize();

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

        private void MoveEnemyCards()
        {
            // Centers the enemy cards

            int cardnumber = 51 - EnemyDeck.GetSize();

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

        private void UpdatePlayerScore()
        {
            // Updates player score

            int playerscore = 0;
            Card[] Aces = new Card[4];
            int aces_index = 0;

            foreach (Card playercard in PlayerActiveCards)
            {
                if (playercard == null)
                {
                    continue;
                }

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

            // Aces value change
            foreach (Card playercard in Aces)
            {
                if (playercard == null)
                {
                    continue;
                }

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

            // Show score
            PlayerScoreBox.Text = playerscore.ToString();

            // If player busts
            if (playerscore > 21)
            {
                PlayerScoreBox.ForeColor = Color.Red;
                Hit.Enabled = false;
                Stand.Enabled = false;
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

        private void UpdateEnemyScore()
        {
            // Updates enemy score

            int enemyscore = 0;
            Card[] Aces = new Card[4];
            int aces_index = 0;

            foreach (Card enemycard in EnemyActiveCards)
            {
                if (enemycard == null)
                {
                    continue;
                }

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

            // Aces value change
            foreach (Card enemycard in Aces)
            {
                if (enemycard == null)
                {
                    continue;
                }

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

            // Show score
            EnemyScoreBox.Text = enemyscore.ToString();

            // If enemy busts
            if (enemyscore > 21)
            {
                EnemyScoreBox.ForeColor = Color.Red;
            }
        }

        private void PlayerBust()
        {
            // Ends the round on player's bust

            Hit.Enabled = false;
            Stand.Enabled = false;
            ResultBox.Text = "BUST";
            ResultBox.ForeColor = Color.Red;
        }

        private void Natural()
        {
            // Ends the round on player's natural 21

            Hit.Enabled = false;
            Stand.Enabled = false;
            ResultBox.Text = "BLACKJACK";

            int firstcardvalue = EnemyActiveCards[0].GetValue();

            // Check if enemy doesn't have blackjack too
            if (firstcardvalue == 10 || firstcardvalue == 11 || firstcardvalue == 1)
            {
                Stand_Click(this, new EventArgs());
            }
        }

        private void ChangeBet(decimal value)
        {
            // Changes the bet

            decimal bet = CustomBet.Value;
            decimal new_bet = value + bet;

            if (new_bet < 10 || new_bet > 1000000)
            {
                CustomBet.Value = 10;
                return;
            }

            CustomBet.Value = new_bet;
        }

        private void UpdateBet()
        {
            // Updates value of stake box

            if (CustomBet.Value < 10)
            {
                StakeBox.Text = "10$";
                BetButton.Enabled = false;

                return;
            }

            BetButton.Enabled = true;

            StakeBox.Text = CustomBet.Value.ToString();

            // Adds space every 3 numbers
            StakeBox.Text = Regex.Replace(StakeBox.Text, @"(\d)(?=(\d{3})+(?!\d))", "$1 ");

            StakeBox.Text += "$";
        }

        private void BetConfirm(decimal value)
        {
            // Ends the betting stage

            Plus10Button.Visible = false;
            Plus100Button.Visible = false;
            Plus1000Button.Visible = false;
            Minus10Button.Visible = false;
            Minus100Button.Visible = false;
            Minus1000Button.Visible = false;
            CustomBet.Visible = false;
            BetButton.Visible = false;

            Hit.Enabled = true;
            Stand.Enabled = true;

            previous_bet = CustomBet.Value;
        }

        private void Wait(int milliseconds)
        {
            // Freezes the form temporarily

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
    }
}
