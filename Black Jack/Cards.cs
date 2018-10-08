using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Cards
    {
        public string Name { get; set; }
        public int Value { get; set; }


        public override string ToString()
        {
            return $"Name = {Name}, Value = {Value}";
        }
    }
}