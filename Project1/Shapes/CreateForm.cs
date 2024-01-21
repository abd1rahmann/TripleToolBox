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

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Ange längden på rektangeln: cm");
                    decimal lenght = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ange bredden på rektangeln: cm");
                    decimal width = Convert.ToDecimal(Console.ReadLine());

                    newShape.ShapeForm = "Rektangel";
                    newShape.Lenght = lenght;
                    newShape.Width = width;

                    decimal circumference = newShape.Circumference;
                    circumference = 2 * (lenght + width);

                    Console.WriteLine($"Omkrets: {circumference} cm");

                    decimal area = newShape.Area;
                    area = lenght * width;

                    newShape.Area = area;
                    newShape.Circumference = circumference;
                    Console.WriteLine($"Area: {area} cm");
                    _dbContext.Add(newShape);
                    _dbContext.SaveChanges();
                    Console.WriteLine("Beräkningen är klar!");
                    Console.ReadLine();

                    Console.Clear();
                    var choic = new AppChoice();
                    choic.MenuChoice();
                    break;
                case "2":

                    Console.WriteLine("Ange bredden på parallellogrammet: cm");
                    decimal widthParalello = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ange längden på parallellogrammet: cm");
                    decimal lengthParalello = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ange höjden på parallellogrammet: cm");
                    decimal heightParalello = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ange basen på parallellogrammet: cm");
                    decimal baseParalello = Convert.ToDecimal(Console.ReadLine());



                    newShape.ShapeForm = "Parallellogram";

                    newShape.Base = baseParalello;
                    newShape.Lenght = lengthParalello;
                    newShape.Width = widthParalello;
                    newShape.Height = heightParalello;




                    decimal circumferenceParalello = newShape.Circumference;
                    circumferenceParalello = 2 * (widthParalello + lengthParalello);

                    Console.WriteLine($"Omkrets: {circumferenceParalello} cm");

                    decimal areaParalello = newShape.Area;
                    areaParalello = baseParalello * heightParalello;

                    Console.WriteLine($"Area: {areaParalello} cm");
                    newShape.Area = areaParalello;
                    newShape.Circumference = circumferenceParalello;

                    _dbContext.Add(newShape);
                    _dbContext.SaveChanges();
                    
                    Console.WriteLine("Beräkningen är klar!");
                    Console.ReadLine();

                    Console.Clear();
                    var cho = new AppChoice();
                    cho.MenuChoice();

                    break;
                case "3":
                    Console.WriteLine("Ange första kateten på triangeln: cm");
                    decimal katet1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ange andra kateten på triangeln: cm");
                    decimal katet2 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ange hypotenusan på triangeln: cm");
                    decimal hypotenusan = Convert.ToDecimal(Console.ReadLine());

                    newShape.ShapeForm = "Triangel";

                    newShape.Katet2 = katet1;
                    newShape.Katet2 = katet2;
                    newShape.Hypotenusan = hypotenusan;
                    decimal circumferenceTriangle = newShape.Circumference;

                    circumferenceTriangle = katet1 + katet2 + hypotenusan;

                    Console.WriteLine($"Omkrets: {circumferenceTriangle} cm");

                    Console.WriteLine("Ange basen: cm");
                    decimal baseTriangle = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ange höjden: cm");
                    decimal heightTriangle = Convert.ToDecimal(Console.ReadLine());

                    newShape.Base = baseTriangle;
                    newShape.Height = heightTriangle;
                    decimal areaTriangle = newShape.Area;

                    areaTriangle = (baseTriangle * heightTriangle)/2;
                    Console.WriteLine($"Area: {areaTriangle} cm");

                    newShape.Area = areaTriangle;
                    newShape.Circumference = circumferenceTriangle;
                    Console.WriteLine("Beräkningen är klar!");
                    Console.ReadLine();
                    _dbContext.Add(newShape);

                    

                    Console.Clear();
                    var c = new AppChoice();
                    c.MenuChoice();

                    break;
                case "4":

                    Console.WriteLine("Ange sidan på romben: ");
                    decimal lenghtRomb = Convert.ToDecimal(Console.ReadLine());

                    newShape.ShapeForm = "Romb";
                    decimal circumferenceRomb = newShape.Circumference;
                    newShape.Lenght = lenghtRomb;

                    circumferenceRomb = lenghtRomb * 4;

                    Console.WriteLine($"Omkrets: {circumferenceRomb}");

                    Console.WriteLine("Ange höjden på romben för att beräkna arean: ");
                    decimal heightRomb = Convert.ToDecimal(Console.ReadLine());

                    decimal areaRomb = newShape.Area;
                    areaRomb = lenghtRomb * heightRomb;

                    Console.WriteLine($"Area: {areaRomb}");

                    newShape.Area = areaRomb;
                    newShape.Circumference = circumferenceRomb;

                    _dbContext.Add(newShape);
                    _dbContext.SaveChanges();

                    Console.WriteLine("Beräkningen är klar!");
                    Console.ReadLine();

                    Console.Clear();
                    var a = new AppChoice();
                    a.MenuChoice();
                    break;

                    case "0":
                    Console.Clear();
                    var back = new ShapesMenu();
                    back.MenuChoice();
                    break;
            }_dbContext.Add(newShape);
            
        }

    }

}

