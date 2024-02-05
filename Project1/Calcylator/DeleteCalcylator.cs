using Project1.Shapes;
using Project1Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.Calcylator
{
    public class DeleteCalcylator
    {
        private readonly ApplicationDbContext _dbContext;


        public DeleteCalcylator(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete() 
        {
            var shapeDelete = new Shape();

            Console.WriteLine("===========================================================================");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            Console.WriteLine("\t1. Se alla sparade beräkningar");
            Console.WriteLine("\t0. Huvudmenyn");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            Console.WriteLine("===========================================================================");
            bool run = true;
            while (run)
            {
                string choice = Console.ReadLine();
                switch (choice)

                {
                    case "1":

                        foreach (var calc in _dbContext.Calcylate)
                        {


                            Console.WriteLine("\n==================================================================================================");
                            Console.WriteLine($"ID: {calc.CalcylateId}|| {calc.Tal1} {calc.Operator} {calc.Tal2} = {calc.Resultat}");
                            Console.WriteLine("====================================================================================================\n");


                        }

                        Console.WriteLine("Välj Id på den gäst som du vill ta inaktivera");
                        int calcId = 0;
                        bool go = false;
                        while (go)
                        {
                            while (!int.TryParse(Console.ReadLine(), out calcId) || calcId <= 0)
                            {
                                Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt heltal.");
                            }
                            var calcToDelete = _dbContext.Calcylate.FirstOrDefault(c => c.CalcylateId == calcId);
                            if (calcToDelete != null)
                            {
                                calcToDelete.Valid = false;
                                _dbContext.SaveChanges();
                                Console.WriteLine("Beräkningen är borta! Tryck på 0 för att gå tillbaka till menyn");
                                go = true;

                            }
                            else
                            {
                                Console.WriteLine("Beräkningen med det angivna ID:t kunde inte hittas. Försök igen.");
                            }
                            break;
                        }

                        break;

                    case "0":
                        Console.Clear();
                        var back = new CalcylationMenu();
                        back.MenuChoice();
                        break;

                    default:
                        Console.WriteLine("Fel inmatning! Tryck på 0 för att gå tillbaka till menyn");
                        break;
                }
            }
        }
    }
}
