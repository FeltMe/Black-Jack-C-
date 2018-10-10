using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public enum CardSuit
    {
        HEARTS,
        TILES,
        CLOVERS,
        PIKES
    }

    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Servant,
        Queen,
        King
    }

    public class Cards
    {
        public CardValue Value { get; set; }
        public CardSuit Suit { get; set; }
        public override string ToString()
        {
            return $"Value = {Value}, Suit = {Suit}";
        }
    }
}