using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Suit
    {
        public string CardSuit { get; set; }
        public override string ToString()
        {
            return $"Suit = {CardSuit}";
        }
    }
}
