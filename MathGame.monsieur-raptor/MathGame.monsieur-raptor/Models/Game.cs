namespace MathGame.monsieur_raptor.Models;

internal class Game
{
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameType Type { get; set; }
}

internal enum GameType
{
    Addition,
    Substraction,
    Multiplication,
    Division
}
