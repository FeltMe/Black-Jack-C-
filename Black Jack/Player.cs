using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Player : IPersom_who_play
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Money { get; set; }
        public int Bet { get; set; }
        public CardValue Value { get; set; }
        public Cards card = new Cards();
        public int Points { get; set; }


        public Player()
        {
            Age = Randomise.Random.Next(18, 20);
            Money = Randomise.Random.Next(1000, 2000);
            Name = "User";
        }

        public void HitOneCard(Cards card)
        {
            if(Points <= 21)
            {
                if (card.Value == CardValue.Ace)
                {
                    Points += 1;
                    Value = CardValue.Ace;
                }
                else if (card.Value == CardValue.Two)
                {
                    Points += 2;
                    Value = CardValue.Two;
                }
                else if (card.Value == CardValue.Three)
                {
                    Points += 3;
                    Value = CardValue.Three;
                }
                else if (card.Value == CardValue.Four)
                {
                    Points += 4;
                    Value = CardValue.Three;
                }
                else if (card.Value == CardValue.Five)
                {
                    Points += 5;
                    Value = CardValue.Three;

                }
                else if (card.Value == CardValue.Six)
                {
                    Points += 6;
                    Value = CardValue.Three;

                }
                else if (card.Value == CardValue.Seven)
                {
                    Points += 7;
                    Value = CardValue.Three;

                }
                else if (card.Value == CardValue.Eight)
                {
                    Points += 8;
                    Value = CardValue.Three;

                }
                else if (card.Value == CardValue.Nine)
                {
                    Points += 9;
                    Value = CardValue.Three;

                }
                else if (card.Value == CardValue.Ten || card.Value == CardValue.Servant || card.Value == CardValue.Queen || card.Value == CardValue.King)
                {
                    Points += 10;
                    if (card.Value == CardValue.Ten)
                    {
                        Value = CardValue.Ten;
                    }
                    else if (card.Value == CardValue.Ten)
                    {
                        Value = CardValue.Servant;
                    }
                    else if (card.Value == CardValue.Queen)
                    {
                        Value = CardValue.Queen;
                    }
                    else if (card.Value == CardValue.King)
                    {
                        Value = CardValue.King;
                    }
                }
                else
                {
                    Lost();
                }
            }
        }
        public void Win(int money)
        {
            this.Money += money;
            Console.WriteLine("Player Win!!");
            this.Points = 0;
            this.Bet = 0;
        }
        public void Lost()
        {
            this.Money -= Bet;
            Console.WriteLine("Player Lost!!");
            this.Points = 0;
        }
        public int FillBet()
        {
            Console.Write("Enter Bet = ");
            string temp = Console.ReadLine();
            int temp_bet = Convert.ToInt32(temp);
            Bet = temp_bet;
            Money -= Bet;
            return Bet;
        }

        public override string ToString()
        {
            return $"Name = {Name}, Age = {Age}, Money = {Money}";
        }

    }
}