namespace MathGame.monsieur_raptor
{
    internal class Menu
    {
        string gameName;

        GameEngine gameEngine = new();
        internal void showMenu(string name, DateTime date)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Hello, {name}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself!\n");

            bool isPlaying = true;

            do
            {
                Console.WriteLine($@"What game do you want to play today? Choose from the options below:
                    A - Addition
                    S - Substraction
                    M - Multiplication
                    D - Division
                    Q - Quit the program");

                Console.WriteLine("----------------------------------------------------");

                string gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        gameName = "Addition";
                        gameEngine.AdditionGame(gameName);
                        break;
                    case "s":
                        gameName = "Substraction";
                        gameEngine.SubstractionGame(gameName);
                        break;
                    case "m":
                        gameName = "Multiplication";
                        gameEngine.MultiplicationGame(gameName);
                        break;
                    case "d":
                        gameName = "Division";
                        gameEngine.DivisionGame(gameName);
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

        internal static string GetName()
        {
            Console.Write("Enter your name > ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
