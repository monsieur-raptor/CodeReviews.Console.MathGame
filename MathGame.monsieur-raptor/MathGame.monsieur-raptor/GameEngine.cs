using MathGame.monsieur_raptor.Models;

namespace MathGame.monsieur_raptor
{
    internal class GameEngine
    {
        const int MAX_GAMES = 5;

        internal void AdditionGame(GameType gameType)
        {
            Console.Clear();
            Console.WriteLine($"Let's play with {gameType}s!\n");
            int score = 0;

            for(int i = 1; i <= MAX_GAMES; i++)
            {
                int[] randomNumbers = Helpers.GetRandomNumbers();
                int firstNumber = randomNumbers[0];
                int secondNumber = randomNumbers[1];
                int result = firstNumber + secondNumber;

                Console.WriteLine($"Game {i}/{MAX_GAMES}");
                Console.WriteLine("-----");
                Console.Write($"{firstNumber} + {secondNumber} = ");
                string playerAnswer = Console.ReadLine();
                playerAnswer = Helpers.ValidateResults(playerAnswer);

                score = Helpers.checkAnswer(score, i, result, playerAnswer);
            }
            Helpers.AddToHistory(score, gameType);
        }

        internal void SubstractionGame(GameType gameType)
        {
            Console.Clear();
            Console.WriteLine($"Let's play with {gameType}s!\n");
            int score = 0;

            for (int i = 1; i <= MAX_GAMES; i++)
            {
                int[] randomNumbers = Helpers.GetRandomNumbers();
                int firstNumber = randomNumbers[0];
                int secondNumber = randomNumbers[1];
                int result = firstNumber - secondNumber;

                Console.WriteLine($"Game {i}/{MAX_GAMES}");
                Console.WriteLine("-----");
                Console.Write($"{firstNumber} - {secondNumber} = ");
                string playerAnswer = Console.ReadLine();
                playerAnswer = Helpers.ValidateResults(playerAnswer);

                score = Helpers.checkAnswer(score, i, result, playerAnswer);
            }
            Helpers.AddToHistory(score, gameType);
        }

        internal void MultiplicationGame(GameType gameType)
        {
            Console.Clear();
            Console.WriteLine($"Let's play with {gameType}s!\n");
            int score = 0;

            for (int i = 1; i <= MAX_GAMES; i++)
            {
                int[] randomNumbers = Helpers.GetRandomNumbers();
                int firstNumber = randomNumbers[0];
                int secondNumber = randomNumbers[1];
                int result = firstNumber * secondNumber;

                Console.WriteLine($"Game {i}/{MAX_GAMES}");
                Console.WriteLine("-----");
                Console.Write($"{firstNumber} x {secondNumber} = ");
                string playerAnswer = Console.ReadLine();
                playerAnswer = Helpers.ValidateResults(playerAnswer);

                score = Helpers.checkAnswer(score, i, result, playerAnswer);
            }
            Helpers.AddToHistory(score, gameType);
        }

        internal void DivisionGame(GameType gameType)
        {
            Console.Clear();
            Console.WriteLine($"Let's play with {gameType}s!\n");
            int score = 0;

            for (int i = 1; i <= MAX_GAMES; i++)
            {
                int[] divisonNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisonNumbers[0];
                int secondNumber = divisonNumbers[1];
                int result = firstNumber / secondNumber;

                Console.WriteLine($"Game {i}/{MAX_GAMES}");
                Console.WriteLine("-----");
                Console.Write($"{firstNumber} / {secondNumber} = ");
                string playerAnswer = Console.ReadLine();
                playerAnswer = Helpers.ValidateResults(playerAnswer);

                score = Helpers.checkAnswer(score, i, result, playerAnswer);
            }
            Helpers.AddToHistory(score, gameType);
        }
    }
}