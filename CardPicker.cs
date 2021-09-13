using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i< numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // get a random number from 1 to 4
            int value = random.Next(1, 5);                  
            // if it's 1 return the string Spades
            if (value == 1) return "Spades";
            // if it's 2 return the string Hearts
            if (value == 2) return "Hearts";
            // if it's 3 return the string Clubs
            if (value == 3) return "Clubs";
            // if we haven't returned yet, return the string Diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            // This gets a random avlue from 1 to 14
            // That's how many cards are in a deck
            int value = random.Next(1, 14);
            // This will give the first card in the deck
            // the face value of Ace
            if (value == 1) return "Ace";
            // This will give the 11th card in the deck
            // the face value of Jack
            if (value == 11) return "Jack";
            // This will give the 12th card in the deck
            // the face value of Queen
            if (value == 12) return "Queen";
            // This will give the 13th card in the deck
            // the face value of King
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
