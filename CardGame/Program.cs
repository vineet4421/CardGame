using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to start the game (Y/N)?");
            var response = Console.ReadKey();
            Console.WriteLine();
            if (response.Key.Equals(ConsoleKey.Y))
            {
                var cardDeck = new CardDeck();
                Game game = new Game(cardDeck);
                game.PlayGame();
            }
            else
            {
                Console.WriteLine("You have been exited from the game");
            }
            Console.ReadKey();
        }
    }
}
