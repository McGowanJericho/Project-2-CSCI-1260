/**

*--------------------------------------------------------------------

* File name: Card.cs

* Project name: Project 2

*--------------------------------------------------------------------

* Author’s name and email: Jericho McGowan || mcgowanj2@etsu.edu

* Course-Section: 002

* Creation Date: 2/6/2023 

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
    internal class Card
    {
        // Fields
        #region Fields
        private Suit suit;
        private Face face;
        #endregion

        //Constructors
        #region Constructors
        //Default Constructor
        public Card()
        {
            suit = Suit.Clubs;
            face = Face.King;
        }
        //Parameterized Constructor
        public Card(int n)
        {
            SetFace((Face)Enum.GetValues(typeof(Face)).GetValue(n % 13));
            SetSuit((Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4));
        }
        //Copy Constructor
        public Card(Card existingCard)
        {
            SetFace(existingCard.GetFace());
            SetSuit(existingCard.GetSuit());
        }
        #endregion


        //Getters and Setters Below
        #region Get/Set

        #region Get/Set of Face
        //Getter of Face

        public Face GetFace()
        {
            return face;
        }
        //Setter of Face
        public void SetFace(Face face)
        {
            this.face = face;
        }
        #endregion


        #region Get/Set of Suit
        //Getter of Suit
        public Suit GetSuit()
        {
            return suit;
        }
        //Setter of Suit
        public void SetSuit(Suit suit)
        {
            this.suit = suit;
        }
        #endregion

        #endregion


        //ToString of Card class
        #region ToString
        public override string ToString()
        {
            return $"the {face} of {suit}";


        }
        #endregion

    }
}
