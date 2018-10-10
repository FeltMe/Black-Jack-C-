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

        public Deck()
        {

        }
        public void FillDeck()
        {
            CardSuit TempCardSuit = default(CardSuit);
            CardValue TempCardValue = default(CardValue);
            int temp = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Cards TempCard = new Cards();

                    if (j % 13 == 0)
                    {

                        TempCardValue = 0;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 1)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 2)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 3)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 4)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 5)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 6)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 7)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 8)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 9)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 10)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 11)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    else if (j % 13 == 12)
                    {
                        TempCardValue++;
                        TempCard.Value = TempCardValue;
                        TempCard.Suit = TempCardSuit;
                    }
                    CardsArr[temp] = TempCard;
                    temp++;
                }
                TempCardSuit++;
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
        public Cards[] RetrunArrCards()
        {
            return CardsArr;
        }
        public Cards[] Shuffle(Cards[] CurentCardsArr)
        {
            Cards[] ShuffleCards = new Cards[52];

            for (int i = 0; i < 52; i++)
            {
                int Temp_rnd = Randomise.Random.Next(0, CurentCardsArr.Length);


            }
            return ShuffleCards;
        }

    }
}