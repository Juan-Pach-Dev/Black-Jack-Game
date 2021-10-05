using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack_Game
{
    class Dealer
    {
        List<Card> Deck;
        int HandDeck;

        public Dealer()
        {
            HandDeck = 53;
            Deck = new List<Card>(HandDeck);
        }

        public Dealer(int hand)
        {
            HandDeck = hand;
            Deck = new List<Card>(HandDeck);
        }

        public List<Card> getDealer()
        {
            return Deck;
        }

        public void generate()
        {
            Card newCard;
            for (int p = 0; p <= 52; p++)
            {
                if (p < 13)
                {
                    if (p == 0)
                    {
                        newCard = new Card(1, 14, "rojo");
                    }
                    else
                    {
                        newCard = new Card(1, p + 1, "rojo");

                    }
                }
                else if (p < 26)
                {
                    if (p == 13)
                    {
                        newCard = new Card(2, 14, "rojo");
                    }
                    else
                    {
                        newCard = new Card(2, p - 12, "rojo");
                    }
                }
                else if (p < 39)
                {
                    if (p == 26)
                    {
                        newCard = new Card(3, 14, "rojo");
                    }
                    else
                    {
                        newCard = new Card(3, p - 25, "rojo");
                    }

                }
                else
                {
                    if (p == 39)
                    {
                        newCard = new Card(4, 14, "rojo");
                    }
                    else
                    {
                        newCard = new Card(4, p - 39, "rojo");

                    }
                }
                Deck.Add(newCard);
            }

        }
        public void emptyDeck(int hand)
        {
            Deck = new List<Card>(hand);
        }
        public void showDeck()
        {
            for (int p = 0; p < HandDeck; p++)
            {
                Console.WriteLine("Suit: " + Deck[p].getSuitString() + "Score" + Deck[p].getScoreString() + "Color" + Deck[p].getColorString();
            }
        }

        public void generate(int maxScore, int minScore, int numOfsuits, String nameOfSuits)
        {

        }


        public void randomize()
        {
            Random myRandom = new Random();
            List<Card> tDeck = new List<Card>(HandDeck);

            int randomNumber = 0;
            for (int p = 0; p < 53; p++)
            {
                randomNumber = myRandom.Next(0, HandDeck);
                tDeck.Add(Deck[randomNumber]);
                Deck.RemoveAt(randomNumber);
                HandDeck--;
            }
            for (int p = 0; p < 53; p++)
            {
                Deck.Add(tDeck[p]);
            }
        }


    }
}
