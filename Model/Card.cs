using System;

namespace Model
{
    public class Card
    {
        private Suit suit;
        private int number;

        public Suit Suit { get => suit; set => suit = value; }

        public int Number { get => number; set => number = value; }

        public bool IsBlack()
        {
            return true;
        }

        public bool IsRed()
        {
            return true; 
        }

    }

    public enum CardType
    {

    }

    public enum Suit
    {
        // ♥ 
        Heart,
        // ♠
        Spade,
        // ♦
        Club,
        // ♣
        Diamond
    }

}
