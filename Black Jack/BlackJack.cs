using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Black_Jack
{
    class BlackJack
    {
        public Deck[] decks = new Deck[8];
        public void Start()
        {
            SetEightDecks();
            PrintAllDecks();
        }
        public void SetEightDecks()
        {
            for (int i = 0; i < 8; i++)
            {
                Deck temp_deck = new Deck();
                temp_deck.FillDeck();
                decks[i] = temp_deck;
            }
        }
        public void PrintAllDecks()
        {
            foreach (var item in decks)
            {
                foreach (var item_2 in item.CardsArr)
                {
                    Console.WriteLine(item_2.ToString());
                    Thread.Sleep(50);
                }
            }
        }
    }
}