using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyEngine
{

    public enum CardDeckTypes { FullDeck, ShortDeck }
    public enum CardSuit { Diamonds=0, Spades=1, Clubs=2, Hearts=3 }
    public enum CardRank
    {
        Ace = 1 ,
        Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
    public class PlayingCard : IEquatable<PlayingCard>
    {   
        public PlayingCard(CardSuit suit, CardRank rank)
        {
            // Suit and Rank validation logic here
            Suit = suit;
            Rank = rank;
        }
        public PlayingCard(int suit, int rank)
        {
            // Suit and Rank validation logic here
            Suit = (CardSuit)suit;
            Rank = (CardRank)rank;
        }
        // Replace this with the plain get call like Fernando's answer in C# 6
        // You can also leave it and be careful or create a private readonly backing property
        public CardSuit Suit { get; private set; }
        public CardRank Rank { get; private set; }
        public int Power
        {
            get
            {
                if ((int)Rank != 1)
                    return (int)Rank;
                else
                    return 14;
            }
        }
        public bool Equals(PlayingCard other)
        {
            if (other == null)
            {
                return false;
            }

            return Rank == other.Rank && Suit == other.Suit;
        }
        public override int GetHashCode()
        {
            return Suit.GetHashCode() ^ Rank.GetHashCode();
        }

        // Not strictly needed but why not do it....
        public override string ToString()
        {
            // Take advantage of how the Enum.ToString() method functions
            return Rank.ToString() + " of " + Suit.ToString();
        }

    
    }
    //public abstract class CardDeck
    //{
    //    protected Card[] _deck;


    //}
    public class PlayingCardDeck 
    {
        private PlayingCard[] _deck;
        public PlayingCard[] Cards { get { return _deck; } }
        public int Count { get { return _deck.Length; } }
        public PlayingCardDeck() { }
        public PlayingCardDeck(CardDeckTypes type)
        {
            const int suitescount = 4;
            int eachcardinsuit = 0;
            switch (type)
            {
                case CardDeckTypes.FullDeck:
                    _deck = new PlayingCard[52];
                    int cardnumber = 0;
                    eachcardinsuit = 52 / suitescount;
                    for (int j = 0; j < suitescount; j++)
                    {
                        for (int i = 0; i < eachcardinsuit; i++)
                        {
                            PlayingCard pc = new PlayingCard(j, i + 1);
                            _deck[cardnumber] = pc;
                            cardnumber++;
                        }
                    }
                    break;
                case CardDeckTypes.ShortDeck:
                    _deck = new PlayingCard[36];
                    break;
            }
        }
        public string[] GetNames()
        {
            string[] names = new string[_deck.Length];
            int c = 0;
            foreach (PlayingCard pc in _deck)
            {
                names[c] = pc.Rank.ToString();
                Console.WriteLine(names[c]);
                c++;
            }
            return names;
        }
        public int[] GetPower()
        {
            int[] power = new int[_deck.Length];
            int c = 0;
            foreach (PlayingCard pc in _deck)
            {
                power[c] = pc.Power;
                Console.WriteLine(power[c]);
                c++;
            }
            return power;
        }
                  
    }
    public class Dealer : IDealer
    {
        PlayingCardDeck _pcd;
        public Dealer(PlayingCardDeck pcd)
        {
            _pcd = pcd;
        }
        public PlayingCard[] Cards
        {
            get
            {
                return _pcd.Cards;
            }
        }
        public object DrawBot()
        {
            return _pcd.Cards.Last();
        }

        public object DrawCard(int order)
        {
            return _pcd.Cards[order];
        }

        public object DrawTop()
        {
            return _pcd.Cards.First();
        }
        public void ReShuffle(int times)
        {
            for (int i = 0; i < times; i++)
            {

                Shuffle();
            }

        }
        public void Shuffle()
        {
            for (int t = 0; t < _pcd.Cards.Length; t++)
            {
                var ran = new Random();
                PlayingCard tmp = _pcd.Cards[t];
                int r = ran.Next(t, _pcd.Cards.Length);
                _pcd.Cards[t] = _pcd.Cards[r];
                _pcd.Cards[r] = tmp;
            }
        }
        public void PrintDeck()
        {
            foreach (PlayingCard pc in _pcd.Cards)
            {
                Console.WriteLine(pc.ToString() + "Pow " + pc.Power);
            }
        }
        public int GetCardCount()
        {
            return _pcd.Cards.Length;

        }
    }
   

}
//public class ClassicCardDeck: PlayingCardDeck
//{

//    string[] cardnames = new[] { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

//}


