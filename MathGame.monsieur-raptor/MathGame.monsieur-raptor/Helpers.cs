using System.Security.AccessControl;
using MathGame.monsieur_raptor.Models;

namespace MathGame.monsieur_raptor
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>();

        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();

            int[] result = new int[2];
            do
            {
                result[0] = random.Next(1, 99);
                result[1] = random.Next(1, 99);
            }
            while (result[0] % result[1] != 0);
            return result;
        }

        internal static int[] GetRandomNumbers()
        {
            Random random = new Random();

            int[] result = [random.Next(0, 9), random.Next(0, 9)];
            return result;
        }

        internal static int checkAnswer(int score, int i, int result, string playerAnswer)
        {
            if (int.Parse(playerAnswer) == result)
            {
                score++;
                Console.Write("Your answer was correct! ");
                Console.WriteLine(i != 5 ? "Press Enter for the next question" : "Press any key to continue");
                Console.ReadKey(false);
            }
            else
            {
                Console.Write("Your answer was incorrect! ");
                Console.WriteLine(i != 5 ? "Press Enter for the next question" : "Press any key to continue");
                Console.ReadKey(false);
            }
            Console.WriteLine("-----");
            if (i == 5) Console.WriteLine($"Game over. Your final score is {score}\nPress Enter to go back to the main menu.\n");
            return score;
        }

        public static void AddToHistory(int score, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = gameType
            });
        }

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("----------------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }
            Console.WriteLine("----------------------------------------------------\n"); ;
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadKey(false);
        }

        internal static string? ValidateResults(string playerAnswer)
        {
            while (string.IsNullOrEmpty(playerAnswer) || !Int32.TryParse(playerAnswer, out _))
            {
                Console.WriteLine("Your answer needs to be an interger. Try again.");
                playerAnswer = Console.ReadLine();
            }
            return playerAnswer;
        }

        internal static string GetName()
        {
            Console.Write("Enter your name > ");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Your name can't be empty.");
                Console.Write("> ");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}
