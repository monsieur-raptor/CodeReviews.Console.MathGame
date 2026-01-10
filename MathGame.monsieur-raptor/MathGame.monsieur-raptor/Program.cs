internal class Program
{
    private static void Main(string[] args)
    {
        string name = GetName();
        var date = DateTime.Now;

        Menu(name, date);

        string gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToLower())
        {
            case "a":
                AdditionGame();
                break;
            case "s":
                SubstractionGame();
                break;
            case "m":
                MultiplicationGame();
                break;
            case "d":
                DivisionGame();
                break;
            case "q":
                Console.WriteLine("Thanks for playing. See you soon!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid input!");
                Environment.Exit(0);
                break;
        }

        string GetName()
        {
            Console.Write("Enter your name > ");
            string name = Console.ReadLine();
            return name;
        }

        static void Menu(string name, DateTime date)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Hello, {name}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself!\n");
            Console.WriteLine($@"What game do you want to play today? Choose from the options below:
    A - Addition
    S - Substraction
    M - Multiplication
    D - Division
    Q - Quit the program");
            Console.WriteLine("----------------------------------------------------");
        }

        void AdditionGame()
        {
            Console.WriteLine("You selected Addition");
            Random random = new Random();
            int firstNumber = random.Next(0, 9);
            int secondNumber = random.Next(0, 9);

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
        }

        void SubstractionGame()
        {
            Console.WriteLine("You selected Substraction");
        }

        void MultiplicationGame()
        {
            Console.WriteLine("You selected Multiplication");
        }

        void DivisionGame()
        {
            Console.WriteLine("You selected Division");
            Random random = new Random();

            int[] result = new int[2];
            do
            {
                result[0] = random.Next(1, 99);
                result[1] = random.Next(1, 99);
            } 
            while (result[0] % result[1] != 0);

            Console.WriteLine($"{result[0]} / {result[1]} = {result[0] / result[1]}");
        }
    }
}