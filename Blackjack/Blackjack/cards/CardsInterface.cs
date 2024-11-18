using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.cards
{
    internal interface CardsInterface
    {
        string getName();
        int getValue();
        string getImgPath();
    }

    internal interface DeckInterface
    {
        void reset();
        Card draw();
        int getSize();
    }
}
