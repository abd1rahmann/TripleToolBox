using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.Shapes
{
    public class UpdateForm
    {
        private readonly ApplicationDbContext _dbContext;


        public UpdateForm(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update() 
        {
            Console.WriteLine("===========================================================================");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            Console.WriteLine("\t1. Uppdatera beräkning");
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


                            Console.WriteLine("\n=====================================================================================================================");
                            Console.WriteLine($"ID: {shape.ShapeId}|| Typ av form: {shape.ShapeForm}|| Längd: {shape.Lenght}|| Bredd: {shape.Width}|| Höjd: {shape.Height}");
                            Console.WriteLine("=======================================================================================================================\n");
                            Console.WriteLine("\nVälj ID på beräkningen du vill uppdatera");

                            int shapeId = 0;

                            while (!int.TryParse(Console.ReadLine(), out shapeId))
                            {
                                Console.WriteLine("Fel inmatning!");
                            }
                            var shapeIdToUpdate = _dbContext.Shape.FirstOrDefault(s => s.ShapeId == shapeId);
                            if (shapeIdToUpdate == null)
                            {
                                Console.WriteLine("Ogiltigt ID!");
                            }

                            Console.WriteLine("\nAnge formen: ");
                            var newShapeForm = Console.ReadLine();
                            Console.WriteLine("\nAnge längden: ");
                            var newLength = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("\nAnge bredd: ");
                            var newWidth = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("\nAnge höjd: ");
                            var newHeight = Convert.ToDecimal(Console.ReadLine());

                            shapeIdToUpdate.ShapeForm = newShapeForm;
                            shapeIdToUpdate.Lenght = newLength;
                            shapeIdToUpdate.Width = newWidth;
                            shapeIdToUpdate.Height = newHeight;

                        }

                        _dbContext.SaveChanges();
                        break;

                    case "0":
                        Console.Clear();
                        var back = new ShapesMenu();
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
