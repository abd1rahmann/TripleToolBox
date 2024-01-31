using Microsoft.EntityFrameworkCore;
using Project1.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.RockPaperScissor
{
    public class RockPaperScissorsGame
    {
        private readonly ApplicationDbContext _dbContext;
        private int userWins = 0;
        private int userLosses = 0;
        private int draws = 0;
        private int totalGames = 0;

        public RockPaperScissorsGame(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void PlayGame()
        {
            Console.WriteLine("Välkommen till Sten, Sax, Påse!");

            while (true)
            {
                Console.WriteLine("Välj ditt drag (Sten, Sax, Påse) eller tryck '0' för att avsluta:");
                string userChoice = Console.ReadLine();

                if (userChoice == "0")
                {
                    Console.Clear();
                    break; // Exit the game
                }

                string computerChoice = GetComputerChoice();

                Console.WriteLine($"Ditt drag: {userChoice}");
                Console.WriteLine($"Datorns drag: {computerChoice}");

                string result = DetermineWinner(userChoice, computerChoice);

                Console.WriteLine($"Resultat: {result}");

                // Save game result to the database
                SaveGameResult(userChoice, computerChoice, result);

                // Update statistics
                UpdateStatistics(result);
            }

            // Display statistics
            Console.WriteLine($"Antal vinster: {userWins}");
            Console.WriteLine($"Antal förluster: {userLosses}");
            Console.WriteLine($"Antal oavgjorda: {draws}");
            Console.WriteLine($"Genomsnitt av vinster: {CalculateAverageWinPercentage()}%");

            // Display list of previous games
            DisplayPreviousGames();
        }

        private string GetComputerChoice()
        {
            Random random = new Random();
            int randomNumber = random.Next(3); // Generates a random number between 0 and 2

            switch (randomNumber)
            {
                case 0:
                    return "Sten";
                case 1:
                    return "Sax";
                case 2:
                    return "Påse";
                default:
                    throw new InvalidOperationException("Unexpected random number.");
            }
        }

        private string DetermineWinner(string userChoice, string computerChoice)
        {
            // Logic to determine the winner of the game
            // ...

            // For demonstration purposes, let's assume the user always wins
            return "Vinst";
        }

        private void SaveGameResult(string userChoice, string computerChoice, string result)
        {
            var gameResult = new RockPaperScissorsResult
            {
                UserChoice = userChoice,
                ComputerChoice = computerChoice,
                Result = result,
                Datum = DateTime.Now
            };

            _dbContext.RockPaperScissorsResults.Add(gameResult);
            _dbContext.SaveChanges();
        }

        private void UpdateStatistics(string result)
        {
            switch (result)
            {
                case "Vinst":
                    userWins++;
                    break;
                case "Förlust":
                    userLosses++;
                    break;
                case "Oavgjort":
                    draws++;
                    break;
                default:
                    break;
            }

            totalGames++;
        }

        private double CalculateAverageWinPercentage()
        {
            if (totalGames == 0)
            {
                return 0.0;
            }

            return ((double)userWins / totalGames) * 100;
        }

        private void DisplayPreviousGames()
        {
            var previousGames = _dbContext.RockPaperScissor.ToList();

            Console.WriteLine("\nLista över tidigare spel:");

            foreach (var game in previousGames)
            {
                Console.WriteLine($"Datum: {game.Datum}, Spelare: {game.UserChoice}, Datorn: {game.ComputerChoice}, Resultat: {game.Resultat}");
            }
        }
    }
}
}
