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

        public void Win(int money)
        {
            this.Money += money;
            Console.WriteLine("Diller Win!!");
            this.Points = 0;
            this.Bet = 0;
        }
        public void Lost()
        {
            this.Money -= Bet;
            Console.WriteLine("Diller Lost!!");
        }
        public int FillBet()
        {
            Console.WriteLine("Enter Bet = ");
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