using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {

        //Was going to reference this site https://stackoverflow.com/questions/35399139/blackjack-deck-class-creationg-c-sharp
        
        //This is example code they had I was going to reference but did not actually use.

        /** public Deck()
                public Card[] Cards { get; set; }
                public Random RandomGenerator { get; set; }

                    
                {
                    int i = 0;
                    this.Cards = new Card[52];

                    foreach (string value1 in Card.GetCardValue())
                    {
                        foreach (string suit1 in Card.GetSuitValue())
                        {
                            this.Cards[i] = new Card(suit1, value1);
                            i++;
                        }
                    }

                    this.RandomGenerator = new Random();
                }
                    
                public Card DrawCard()
                {
                    int randomNumber;

                    do
                    {
                        randomNumber = RandomGenerator.Next(0, 52);
                    }
                    while (Cards[randomNumber] == null);

                    Card drawnCard = Cards[randomNumber];
                    Cards[randomNumber] = null;
                    return drawnCard;
                }
            **/
    }

}
