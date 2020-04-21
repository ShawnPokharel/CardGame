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

        //Constructor- dont know if we need this anymore tbh
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

        //method that uses a random number generator to output the suitvalue that the api will retrieve
        public string GetSuitValue()
        {
            Random random = new Random();



            int suitCardValue = 0;

            for (int i = 0; i < 5; i++)
            {
                suitCardValue = random.Next(4);
            }
            string suitValue = "";

            switch (suitCardValue)
            {
                case 0:
                    suitValue = "H";
                    break;
                case 1:
                    suitValue = "D";
                    break;
                case 2:
                    suitValue = "C";
                    break;
                case 3:
                    suitValue = "S";
                    break;
            }
            return suitValue;

        }

        //method that uses another random number generator to outplut the value of the card that the api will retrieve
        public string GetCardValue()
        {
            Random random1 = new Random();

            int cardValue = 0;
            for (int i = 0; i < 10; i++)
            {
                cardValue = random1.Next(13);
            }

           
            string value = "";

            switch(cardValue)
            {
                case 0:
                    value = "0";
                    break;
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
                    value = "J";
                    break;
                case 11:
                    value = "Q";
                    break;
                case 12:
                    value = "K";
                    break;

            }
            return value;
        }

    }
}