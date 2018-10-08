using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Deck
    {
        public List<Cards> deck = new List<Cards>();
        public Deck()
        {

        }
        public List<Cards> ReturnDeck()
        {
            return deck;
        }

    }
}
