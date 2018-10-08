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
                 deck.Add()
                }
            }
        }

    }
}
