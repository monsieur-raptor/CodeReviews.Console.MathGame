namespace MathGame.monsieur_raptor
{
    internal class GameEngine
    {
        const int MAX_GAMES = 5;

        internal void AdditionGame(string gameType)
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
                Console.WriteLine("---");
                Console.Write($"{firstNumber} + {secondNumber} = ");
                string playerAnswer = Console.ReadLine();

                score = Helpers.checkAnswer(score, i, result, playerAnswer);
            }
        }

        internal void SubstractionGame(string gameType)
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
                Console.Write($"{firstNumber} - {secondNumber} = ");
                string playerAnswer = Console.ReadLine();

                score = Helpers.checkAnswer(score, i, result, playerAnswer);

            }
        }

        internal void MultiplicationGame(string gameType)
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
                Console.Write($"{firstNumber} x {secondNumber} = ");
                string playerAnswer = Console.ReadLine();

                score = Helpers.checkAnswer(score, i, result, playerAnswer);

            }
        }

        internal void DivisionGame(string gameType)
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
                Console.Write($"{firstNumber} / {secondNumber} = ");
                string playerAnswer = Console.ReadLine();

                score = Helpers.checkAnswer(score, i, result, playerAnswer);

            }
        }
    }
}