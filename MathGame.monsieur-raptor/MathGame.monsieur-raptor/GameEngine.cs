using MathGame.monsieur_raptor.Models;

namespace MathGame.monsieur_raptor
{
    internal class GameEngine
    {
        const int MAX_GAMES = 5;

        internal void Calculation(GameType gameType)
        {
            Console.Clear();
            Console.WriteLine($"Let's play with {gameType}s!\n");
            char gameOperator = new char();
            int result = new int();
            int[] randomNumbers = new int[2];
            int score = 0;

            for (int i = 1; i <= MAX_GAMES; i++)
            {
                if (gameType != GameType.Division)
                    randomNumbers = Helpers.GetRandomNumbers();
                else
                    randomNumbers = Helpers.GetDivisionNumbers();

                int firstNumber = randomNumbers[0];
                int secondNumber = randomNumbers[1];

                switch(gameType)
                {
                    case GameType.Addition:
                        result = firstNumber + secondNumber;
                        gameOperator = '+';
                        break;
                    case GameType.Substraction:
                        result = firstNumber - secondNumber;
                        gameOperator = '-';
                        break;
                    case GameType.Multiplication:
                        result = firstNumber * secondNumber;
                        gameOperator = '*';
                        break;
                    case GameType.Division:
                        result = firstNumber / secondNumber;
                        gameOperator = '/';
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Game {i}/{MAX_GAMES}");
                Console.WriteLine("-----");
                Console.Write($"{firstNumber} {gameOperator} {secondNumber} = ");
                string playerAnswer = Console.ReadLine();
                playerAnswer = Helpers.ValidateResults(playerAnswer);

                score = Helpers.CheckAnswer(score, i, result, playerAnswer);
            }
            Helpers.AddToHistory(score, gameType);
        }
    }
}