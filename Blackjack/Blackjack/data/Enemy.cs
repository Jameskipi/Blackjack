using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.data
{
    internal class Enemy : PlayersInterface
    {
        public string name;
        public decimal money;
        public int winstreak;

        public Enemy(string name, decimal money, int winstreak)
        {
            this.name = name;
            this.money = money;
            this.winstreak = winstreak;
        }

        public Enemy() { }

        public string getName()
        {
            return name;
        }

        public decimal getMoneyAmount()
        {
            return money;
        }

        public int getWinStreak()
        {
            return winstreak;
        }
    }
}
