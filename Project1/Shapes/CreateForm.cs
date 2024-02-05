using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;
using Project1Library.Data;
using System.ComponentModel.DataAnnotations;




namespace Project1.Shapes
{
    public class CreateForm
    {

        private readonly ApplicationDbContext _dbContext;


        public CreateForm(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateNewForm()
        {
            var newShape = new Shape();

            Console.WriteLine("===========================================================================");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            Console.WriteLine("\t1. Rektangel");
            Console.WriteLine("\t2. Parallellogram");
            Console.WriteLine("\t3. Triangel");
            Console.WriteLine("\t4. Romb");
            Console.WriteLine("\t0. Tillbaka till huvudmenyn");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Välj vilken form du vill räkna area och omkrets på: \n");

            bool run = true;
            while (run)
            {
                int choice;
                
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
                {
                    Console.WriteLine("Inmatningen är ogiltig.");
                }

                switch (choice)
                {
                    case 1:
                        newShape.ShapeForm = "Rektangel";

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

                        newShape.Lenght = length;
                        newShape.Width = width;

                        decimal circumference = newShape.Circumference;
                        circumference = 2 * (length + width);

                        Console.WriteLine($"Omkrets: {circumference} cm");

                        decimal area = newShape.Area;
                        area = length * width;

                        newShape.Area = area;
                        newShape.Circumference = circumference;
                        Console.WriteLine($"Area: {area} cm");
                        newShape.Date = DateTime.Now;
                        newShape.Valid = true;

                        _dbContext.Add(newShape);
                        _dbContext.SaveChanges();
                        Console.WriteLine("Beräkningen är klar! Tryck på 0 för att gå tillbaka till menyn");
                        Console.ReadLine();

                        Console.Clear();
                        var choic = new ShapesMenu();
                        choic.MenuChoice();
                        break;
                    case 2:
                        newShape.ShapeForm = "Parallellogram";


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

                        newShape.Base = baseParalello;
                        newShape.Side = sideParalello1;
                        newShape.Side = sideParalello2;
                        newShape.Height = heightParalello;

                        decimal circumferenceParalello = newShape.Circumference;
                        circumferenceParalello = 2 * (sideParalello1 + sideParalello2);

                        Console.WriteLine($"Omkrets: {circumferenceParalello} cm");

                        decimal areaParalello = newShape.Area;
                        areaParalello = baseParalello * heightParalello;

                        Console.WriteLine($"Area: {areaParalello} cm");
                        newShape.Area = areaParalello;
                        newShape.Circumference = circumferenceParalello;
                        newShape.Valid = true;

                        _dbContext.Add(newShape);
                        _dbContext.SaveChanges();

                        Console.WriteLine("Beräkningen är klar! Tryck på 0 för att gå tillbaka till menyn");
                        Console.ReadLine();

                        Console.Clear();
                        var cho = new ShapesMenu();
                        cho.MenuChoice();

                        break;
                    case 3:
                        newShape.ShapeForm = "Triangel";

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


                        newShape.Katet2 = katet1;
                        newShape.Katet2 = katet2;
                        newShape.Hypotenusan = hypotenusan;
                        decimal circumferenceTriangle = newShape.Circumference;

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

                        newShape.Base = baseTriangle;
                        newShape.Height = heightTriangle;
                        decimal areaTriangle = newShape.Area;
                        newShape.Valid = true;


                        areaTriangle = (baseTriangle * heightTriangle) / 2;
                        Console.WriteLine($"Area: {areaTriangle} cm");

                        newShape.Area = areaTriangle;
                        newShape.Circumference = circumferenceTriangle;
                        Console.WriteLine("Beräkningen är klar! Tryyck på 0 för att gå tillbaka till menyn.");
                        Console.ReadLine();
                        _dbContext.Add(newShape);
                        _dbContext.SaveChanges();



                        Console.Clear();
                        var c = new ShapesMenu();
                        c.MenuChoice();

                        break;
                    case 4:
                        newShape.ShapeForm = "Romb";

                        Console.WriteLine("Ange sidan på romben: ");
                        decimal sideRomb = 0;
                        while (!decimal.TryParse(Console.ReadLine(), out sideRomb) || sideRomb <= 0)
                        {
                            Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                        }


                        newShape.Side = sideRomb;
                        decimal circumferenceRomb = newShape.Circumference;

                        circumferenceRomb = sideRomb * 4;

                        Console.WriteLine($"Omkrets: {circumferenceRomb}");

                        Console.WriteLine("Ange höjden på romben för att beräkna arean: ");
                        decimal heightRomb = 0;
                        while (!decimal.TryParse(Console.ReadLine(), out heightRomb) || heightRomb <= 0)
                        {
                            Console.WriteLine("Inmatningen är ogiltig. Ange ett positivt decimaltal.");
                        }

                        decimal areaRomb = newShape.Area;
                        areaRomb = sideRomb * heightRomb;

                        Console.WriteLine($"Area: {areaRomb}");

                        newShape.Area = areaRomb;
                        newShape.Circumference = circumferenceRomb;
                        newShape.Valid = true;

                        _dbContext.Add(newShape);
                        _dbContext.SaveChanges();

                        Console.WriteLine("Beräkningen är klar! Tryck på 0 för att gå tillbaka till menyn");
                        Console.ReadLine();

                        Console.Clear();
                        var a = new ShapesMenu();
                        a.MenuChoice();
                        break;

                    case 0:
                        Console.Clear();
                        var back = new ShapesMenu();
                        back.MenuChoice();
                        break;
                }
                _dbContext.Add(newShape);
            }
            
            
        }

    }

}

