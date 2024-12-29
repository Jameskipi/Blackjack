using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.cards
{
    internal interface CardsInterface
    {
        string GetName();
        int GetValue();
        string GetImgPath();
    }

    internal interface DeckInterface
    {
        void Reset();
        Card Draw();
        int GetSize();
    }
}
