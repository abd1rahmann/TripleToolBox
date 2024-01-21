using Project1.Shapes;
using Project1Library.Data;
using System;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new Application();
            app.Run();

            using (var dbContext = new ApplicationDbContext())
            {
                var choose = new AppChoice();
                choose.MenuChoice();
            }
        }
    }
}
