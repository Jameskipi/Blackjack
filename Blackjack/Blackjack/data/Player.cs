using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.data
{
    internal class Player : PlayersInterface
    {
        public string name;
        public decimal money;
        public int winstreak;

        public Player(string name, decimal money, int winstreak)
        {
            this.name = name;
            this.money = money;
            this.winstreak = winstreak;
        }

        public Player() { }

        public string GetName()
        {
            return name;
        }

        public decimal GetMoneyAmount()
        {
            return money;
        }

        public int GetWinStreak()
        {
            return winstreak;
        }
    }
}
