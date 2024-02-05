using Microsoft.EntityFrameworkCore;
using Project1Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.Shapes
{
    public class DeleteForm
    {
        private readonly ApplicationDbContext _dbContext;


        public DeleteForm(ApplicationDbContext dbContext)
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
                        var validShape = _dbContext.Shape.Where(s => s.Valid == true);
                        foreach (var shape in validShape)
                        {
                            Console.WriteLine("\n==================================================================================================");
                            Console.WriteLine($"ID: {shape.ShapeId}|| Typ av form: {shape.ShapeForm}||");
                            Console.WriteLine("====================================================================================================\n");
                        }

                        Console.WriteLine("Välj Id på den formen som du vill ta inaktivera");
                        int shapeId = 0;
                        bool go = false;
                        while (go)
                        {
                            while (!int.TryParse(Console.ReadLine(), out shapeId) || shapeId <= 0)
                            {
                                Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt heltal.");
                            }
                            var shapeToDelete = _dbContext.Shape.FirstOrDefault(s => s.ShapeId == shapeId);
                            if (shapeToDelete != null)
                            {
                                shapeToDelete.Valid = false;
                                _dbContext.SaveChanges();
                                Console.WriteLine("Formen är borta! Tryck på 0 för att gå tillbaka till menyn");
                                go = true;
                                
                            }
                            else
                            {
                                Console.WriteLine("Formen med det angivna ID:t kunde inte hittas. Försök igen.");
                            }
                            break;
                        }

                        break;

                    case "0":
                        Console.Clear();
                        var back = new ShapesMenu();
                        back.MenuChoice();
                        break;

                    default:
                        Console.WriteLine("Fel inmatning! Tryck på 0 för att gå tillbaka till huvudmenyn");
                        break;
                }
            }
        }
    }
}
