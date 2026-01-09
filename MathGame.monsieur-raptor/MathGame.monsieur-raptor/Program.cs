internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your name > ");
        string name = Console.ReadLine();
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

        void AdditionGame()
        {
            Console.WriteLine("You selected Addition");
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
    }
}