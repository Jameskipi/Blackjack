using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.data
{
    internal interface PlayersInterface
    {
        string getName();
        decimal getMoneyAmount();
        int getWinStreak();
    }
}
