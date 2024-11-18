using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blackjack.cards
{
    internal class Card : CardsInterface
    {
        private string name;
        private int value;
        private string imgpath;
        private bool used = false;

        public Card(string name, int value, string imgpath)
        {
            this.name = name;
            this.value = value;
            this.imgpath = imgpath;
        }

        public string getName()
        {
            return name;
        }

        public int getValue()
        {
            return value;
        }

        public string getImgPath()
        {
            return imgpath;
        }

        public void setUsed(bool used) 
        {
            this.used = used;
        }

        public bool isUsed()
        {
            return used;
        }
    }
}
