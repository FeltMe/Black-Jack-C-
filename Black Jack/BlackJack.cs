using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class BlackJack
    {   
        public Deck deck = new Deck();
        public void Start()
        {
            deck.FillDeck();
            deck.PrintDeck();
        }
    }
}
