using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        
        public int Ace { get; set; }
        public int lAce { get; set; }
        public int Two { get; set; }
        public int Three { get; set; }
        public int Four { get; set; }
        public int Five { get; set; }
        public int Six { get; set; }
        public int Seven { get; set; }
        public int Eight { get; set; }
        public int Nine { get; set; }
        public int Ten { get; set; }
        public int Jack { get; set; }
        public int Queen { get; set; }
        public int King { get; set; }

        public Card()
        {
            Ace = 0;
            Two = 2;
            Three = 3;
            Four = 4;
            Five = 5;
            Six = 6;
            Seven = 7;
            Eight = 8;
            Nine = 9;
            Ten = 10;
            Jack = 10;
            Queen = 10;
            King = 10;
           
        }

        public enum Suit
        {
            Clubs = 1,
            Hearts = 2,
            Spades = 3,
            Diamonds = 4,
        }

        public string GetSuitValue()
        {
            Random random = new Random();

            int suitCardValue = random.Next(1, 5);
            string suitValue = "";

            switch (suitCardValue)
            {
                case 1:
                    suitValue = "H";
                    break;
                case 2:
                    suitValue = "D";
                    break;
                case 3:
                    suitValue = "C";
                    break;
                case 4:
                    suitValue = "S";
                    break;
            }
            return suitValue;

        }

        public string GetCardValue()
        {
            Random random1 = new Random();

            int cardValue = random1.Next(1, 14);
            string value = "";

            switch(cardValue)
            {
                case 1:
                    value = "A";
                    break;
                case 2:
                    value = "2";
                    break;
                case 3:
                    value = "3";
                    break;
                case 4:
                    value = "4";
                    break;
                case 5:
                    value = "5";
                    break;
                case 6:
                    value = "6";
                    break;
                case 7:
                    value = "7";
                    break;
                case 8:
                    value = "8";
                    break;
                case 9:
                    value = "9";
                    break;
                case 10:
                    value = "10";
                    break;
                case 11:
                    value = "J";
                    break;
                case 12:
                    value = "Q";
                    break;
                case 13:
                    value = "K";
                    break;

            }
            return value;
        }

    }
}