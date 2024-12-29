using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.data
{
    internal interface PlayersInterface
    {
        string GetName();
        decimal GetMoneyAmount();
        int GetWinStreak();
    }
}
