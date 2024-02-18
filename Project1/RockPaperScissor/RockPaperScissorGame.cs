using System;
using System.Linq;
using Project1Library.Data;
using Microsoft.EntityFrameworkCore;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.RockPaperScissorRepository
{
    public class RockPaperScissorGame
    {
        private readonly ApplicationDbContext _dbContext;

        public RockPaperScissorGame(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void PlayGame()
        {
            Console.WriteLine(@"
 ___            _      ___                      _    ___       _                   
| . \ ___  ___ | |__  | . \ ___  ___  ___  _ _ < >  / __> ___ <_> ___ ___ ___  _ _ 
|   // . \/ | '| / / _|  _/<_> || . \/ ._>| '_>/.\/ \__ \/ | '| |<_-<<_-</ . \| '_>
|_\_\\___/\_|_.|_\_\|/|_|  <___||  _/\___.|_|  \_/\ <___/\_|_.|_|/__//__/\___/|_|  
                                        |_|                                                
 

                            ");

            Console.WriteLine("\n1. Spela\n2. Se spelstatistik\n0. Huvudmenyn");

            while (true)
            {
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        PlaySingleGame();
                        break;

                    case "2":

                        Console.Clear();
                        var display = new ReadRockPaperScissor(_dbContext);
                        display.DisplayPreviousGames();
                        break;

                    case "0":
                        Console.Clear();
                        var menu = new AppChoice();
                        menu.MenuChoice();
                        return;

                    default:
                        Console.WriteLine("Fel inmatning! Välj ett av alternativen");
                        break;
                }
            }
        }

        private void PlaySingleGame()
        {
            var rps = new RockPaperScissor();

            Console.WriteLine("\nVälj ditt drag!\n1. Sten\n2. Sax\n3. Påse");
            int playerChoice = 0;

            while (!int.TryParse(Console.ReadLine(), out playerChoice) || playerChoice < 1 || playerChoice > 3)
            {
                Console.WriteLine("\nFel inmatning! Ange en siffra mellan 1 och 3.");
            }

            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            string result = DetermineWinner(playerChoice, computerChoice);

            SaveResult(playerChoice, computerChoice, result);

            Console.WriteLine($"\nDitt val: {GetChoiceName(playerChoice)} || Datorns val: {GetChoiceName(computerChoice)}");
            Console.WriteLine($"\nResultat: {result}");
            Console.WriteLine("\nKör igen! Tryck 1 för att spela om eller tryck på 0 för att gå tillbaka till menyn");
        }

        private string DetermineWinner(int playerChoice, int computerChoice)
        {
            if (playerChoice == computerChoice)
            {
                return "Oavgjort";
            }
            else if ((playerChoice == 1 && computerChoice == 3) ||
                     (playerChoice == 2 && computerChoice == 1) ||
                     (playerChoice == 3 && computerChoice == 2))
            {
                return "Vinst";
            }
            else
            {
                return "Förlust";
            }
        }

        private string GetChoiceName(int choice)
        {
            return choice switch
            {
                1 => "Sten",
                2 => "Sax",
                3 => "Påse",
                _ => "Okänt val"
            };
        }

        private void SaveResult(int playerChoice, int computerChoice, string result)
        {
            var gameResult = new RockPaperScissor
            {
                Vinst = result == "Vinst" ? 1 : 0,
                Förlust = result == "Förlust" ? 1 : 0,
                Oavgjort = result == "Oavgjort" ? 1 : 0,
                Genomsnitt = CalculateAverage(),
                Datum = DateTime.Now,
                SpelarensDrag = GetChoiceName(playerChoice),
                DatornsDrag = GetChoiceName(computerChoice),
                Resultat = result
            };

            _dbContext.RockPaperScissor.Add(gameResult);
            _dbContext.SaveChanges();
        }

        private decimal  CalculateAverage()
        {
            decimal totalWins = _dbContext.RockPaperScissor.Sum(r => r.Vinst);
            decimal totalGames = _dbContext.RockPaperScissor.Count();

            if (totalGames == 0)
            {
                return 0;
            }

            decimal winPercentage = totalWins / totalGames * 100;

            return Math.Round(winPercentage, 2);
        }
    }
}
