using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Diller
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public CardValue Value { get; set; }
        public Cards card = new Cards();

        public Diller()
        {
            this.Name = "Diller OLEG =)";
        }
        public void HitOneCard(Cards card)
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
                if(card.Value == CardValue.Ten)
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
        }
        public bool IsHitCards()
        {
            if (this.Points >= 17)
            {
                return false;
            }
            else return true;
        }
        public void End()
        {
            if()
            {


                this.Points = 0;
                Console.WriteLine("Diller Win");
            }
        }
        public override string ToString()
        {
            return $"Name = {Name}, Points = {Points}, Suit = {this.Value}";
        }

    }
}