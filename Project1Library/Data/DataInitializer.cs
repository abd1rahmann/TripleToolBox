using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1Library.Data
{
    public class DataInitializer
    {
        public void MigrateAndSeed(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            LoadData(dbContext);
        }
        public void LoadData(ApplicationDbContext dbContext)
        {
            if (dbContext.Shape.Any()) return;

            var newShape = new List<Shape>
            {
                new Shape { ShapeForm = "Rektangel", Circumference = 50, Area = 150, Lenght = 15, Width = 10 }
            };



            foreach (var shape in newShape)
            {
                dbContext.Shape.Add(shape);
            }

            DateTime currentDateTime = DateTime.Now;

            var newCalc = new List<Calcylate>
            {
                new Calcylate { Tal1 = 10, Operator = "+", Tal2 = 5, Resultat = 15, Datum = currentDateTime }
            };


            foreach (var newcalc in newCalc)
            {
                dbContext.Calcylate.Add(newcalc);
            }

            dbContext.SaveChanges();
        }
    }
}
