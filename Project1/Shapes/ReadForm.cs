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
                            if (shape.ShapeForm == "Rektangel")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n========================================================================================");
                                Console.WriteLine($"||Typ av form: {shape.ShapeForm}\n|| Area: {shape.Area}\n|| Omkrets: {shape.Circumference}\n|| Längd: {shape.Lenght}\n|| Bredd: {shape.Width}\n|| Datum: {shape.Date}");
                                Console.WriteLine("==========================================================================================\n");
                                Console.ResetColor();
                            }

                            if (shape.ShapeForm == "Parallellogram")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n==========================================================================================");
                                Console.WriteLine($"||Typ av form: {shape.ShapeForm}\n|| Area: {shape.Area}\n|| Omkrets: {shape.Circumference}\n|| Sida: {shape.Side}\n|| Bas: {shape.Base}\n|| Höjd: {shape.Height}\n|| Datum: {shape.Date}");
                                Console.WriteLine("===========================================================================================\n");
                                Console.ResetColor();

                            }

                            if (shape.ShapeForm == "Triangel")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n==========================================================================================");
                                Console.WriteLine($"||Typ av form: {shape.ShapeForm}\n|| Area: {shape.Area}\n|| Omkrets: {shape.Circumference}\n|| Första kateten: {shape.Katet1}\n|| Andra kateten: {shape.Katet2}\n|| Hypotenusan: {shape.Hypotenusan}\n|| Bas: {shape.Base}\n|| Höjd: {shape.Height}\n|| Datum: {shape.Date}");
                                Console.WriteLine("===========================================================================================\n");
                                Console.ResetColor();

                            }

                            if (shape.ShapeForm == "Romb")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("\n============================================================================================");
                                Console.WriteLine($"||Typ av form: {shape.ShapeForm}\n|| Area: {shape.Area}\n|| Omkrets: {shape.Circumference}\n|| Sida: {shape.Side}\n|| Bas: {shape.Base}\n|| Höjd: {shape.Height}\n|| Datum: {shape.Date}");
                                Console.WriteLine("=============================================================================================\n");
                                Console.ResetColor();

                            }

                            Console.WriteLine("Tryck på 0 för att gå tillbaka till menyn");

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
