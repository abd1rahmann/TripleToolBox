using Project1;
using static Project1Library.Data.ApplicationDBContext;

public class ReadRockPaperScissor
{
    private readonly ApplicationDbContext _dbContext;

    public ReadRockPaperScissor(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void DisplayPreviousGames()
    {
        while (true) 
        {
            string choice = Console.ReadLine();
            switch (choice) 
            {
                case "1":
                    var previousGames = _dbContext.RockPaperScissor.ToList();
                    if (previousGames.Count == 0)
                    {
                        Console.WriteLine("Inga tidigare spel att visa.");
                        return;
                    }

                    Console.WriteLine("Tidigare spelresultat:");
                    foreach (var game in previousGames)
                    {
                        Console.WriteLine($"Datum: {game.Datum}, Spelare: {game.SpelarensDrag}, Datorn: {game.DatornsDrag}, Resultat: {game.Resultat}");
                    }
                    break;

                    case "0":
                    Console.Clear();
                    var back = new AppChoice();
                    back.MenuChoice();
                    break;
            }
        }
        
    }
}