/**

*--------------------------------------------------------------------

* File name: Program.cs

* Project name: Project 2: Hand-Deck-Cards

*--------------------------------------------------------------------

* Author’s name and email: Jericho McGowan || mcgowanj2@etsu.edu

* Course-Section: 002

* Creation Date: 2/13/2023

* -------------------------------------------------------------------

*/
using System.Runtime.CompilerServices;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creation of Decks
            //Create deck and Shuffle
            Console.WriteLine("------------------------------------------------------------------------------\n");
            Console.WriteLine("This is the Default Deck:");
            Deck deck = new Deck();
            Console.WriteLine($"{deck.ToString()}");
            Console.WriteLine("\n------------------------------------------------------------------------------\n");

            //Shuffle Cards
            deck.Shuffle();
            Console.WriteLine("------------------------------------------------------------------------------\n");
            Console.WriteLine("This is the Deck Shuffled:");
            Console.WriteLine($"{deck.ToString()}");
            Console.WriteLine("\n------------------------------------------------------------------------------\n");

            //Copy Deck
            Console.WriteLine("------------------------------------------------------------------------------\n");
            Console.WriteLine("This is the Copy Deck");
            Deck copyDeck = new Deck(deck);
            Console.WriteLine($"{copyDeck.ToString()}");
            Console.WriteLine("\n------------------------------------------------------------------------------\n");
            #endregion
            #region Deal
            //Deal 7 Cards 1
            Console.WriteLine("------------------------------------------------------------------------------\n");
            Console.WriteLine("Deal 7 Cards From the Copy Deck (1):");
            Console.WriteLine(copyDeck.DealAHand(7));
            Console.WriteLine("\n------------------------------------------------------------------------------\n");

            //Deal 7 Cards 2
            Console.WriteLine("------------------------------------------------------------------------------\n");
            Console.WriteLine("Deal 7 Cards From the Copy Deck (2):");

            Console.WriteLine(copyDeck.DealAHand(7));
            Console.WriteLine("\n------------------------------------------------------------------------------\n");
            #endregion


            #region Size of Hand Prompt
            int handSize = 0;
            bool validSizeHand; 
            bool hpWorkBool = false;
            bool validPlayer;
            int playerSize = 0;
            while (hpWorkBool == false)
            {
                validSizeHand = false;
                while (validSizeHand == false)
                {
                    try
                    {
                        Console.Write("What size of a hand will be used?: ");
                        handSize = Convert.ToInt32(Console.ReadLine());
                        validSizeHand = true;
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid handsize, try again.");
                        validSizeHand = false;
                    }
                }

                #endregion

                #region How Many Players?
                validPlayer = false;
                while (validPlayer == false)
                {
                    try
                    {
                        Console.Write("How many players are there?: ");
                        playerSize = Convert.ToInt32(Console.ReadLine());

                        validPlayer = true;
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid amount of players, try again.");
                        validPlayer = false;
                    }

                }

                #endregion

                #region Checking if there will be enough cards.

                double hpwork = (playerSize * handSize);

                if (hpwork < 52)
                {
                    Console.WriteLine($"There are enough cards in the deck to deal {playerSize} hands of {handSize} cards.");
                    hpWorkBool = true;
                }
                else
                {
                    Console.WriteLine($"There are not enough cards in the deck to deal {playerSize} hands of {handSize} cards. Try again.");
                }
            }
            #endregion

            //Stuck
            deck.Shuffle();
            Hand[] h = new Hand[playerSize];
            for (int i = 0; i < playerSize; i++) 
            {
                h[i] = deck.DealAHand(handSize);
                Console.WriteLine($"Hand for Player {i+1} is {h[i].ToString()}");
            }
           

      
           
            








        }

    }

}

