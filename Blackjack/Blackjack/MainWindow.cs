using Blackjack.cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Console.WriteLine("Started");
            deck.show();
        }

        private void Roll_Click(object sender, EventArgs e)
        {
            card = deck.draw();

            if (card == null)
            {
                PlayerCard1.ImageLocation = "../../img/nullcard.png";
            }
            else
            {
                PlayerCard1.ImageLocation = $"../../{card.getImgPath()}";
            }

            PlayerCard1.Load();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            deck.reset();
            Roll_Click(sender, e);
        }
    }
}
