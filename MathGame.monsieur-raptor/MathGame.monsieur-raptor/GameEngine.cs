namespace MathGame.monsieur_raptor
{
    internal class GameEngine
    {
        const int MAX_GAMES = 5;

        internal void AdditionGame(string gameName)
        {
            Console.Clear();
            Console.WriteLine($"Let's play with {gameName}s!\n");

            for(int i = 1; i <= MAX_GAMES; i++)
            {
                int[] randomNumbers = Helpers.GetRandomNumbers();
                int firstNumber = randomNumbers[0];
                int secondNumber = randomNumbers[1];

                Console.WriteLine($"Game {i}/{MAX_GAMES}");
                Console.WriteLine($"{firstNumber} + {secondNumber}");
                string playerAnswer = Console.ReadLine();

                if (int.Parse(playerAnswer) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect.");
                }
                Console.WriteLine("---");
            }            
        }

        internal void SubstractionGame(string gameName)
        {
            Console.WriteLine("You selected Substraction");
        }

        internal void MultiplicationGame(string gameName)
        {
            Console.WriteLine("You selected Multiplication");
        }

        internal void DivisionGame(string gameName)
        {
            Console.WriteLine("You selected Division");
            int[] divisonNumbers = Helpers.GetDivisionNumbers();
            int firstNumber = divisonNumbers[0];
            int secondNumber = divisonNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
        }
    }
}