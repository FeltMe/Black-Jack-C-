﻿using System;
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
            Console.WriteLine("");
            SetEightDecks();
            IncludeFile();

            while (true)
            {
                TotalBank += player.FillBet();
                TotalBank += diller.FillBet();

                while (TotalBank != 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Diller points = {diller.Points}");
                    Console.WriteLine($"Player points = {player.Points}");
                    Console.WriteLine("");
                    menu = Choises();
                    switch (menu)
                    {
                        case 1:
                            {
                                Console.WriteLine("\t\t\t\tStand");
                                Stand();
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("\t\t\t\tHit");
                                Hit();

                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("\t\t\t\tDobleDown");
                                DobleDown();

                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("\t\t\t\tSurender");
                                Surrender();
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("\t\tEror 404");
                                Thread.Sleep(1000);
                            }
                            break;
                    }
                }
            }
        }
        public Cards CardDrop()
        {
            Cards temp = new Cards();
            int temp_rnd_i = Randomise.Random.Next(0, 8);
            int temp_rnd_j = Randomise.Random.Next(0, 53);
            temp = decks[temp_rnd_i].CardsArr[temp_rnd_j];
            return temp;
        }
        public int ConvertChoise(string choise)
        {
            return Convert.ToInt32(choise);
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
        public int Choises()
        {
            int menu;
            Console.WriteLine("Enter 1 to Stand");
            Console.WriteLine("Enter 2 to Hit");
            Console.WriteLine("Enter 3 to DoubleDown");
            Console.WriteLine("Enter 3 to Surrender");
            string choise = Console.ReadLine();
            menu = ConvertChoise(choise);
            return menu;
        }
        public void Stand()
        {
            if(player.Points > diller.Points)
            {
                player.Win(TotalBank);
                diller.Lost();
                TotalBank = 0;
            }
            else if(player.Points == diller.Points && player.Points != 0 && diller.Points != 0)
            {
                player.Win(TotalBank);
                diller.Lost();
                TotalBank = 0;
            }
            else
            {
                player.Lost();
                diller.Win(TotalBank);
                TotalBank = 0;
            }
        }
        public void Hit()
        {
            int temp_rnd_i = Randomise.Random.Next(0, 8);
            int temp_rnd_j = Randomise.Random.Next(0, 53);
            int temp_rnd_i_2 = Randomise.Random.Next(0, 8);
            int temp_rnd_j_2 = Randomise.Random.Next(0, 53);

            player.HitOneCard(decks[temp_rnd_i].CardsArr[temp_rnd_j]);
            diller.HitOneCard(decks[temp_rnd_i_2].CardsArr[temp_rnd_j_2]);
        }
        public void DobleDown()
        {
            TotalBank += player.FillBet();
            TotalBank += diller.FillBet();
        }
        public void Surrender()
        {
            diller.Win(TotalBank);
            player.Lost();
            TotalBank = 0;
        }
    }
}