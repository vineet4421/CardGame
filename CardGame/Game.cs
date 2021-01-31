using System;
using System.Collections.Generic;

namespace CardGame
{
    //This class will help in playing game
    public class Game
    {
        ICardDeck _cardDeck;
        public Game(ICardDeck cardDeck)
        {
            _cardDeck = cardDeck;
        }

        //Play Game function will give option and take action according to selected option
        public void PlayGame() {
            Stack<Card> cards = _cardDeck.GetCards(true);
            _cardDeck.ShuffledCards();
            while (cards.Count > 0)
            {
                Console.WriteLine("Please choose one option to play game");
                Console.WriteLine("1. Play a card \n2. Shuffle the deck \n3. Restart the Game \n");
                var userInput = Console.ReadKey();
                Console.WriteLine();
                int option = -1;
                if (char.IsDigit(userInput.KeyChar))
                {
                    option = int.Parse(userInput.KeyChar.ToString()); // use Parse if it's a Digit
                }
                
                switch (option)
                {
                    case 1:
                        {
                            var card =_cardDeck.PlayACard();
                            Console.WriteLine($"You have played the {card.Value} of {card.SuitName}");
                            break;
                        }
                    case 2:
                        {
                            _cardDeck.ShuffledCards();
                            break;
                        }
                    case 3:
                        {
                            _cardDeck.GetCards(true);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please choose correct option as a number");
                            break;
                        }
                }
                cards = _cardDeck.GetCards();
                Console.WriteLine();
            }
            Console.WriteLine("Game has been Completed");
        }
    }
}
