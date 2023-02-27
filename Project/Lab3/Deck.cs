/**

*--------------------------------------------------------------------

* File name: Deck.cs

* Project name: Project 2

*--------------------------------------------------------------------

* Author’s name and email: Jericho McGowan || mcgowanj2@etsu.edu

* Course-Section: 002

* Creation Date: 2/13/2023

* -------------------------------------------------------------------

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Deck
    {

        #region Fields
        //Fields
        private Card[] deckCards;
        private int nextCard;
        #endregion

        #region Constructors
        //Constructor
        public Deck()
        {
            //Iterates 52 Times and creates 52 separate objects in the array.
            deckCards = new Card[52];
            for (int i = 0; i < 52; i++)
            {
                deckCards[i] = new Card(i);
            }
            nextCard = 0;
        }
        
       //Copy Constructor
        public Deck(Deck existingDeck)
        {
            deckCards = new Card[52];
            for (int i = 0; i < 52; i++)
            {
                deckCards[i] = new Card(existingDeck.deckCards[i]);
            }
            nextCard = existingDeck.nextCard;
        }
        #endregion

        #region Functions/Methods with special action
        public void Shuffle()
        {
            nextCard = 0;
            for (int i = 0; i < deckCards.Length; i++)
            {
                //Random number Object created and range of 0-51
                Random random = new Random();
                int number = random.Next(0, 51);
                Card temp = deckCards[i];
                deckCards[i] = deckCards[number];
                deckCards[number] = temp;


            }
        }

        public Card DealACard()
        {
            nextCard++;
            return deckCards[nextCard-1];
        }

        
        public Hand DealAHand(int handSize)
        {
           Hand hand = new Hand(handSize);
            return hand;
 
            /*//Empty string for variable so the ToString can continuously add to it.
            string deck = "";
            for (int i = 0; i < handSize; i++)
            {
                deck += $"\n\t\t{DealACard().ToString()}";
            }
            return deck;
            */

        }


        public override string ToString()
        {
            //Empty string for variable so the ToString can continuously add to it.
            string deck = "";
            for (int i = 0; i < 52; i++)
            {
                deck += $"\n\t\t{deckCards[i].ToString()}";
            }
            return deck;

        }
        #endregion
    }
}
