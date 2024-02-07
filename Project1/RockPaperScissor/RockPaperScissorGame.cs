using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Project1Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.RockPaperScissors
{
    public class RockPaperScissorsGame
    {
        private readonly ApplicationDbContext _dbContext;

        public RockPaperScissorsGame(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            _dbContext.Database.Migrate();
        }

        public void Go()
        {
            while (true)
            {
                Console.WriteLine("\nVälj ditt drag (Sten, Sax, Påse) eller avsluta med 'exit': ");
                string playerChoice = Console.ReadLine().ToLower();

                if (playerChoice == "exit") {
                    Console.Clear();
                    break;
                }
                

                string computerChoice = GetComputerChoice();
                Console.WriteLine($"Datorns drag: {computerChoice}");

                string result = DetermineWinner(playerChoice, computerChoice);
                Console.WriteLine($"Resultat: {result}");

                UpdateStatistics(result);

                SaveGameResult(playerChoice, computerChoice, result);

                ShowStatistics();
            }
        }

        private string GetComputerChoice()
        {
            string[] choices = { "sten", "sax", "påse" };
            Random random = new Random();
            return choices[random.Next(choices.Length)];
        }

        private string DetermineWinner(string playerChoice, string computerChoice)
        {
            if (playerChoice == computerChoice) return "Oavgjort";
            else if ((playerChoice == "sten" && computerChoice == "sax") ||
                     (playerChoice == "sax" && computerChoice == "påse") ||
                     (playerChoice == "påse" && computerChoice == "sten"))
            {
                return "Vinst";
            }
            else
            {
                return "Förlust";
            }
        }

        private void UpdateStatistics(string result)
        {
            var stats = _dbContext.RockPaperScissor.FirstOrDefault() ?? new RockPaperScissor();

            switch (result)
            {
                case "Vinst":
                    stats.Vinst++;
                    break;
                case "Oavgjort":
                    stats.Oavgjort++;
                    break;
                case "Förlust":
                    stats.Förlust++;
                    break;
            }

            stats.Genomsnitt = CalculateAverage(stats);
            _dbContext.SaveChanges();
        }

        private int CalculateAverage(RockPaperScissor stats)
        {
            int totalGames = stats.Vinst + stats.Oavgjort + stats.Förlust;
            return totalGames == 0 ? 0 : (stats.Vinst * 100) / totalGames;
        }

        private void SaveGameResult(string playerChoice, string computerChoice, string result)
        {
            var gameResult = new RockPaperScissor
            {
                SpelarensDrag = playerChoice,
                DatornsDrag = computerChoice,
                Resultat = result,
                Datum = DateTime.Now
            };
            _dbContext.Add(gameResult);
            _dbContext.SaveChanges();
        }

        private void ShowStatistics()
        {
            var stats = _dbContext.RockPaperScissor.FirstOrDefault();
            Console.WriteLine("\nStatistik:");
            Console.WriteLine($"Vinster: {stats.Vinst} | Oavgjorda: {stats.Oavgjort} | Förluster: {stats.Förlust}");
            Console.WriteLine($"Genomsnittlig vinstprocent: {stats.Genomsnitt}%\n");
        }
    }
}