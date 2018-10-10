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

        public Diller()
        {
            this.Name = "Diller OLEG =)";
        }
        public void HitOneCard(Cards card)
        {
            if (card.Value == CardValue.Ace)
            {
                Points += 1;
            }
            else if (card.Value == CardValue.Two)
            {
                Points += 2;
            }
            else if (card.Value == CardValue.Three)
            {
                Points += 3;
            }
            else if (card.Value == CardValue.Four)
            {
                Points += 4;
            }
            else if (card.Value == CardValue.Five)
            {
                Points += 5;
            }
            else if (card.Value == CardValue.Six)
            {
                Points += 6;
            }
            else if (card.Value == CardValue.Seven)
            {
                Points += 7;
            }
            else if (card.Value == CardValue.Eight)
            {
                Points += 8;
            }
            else if (card.Value == CardValue.Nine)
            {
                Points += 9;
            }
            else if (card.Value == CardValue.Ten || card.Value == CardValue.Servant || card.Value == CardValue.Queen || card.Value == CardValue.King)
            {
                Points += 10;
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
        public override string ToString()
        {
            return $"Name = {Name}, Points = {this.Points}";
        }
    }
}