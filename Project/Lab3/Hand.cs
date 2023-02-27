/**

*--------------------------------------------------------------------

* File name: Hand.cs

* Project name: Project 2

*--------------------------------------------------------------------

* Author’s name and email: Jericho McGowan || mcgowanj2@etsu.edu

* Course-Section: 002

* Creation Date: 2/27/2023

* -------------------------------------------------------------------

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Hand
    {
        #region Fields
        private Card[] gameHand;
        private int handSize;
        private int cardsInHand;
        #endregion


        #region Constructors
        public Hand()
        {
            handSize = 5;
            cardsInHand = 0;
            this.gameHand = new Card[handSize];
            for (int i = 0; i < gameHand.Length; i++)
            {
                gameHand[i] = new Card(i);
            }

        }
        public Hand(int handSize)
        {
            this.handSize = handSize;
            cardsInHand = 0;
            gameHand = new Card[handSize];
            for (int i = 0; i < gameHand.Length; i++)
            {
                gameHand[i] = new Card(i);
            }
        }
     

        public Hand(Hand existingHand)
        {

                this.gameHand = new Card[handSize];
                for (int i = 0; i <= gameHand.Length; i++)
                {
                    gameHand[i] = new Card(existingHand.gameHand[i]);
                }
                handSize = existingHand.handSize;
                cardsInHand= existingHand.cardsInHand;
            
        }
        #endregion


        #region AddACard
        public void AddACard(Card card)
        {
           if (cardsInHand <= handSize)
            {
                cardsInHand++;
                Console.WriteLine($"A card was added to the deck. \n Cards in Hand: {cardsInHand}");
            }
            else
            {
                Console.WriteLine("You have reached your maximum hand size. No more cards can be added.");
            }
        }

        #endregion


        #region ToString
        public override string ToString()
        {
            string hand = "";
            for (int i = 0; i < gameHand.Length; i++)
            {
                hand += $"\n{gameHand[i].ToString()}, ";
            }
            return $"hand size is {gameHand.Length} cards. The cards in your deck are {hand}";
        }
        #endregion
    }

}
