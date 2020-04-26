using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {
        public string who { get; set; }
        public Card card1 { get; set; }
        public Card card2 { get; set; }

        public Hand(string who, Card Card1, Card Card2)
        {
            who = string.Empty;
            card1 = Card1;
            card2 = Card2;
        }

    }
}
