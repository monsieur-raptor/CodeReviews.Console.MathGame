using MathGame.monsieur_raptor.Models;

namespace MathGame.monsieur_raptor
{
    internal class Menu
    {
        GameType gameType;

        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello, {name}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself!\n");
            Console.WriteLine("Press any key to show menu.");
            Console.ReadKey(false);
            Console.WriteLine("\n");

            bool isPlaying = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game do you want to play today? Choose from the options below:
    V - View previous games
    A - Addition
    S - Substraction
    M - Multiplication
    D - Division
    R - Random game
    Q - Quit the program");

                Console.WriteLine("----------------------------------------------------");

                string gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameType = GameType.Addition;
                        gameEngine.Calculation(gameType);
                        break;
                    case "s":
                        gameType = GameType.Substraction;
                        gameEngine.Calculation(gameType);
                        break;
                    case "m":
                        gameType = GameType.Multiplication;
                        gameEngine.Calculation(gameType);
                        break;
                    case "d":
                        gameType = GameType.Division;
                        gameEngine.Calculation(gameType);
                        break;
                    case "r":
                        gameType = Helpers.RandomGameSelector();
                        gameEngine.Calculation(gameType);
                        break;
                    case "q":
                        Console.WriteLine("Thanks for playing. See you soon!");
                        isPlaying = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            } while (isPlaying);
        }
    }
}
