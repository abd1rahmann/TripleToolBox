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

                            if (shape.ShapeForm == "Rektangel")
                            {
                                Console.WriteLine("\n=====================================================================================================================");
                                Console.WriteLine($"ID: {shape.ShapeId}|| Typ av form: {shape.ShapeForm}|| Längd: {shape.Lenght}|| Bredd: {shape.Width}");
                                Console.WriteLine("=======================================================================================================================\n");
                            }

                            if (shape.ShapeForm == "Parallellogram")
                            {
                                Console.WriteLine("\n=====================================================================================================================");
                                Console.WriteLine($"ID: {shape.ShapeId}|| Typ av form: {shape.ShapeForm}|| Sida: {shape.Side}|| Bas: {shape.Base}|| Höjd: {shape.Height}");
                                Console.WriteLine("=======================================================================================================================\n");
                            }
                            if (shape.ShapeForm == "Triangel")
                            {
                                Console.WriteLine("\n=====================================================================================================================");
                                Console.WriteLine($"ID: {shape.ShapeId}|| Typ av form: {shape.ShapeForm}|| Katet 1: {shape.Katet1}|| Katet 2: {shape.Katet2}|| Hypotenusan: {shape.Hypotenusan}|| Bas: {shape.Base}|| Höjd: {shape.Height}");
                                Console.WriteLine("=======================================================================================================================\n");
                            }
                            if (shape.ShapeForm == "Romb")
                            {
                                Console.WriteLine("\n=====================================================================================================================");
                                Console.WriteLine($"ID: {shape.ShapeId}|| Typ av form: {shape.ShapeForm}|| Sida: {shape.Side}|| Bas: {shape.Base}|| Höjd: {shape.Height}");
                                Console.WriteLine("=======================================================================================================================\n");
                            }


                        }
                        Console.WriteLine("\nVälj ID på beräkningen du vill uppdatera");

                        int shapeId = 0;

                        while (!int.TryParse(Console.ReadLine(), out shapeId) || shapeId <= 0)
                        {
                            Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt heltal.");
                        }
                        var shapeIdToUpdate = _dbContext.Shape.FirstOrDefault(s => s.ShapeId == shapeId);
                        if (shapeIdToUpdate == null)
                        {
                            Console.WriteLine("Ogiltigt ID!");
                        }
                        else
                        {
                            if (shapeIdToUpdate.ShapeForm == "Rektangel")
                            {
                                Console.WriteLine("Ange längden på rektangeln: cm");
                                decimal length = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out length) || length <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }
                                Console.WriteLine("Ange bredden på rektangeln: cm");
                                decimal width = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out width) || width <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }

                                shapeIdToUpdate.Lenght = length;
                                shapeIdToUpdate.Width = width;

                                decimal circumference = shapeIdToUpdate.Circumference;
                                circumference = 2 * (length + width);

                                Console.WriteLine($"Omkrets: {circumference} cm");

                                decimal area = shapeIdToUpdate.Area;
                                area = length * width;

                                shapeIdToUpdate.Area = area;
                                shapeIdToUpdate.Circumference = circumference;
                                Console.WriteLine($"Area: {area} cm");

                                shapeIdToUpdate.Date = DateTime.Now;

                                _dbContext.SaveChanges();
                                Console.WriteLine("Beräkningen är klar! Klicka enter för att gå tillbaka till menyn.");
                                Console.ReadLine();

                                Console.Clear();
                                var choic = new AppChoice();
                                choic.MenuChoice();
                            }

                           else if (shapeIdToUpdate.ShapeForm == "Parallellogram")
                            {
                                Console.WriteLine("Ange bredden på parallellogrammet: cm");
                                decimal sideParalello1 = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out sideParalello1) || sideParalello1 <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }
                                Console.WriteLine("Ange längden på parallellogrammet: cm");
                                decimal sideParalello2 = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out sideParalello2) || sideParalello2 <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }
                                Console.WriteLine("Ange höjden på parallellogrammet: cm");
                                decimal heightParalello = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out heightParalello) || heightParalello <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }
                                Console.WriteLine("Ange basen på parallellogrammet: cm");
                                decimal baseParalello = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out baseParalello) || baseParalello <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }

                                shapeIdToUpdate.Base = baseParalello;
                                shapeIdToUpdate.Side = sideParalello1;
                                shapeIdToUpdate.Side = sideParalello2;
                                shapeIdToUpdate.Height = heightParalello;

                                decimal circumferenceParalello = shapeIdToUpdate.Circumference;
                                circumferenceParalello = 2 * (sideParalello1 + sideParalello2);

                                shapeIdToUpdate.Circumference = circumferenceParalello;
                                Console.WriteLine($"Omkrets: {circumferenceParalello} cm");

                                decimal areaParalello = shapeIdToUpdate.Area;
                                areaParalello = baseParalello * heightParalello;

                                shapeIdToUpdate.Area = areaParalello;
                                Console.WriteLine($"Area: {areaParalello} cm");

                                shapeIdToUpdate.Date = DateTime.Now;

                                _dbContext.SaveChanges();

                                Console.WriteLine("Beräkningen är klar! Klicka enter för att gå tillbaka till menyn.");
                                Console.ReadLine();

                                Console.Clear();
                                var cho = new AppChoice();
                                cho.MenuChoice();
                            }

                           else if (shapeIdToUpdate.ShapeForm == "Triangel")
                            {
                                Console.WriteLine("Ange första kateten på triangeln: cm");
                                decimal katet1 = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out katet1) || katet1 <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }
                                Console.WriteLine("Ange andra kateten på triangeln: cm");
                                decimal katet2 = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out katet2) || katet2 <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }
                                Console.WriteLine("Ange hypotenusan på triangeln: cm");
                                decimal hypotenusan = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out hypotenusan) || hypotenusan <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }


                                shapeIdToUpdate.Katet2 = katet1;
                                shapeIdToUpdate.Katet2 = katet2;
                                shapeIdToUpdate.Hypotenusan = hypotenusan;
                                decimal circumferenceTriangle = shapeIdToUpdate.Circumference;

                                circumferenceTriangle = katet1 + katet2 + hypotenusan;

                                Console.WriteLine($"Omkrets: {circumferenceTriangle} cm");

                                Console.WriteLine("Ange basen: cm");
                                decimal baseTriangle = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out baseTriangle) || baseTriangle <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }
                                Console.WriteLine("Ange höjden: cm");
                                decimal heightTriangle = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out heightTriangle) || heightTriangle <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }

                                shapeIdToUpdate.Base = baseTriangle;
                                shapeIdToUpdate.Height = heightTriangle;
                                decimal areaTriangle = shapeIdToUpdate.Area;

                                areaTriangle = (baseTriangle * heightTriangle) / 2;
                                Console.WriteLine($"Area: {areaTriangle} cm");

                                shapeIdToUpdate.Area = areaTriangle;
                                shapeIdToUpdate.Circumference = circumferenceTriangle;

                                shapeIdToUpdate.Date = DateTime.Now;

                                Console.WriteLine("Beräkningen är klar! Klicka enter för att gå tillbaka till menyn.");
                                Console.ReadLine();


                                _dbContext.SaveChanges();
                            }

                           else if (shapeIdToUpdate.ShapeForm == "Romb")
                            {
                                Console.WriteLine("Ange sidan på romben: ");
                                decimal sideRomb = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out sideRomb) || sideRomb <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }


                                shapeIdToUpdate.Side = sideRomb;
                                decimal circumferenceRomb = shapeIdToUpdate.Circumference;

                                circumferenceRomb = sideRomb * 4;

                                Console.WriteLine($"Omkrets: {circumferenceRomb}");

                                Console.WriteLine("Ange höjden på romben för att beräkna arean: ");
                                decimal heightRomb = 0;
                                while (!decimal.TryParse(Console.ReadLine(), out heightRomb) || heightRomb <= 0)
                                {
                                    Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                                }

                                decimal areaRomb = shapeIdToUpdate.Area;
                                areaRomb = sideRomb * heightRomb;

                                Console.WriteLine($"Area: {areaRomb}");

                                shapeIdToUpdate.Area = areaRomb;
                                shapeIdToUpdate.Circumference = circumferenceRomb;

                                shapeIdToUpdate.Date = DateTime.Now;

                                _dbContext.SaveChanges();

                                Console.WriteLine("Beräkningen är klar! Klicka enter för att gå tillbaka till menyn.");
                                Console.ReadLine();

                                Console.Clear();
                                var a = new AppChoice();
                                a.MenuChoice();
                            }
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
