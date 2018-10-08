using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Money { get; set; }
        
        public Player ()
	    {
        Age = Randomise.Random.Next(18, 20);
        Money = Randomise.Random.Next(1000, 2000);
        Name = "User";
	    }
        public override string ToString()
        {
            return $"Name = {Name}, Age = {Age}, Money = {Money}";
        }

    }
}
