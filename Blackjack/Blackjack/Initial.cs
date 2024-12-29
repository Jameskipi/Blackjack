using Blackjack.cards;
using Blackjack.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    // Dummy class to prevent opening this file as a form designer
    [System.ComponentModel.DesignerCategory("")]
    public class InitialDummy { }

    // Initial script
    partial class Blackjack
    {
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
    }
}
