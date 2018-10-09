using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Black_Jack
{
    class Deck
    {
        public Cards[] CardsArr = new Cards[52];
        public void FillDeck()
        {
            CardSuit TempCardSuit = default(CardSuit);
            CardValue TempCardValue = default(CardValue);
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Cards TempCard = new Cards();

                    if (i % 13 == 0)
                    {
                        TempCardSuit++;
                        TempCardValue = 0;
                    }
                    else if(i % 13 == 1)
                    {
                        TempCard.Value = TempCardValue;
                    }
                }
            }
        }
        public void PrintDeck()
        {
            foreach (var item in CardsArr)
            {
                Console.WriteLine(item.ToString());
                Thread.Sleep(200);
            }
        }
        public Cards ReturnOneCard()
        {
            return new Cards();
        }
    }
}
