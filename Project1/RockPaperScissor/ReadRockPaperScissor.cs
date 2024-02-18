using Microsoft.EntityFrameworkCore;
using Project1;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.RockPaperScissorRepository;


public class ReadRockPaperScissor
{
    private readonly ApplicationDbContext _dbContext;

    public ReadRockPaperScissor(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
   public void DisplayPreviousGames()
    {
        Console.WriteLine("===========================================================================");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t1. Se tidigare spel");
        Console.WriteLine("\t0. Huvudmenyn");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("===========================================================================");

        while (true)
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nTidigare spelresultat:");

                    var previousGame = _dbContext.RockPaperScissor.Where(r => r.Resultat != null); 
                        foreach (var rockPaperScissor in previousGame) 
                        {
                        Console.WriteLine("=======================================================================================================");
                        Console.WriteLine($"ID: {rockPaperScissor.RPSId}\nDatum: {rockPaperScissor.Datum}\nSpelare: {rockPaperScissor.SpelarensDrag}\nDatorn: {rockPaperScissor.DatornsDrag}\nResultat: {rockPaperScissor.Resultat}\nGenomsnitt vinst mot datorn (%): {rockPaperScissor.Genomsnitt}");
                        Console.WriteLine("=======================================================================================================");
                        }
                    Console.WriteLine("Tryck på O för att gå tillbaka till menyn");
                    break;
                    
                case "0":
                    Console.Clear();
                    var back = new AppChoice();
                    back.MenuChoice();
                    break;

                default:
                    Console.WriteLine("Fel inmatning! Testa igen");
                    break;
            }
        }
    }
}
    
