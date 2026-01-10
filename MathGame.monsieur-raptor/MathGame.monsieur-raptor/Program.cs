using MathGame.monsieur_raptor;

internal class Program
{
    private static void Main(string[] args)
    {
        var menu = new Menu();
        string name = Menu.GetName();

        var date = DateTime.Now;
        menu.showMenu(name, date);
    }
}