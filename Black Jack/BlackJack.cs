using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Black_Jack
{
    class BlackJack
    {
        public Deck[] decks = new Deck[8];
        public Player player = new Player();
        public Diller diller = new Diller();
        public int TotalBank { get; set; }
        public void Start()
        {   
            int menu = 0;
            PrintInfoPD();
            SetEightDecks();
            IncludeFile();

            while (true)
            {
                PrintChoises();
                string choise = Console.ReadLine();
                menu = ConvertChoise(choise);
                
                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine("Stand");
                            player.Stand();
                            int temp_rnd_i = Randomise.Random.Next(0, 8);
                            int temp_rnd_j = Randomise.Random.Next(0, 53);
                            
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Hit");
                            player.Hit();

                        } break;
                    case 3:
                        {
                            Console.WriteLine("DobleDown");
                            player.DobleDown();

                        }break;
                    case 4:
                        {
                            Console.WriteLine("Surender");
                            player.Surrender();
                        }break;
                    default:
                        {
                            Console.WriteLine("Eror 404");
                            Thread.Sleep(1000);
                        } break;
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
        public void CreateAndWriteToFilePerson()
        {
            using (FileStream file = File.Open(@"D:\BlackJacjInfo.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var writer = new StreamWriter(file))
                {
                    writer.Write(player.Name);
                    writer.Write(player.Money);
                    writer.Write(player.Age);
                    writer.Write(diller.Name);
                }
            }
        }
        public void WriteDecksToFile()
        {
            using (FileStream file = File.Open(@"D:\BlackJacjInfo.txt", FileMode.Open, FileAccess.Write))
            {
                using (var writer = new StreamWriter(file))
                {
                    foreach (var item in decks)
                    {
                        foreach (var item_2 in item.CardsArr)
                        {
                            writer.Write(item_2.Value);
                            writer.Write(item_2.Suit);
                        }
                    }
                }
            }
        }
        public void IncludeFile()
        {
            try
            {
                CreateAndWriteToFilePerson();
                WriteDecksToFile();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        public void PrintInfoPD()
        {
            Console.WriteLine(this.player.ToString());
            Console.WriteLine(this.diller.ToString());
        }
        public void PrintChoises()
        {
            Console.WriteLine("Enter 1 to Stand");
            Console.WriteLine("Enter 2 to Hit");
            Console.WriteLine("Enter 3 to DoubleDown");
            Console.WriteLine("Enter 3 to Surrender");
            Console.WriteLine();
        }
        public void ComparisonPoints()
        {

        }
        public Cards FirstDrop()
        {
            Cards temp = new Cards();
            int temp_rnd_i = Randomise.Random.Next(0, 8);
            int temp_rnd_j = Randomise.Random.Next(0, 53);
            temp = decks[temp_rnd_i].CardsArr[temp_rnd_j];
            return temp;
        }
    }
}