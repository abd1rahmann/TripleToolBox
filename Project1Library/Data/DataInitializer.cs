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

            DateTime currentDateTime = DateTime.Now;

            var newShape = new List<Shape>();

            newShape.Add(new Shape { ShapeForm = "Rektangel", Circumference = 50, Area = 150, Lenght = 15, Width = 10, Date = DateTime.Now, Valid = true});
            newShape.Add(new Shape { ShapeForm = "Parallellogram", Circumference = 60, Area = 150, Side = 15, Base = 10, Height = 15, Date = DateTime.Now, Valid = true });
            newShape.Add(new Shape { ShapeForm = "Triangel", Circumference = 24, Area = 24, Katet1 = 6, Katet2 = 8, Hypotenusan = 10, Base = 6, Height = 8, Date = DateTime.Now, Valid = true});
            newShape.Add(new Shape { ShapeForm = "Romb", Circumference = 50, Area = 150, Side = 15, Base = 15, Height = 10, Date = DateTime.Now, Valid = true });


            foreach (var shape in newShape)
            {
                dbContext.Shape.Add(shape);
            }

            dbContext.SaveChanges();
        }
    }
}
