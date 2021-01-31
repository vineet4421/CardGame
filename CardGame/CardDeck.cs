using System;
using System.Collections.Generic;

namespace CardGame
{
    public class CardDeck : ICardDeck
    {
        private Stack<Card> _cards;
        private string[] _values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private string[] _suits = { "Hearts", "Clubs", "Spades", "Diamond" };

        public CardDeck()
        {
            _cards = new Stack<Card>();
        }
        public Stack<Card> GetCards(bool newCardDeck = false)
        {
            if (newCardDeck)
            {
                InitialiseCardDeck();
            }
            return _cards;
        }

        public void ShuffledCards()
        {
            Stack<Card> shuffledCard = new Stack<Card>();
            Random random = new Random();
            var cardsArray = _cards.ToArray();
            for (int i = 0; i < cardsArray.Length; i++)
            {
                try
                {
                    var randomIndex = random.Next(i, cardsArray.Length-1);
                    shuffledCard.Push(cardsArray[randomIndex]);
                    cardsArray[randomIndex] = cardsArray[i];
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Due to some internal error We are unable to shuffle the card");
                }
            }
            _cards = shuffledCard;
        }

        public Card PlayACard()
        {
            return _cards.Pop();
        }

        public void DisplayCard() {
            var cards = _cards.ToArray();
            foreach (Card card in cards) {
                Console.WriteLine($"{card.Value} {card.SuitName}");
            }
        }
        private void InitialiseCardDeck()
        {
            _cards = new Stack<Card>();
            foreach (var suit in _suits)
            {
                foreach (var value in _values)
                {
                    _cards.Push(new Card() { Value = value, SuitName = suit });
                }
            }
        }
    }
}

