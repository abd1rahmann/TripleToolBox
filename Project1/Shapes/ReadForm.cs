using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.Shapes
{
    public class ReadForm
    {
        private readonly ApplicationDbContext _dbContext;


        public ReadForm(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DisplayForm()
        {
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
                            Console.WriteLine($"Typ av form: {shape.ShapeForm}|| Längd: {shape.Lenght}|| Bredd: {shape.Width}|| Höjd: {shape.Height}");
                            Console.WriteLine("====================================================================================================\n");


                        }
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
