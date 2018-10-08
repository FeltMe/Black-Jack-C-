using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Deck
    {
        public Cards card = new Cards();
        public List<Cards> deck = new List<Cards>();
        public List<Cards> Second = new List<Cards>();

        public List<Cards> ReturnDeck()
        {
            return deck;
        }
        public void SetCurentDeck()
        {
            int ValueCard = 2;
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                 Cards temp = new Cards();
                 deck.Add(temp.Value = ValueCard);
                }
                ValueCard++;
            }
        }
        public Cards ReturnOneCard()
        {
            Cards cards = new Cards();
            int temp_rnd;
            temp_rnd = Randomise.Random.Next(deck.First, deck.Last); 
            Second = deck[temp_rnd];
            deck.Remove(temp_rnd);
            return cards;
        }
    }
}
