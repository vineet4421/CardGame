using System.Collections.Generic;

namespace CardGame
{
    public interface ICardDeck
    {
        Stack<Card> GetCards(bool newCardDeck = false);
        Card PlayACard();
        void ShuffledCards();
        void DisplayCard();
    }
}