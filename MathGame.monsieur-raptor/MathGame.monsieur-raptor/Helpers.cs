namespace MathGame.monsieur_raptor
{
    internal class Helpers
    {
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

            int[] result = new int[2];
            result[0] = random.Next(0, 9);
            result[1] = random.Next(0, 9);

            return result;
        }

        internal static int checkAnswer(int score, int i, int result, string playerAnswer)
        {
            if (int.Parse(playerAnswer) == result)
            {
                score++;
                Console.Write("Your answer was correct! ");
                Console.WriteLine(i != 5 ? "Type any key for the next question" : "Type any key to continue");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Your answer was incorrect! ");
                Console.WriteLine(i != 5 ? "Type any key for the next question" : "Type any key to continue");
                Console.ReadLine();
            }
            Console.WriteLine("---");
            if (i == 5) Console.WriteLine($"Game over. Your final score is {score}\n");
            return score;
        }
    }
}
