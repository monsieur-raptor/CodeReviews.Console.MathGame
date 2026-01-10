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
    }
}
