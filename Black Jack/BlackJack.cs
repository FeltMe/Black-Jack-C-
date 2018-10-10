using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Black_Jack
{
    class BlackJack
    {
        public Deck[] decks = new Deck[8];
        public Player player = new Player();
        public Diller diller = new Diller();
        public void Start()
        {
            Console.WriteLine(this.player.ToString());
            Console.WriteLine(this.diller.ToString());
            SetEightDecks();
            int menu = 0;
            while (true)
            {
                Console.WriteLine("Enter 1 to");
                string choise = Console.ReadLine();
                menu = ConvertChoise(choise);
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
        }
        public void SetEightDecks()
        {
            for (int i = 0; i < 8; i++)
            {
                Deck temp_deck = new Deck();
                temp_deck.FillDeck();
                temp_deck = temp_deck.Shuffle(temp_deck);
                decks[i] = temp_deck;
            }
        }
        public void PrintAllDecks()
        {
            foreach (var item in decks)
            {
                Console.WriteLine($"Next Deck");
                foreach (var item_2 in item.CardsArr)
                {
                    Console.WriteLine(item_2.ToString());
                    Thread.Sleep(50);
                }
            }
        }
        public int ConvertChoise(string choise)
        {
            return Convert.ToInt32(choise);
        }
    }
}