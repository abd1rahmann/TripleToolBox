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

                        foreach (var shape in _dbContext.Shape)
                        {


                            Console.WriteLine("\n==================================================================================================");
                            Console.WriteLine($"ID: {shape.ShapeId}|| Typ av form: {shape.ShapeForm}|| Längd: {shape.Lenght}|| Bredd: {shape.Width}|| Höjd: {shape.Height}");
                            Console.WriteLine("====================================================================================================\n");


                        }

                        Console.WriteLine("Välj Id på den gäst som du vill ta inaktivera");
                        var shapeIdToDelete = Convert.ToInt32(Console.ReadLine());
                        var shapeToDelete = _dbContext.Shape.First(s => s.ShapeId == shapeIdToDelete);

                        Console.WriteLine("Formen är borta!");
                        Console.ReadLine();
                        _dbContext.Remove(shapeDelete);
                        _dbContext.SaveChanges();
                        break;

                    case "0":
                        Console.Clear();
                        var back = new ShapesMenu();
                        back.MenuChoice();
                        break;

                    default:
                        Console.WriteLine("Fel inmatning!");
                        break;
                }
            }
        }
    }
}
