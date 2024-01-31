using Project1.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.Calcylator
{
    public class ReadCalcylator
    {
        private readonly ApplicationDbContext _dbContext;


        public ReadCalcylator(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Read() 
        {
            Console.WriteLine("===========================================================================");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            Console.WriteLine("\t1. Se alla uträkningar");
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

                        foreach (var calcylate in _dbContext.Calcylate)
                        {


                            Console.WriteLine("\n==================================================================================================");
                            Console.WriteLine($"ID: {calcylate.CalcylateId}|| {calcylate.Tal1} {calcylate.Operator} {calcylate.Tal2}");
                            Console.WriteLine("====================================================================================================\n");


                        }
                        break;

                    case "0":
                        Console.Clear();
                        var back = new CalcylationMenu();
                        back.MenuChoice();
                        break;

                    default:
                        Console.WriteLine("Fel inmatning! Välj ett av alternativen eller tryck på 0 för att gå tillbaka till huvudmenyn");

                        break;
                }


            }
        }
    }
}
