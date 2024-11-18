﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.cards
{
    internal class Deck : DeckInterface
    {
        private int size;
        private static int max_size = 52;
        private Card[] cards = new Card[max_size];
        private Card current_card;
        private Random rnd = new Random();
        private int index;

        public Deck()
        {
            size = max_size;

            // Create clubs
            for (int i = 1; i <= 10; i++)
            {
                cards[i - 1] = new Card($"club_{i}", i, $"img/black/clubs/club_{i}.png");
            }
            for (int i = 11; i <= 13; i++)
            {
                cards[i - 1] = new Card($"club_{i}", 10, $"img/black/clubs/club_{i}.png");
            }

            // Create spades
            for (int i = 1; i <= 10; i++)
            {
                cards[i + 12] = new Card($"spade_{i}", i, $"img/black/spades/spade_{i}.png");
            }
            for (int i = 11; i <= 13; i++)
            {
                cards[i + 12] = new Card($"spade_{i}", 10, $"img/black/spades/spade_{i}.png");
            }

            // Create diamonds
            for (int i = 1; i <= 10; i++)
            {
                cards[i + 25] = new Card($"diamond_{i}", i, $"img/red/diamonds/diamond_{i}.png");
            }
            for (int i = 11; i <= 13; i++)
            {
                cards[i + 25] = new Card($"diamond_{i}", 10, $"img/red/diamonds/diamond_{i}.png");
            }

            // Create hearts
            for (int i = 1; i <= 10; i++)
            {
                cards[i + 38] = new Card($"heart_{i}", i, $"img/red/hearts/heart_{i}.png");
            }
            for (int i = 11; i <= 13; i++)
            {
                cards[i + 38] = new Card($"heart_{i}", 10, $"img/red/hearts/heart_{i}.png");
            }
        }

        public Card draw()
        {
            Console.WriteLine(size);

            if (size == 0)
            {
                return null;
            }

            do
            {
                index = rnd.Next(max_size);
                current_card = cards[index];
            }
            while (current_card.isUsed());

                size = size - 1;
            current_card.setUsed(true);

            return current_card;
        }

        public int getSize()
        {
            return size;
        }

        public void reset()
        {
            size = max_size;

            for (int i = 0; i < max_size; i++)
            {
                cards[i].setUsed(false);
            }
        }

        public void show()
        {
            for (int i = 0; i < max_size; i++)
            {
                if (cards[i].isUsed() == false)
                {
                    Console.WriteLine($"{i}. {cards[i].getName()}");
                }
            }
        }
    }
}
