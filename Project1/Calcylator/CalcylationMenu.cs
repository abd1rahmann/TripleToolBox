using Microsoft.EntityFrameworkCore;
using Project1.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.Calcylator
{
    public class CalcylationMenu
    {
        public void MenuChoice()
        {
            int run = 1;
            while (run == 1)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
   __  ____      _     _  _ __                     
  /  |/  (_)__  (_)___(_)(_) /__ ___  ___ ________ 
 / /|_/ / / _ \/ / __/ _ `/  '_// _ \/ _ `/ __/ -_)
/_/  /_/_/_//_/_/_/  \_,_/_/\_\/_//_/\_,_/_/  \__/ 
                                                   
");Console.ResetColor();


                Console.WriteLine("===========================================================================");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t1. ");
                Console.WriteLine("\t2. *");
                Console.WriteLine("\t3. /");
                Console.WriteLine("\t4. √");
                Console.WriteLine("\t5. %");
                Console.WriteLine("\t0. Huvudmenyn");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("===========================================================================");

                var choice = Console.ReadLine();
                var options = new DbContextOptionsBuilder<ApplicationDbContext>();

                options.UseSqlServer("Server=localhost;Database=Project1;Trusted_Connection=True;TrustServerCertificate=true;");
                using (var dbContext = new ApplicationDbContext(options.Options))
                {

                    switch (choice)
                    {
                        case "1":
                            var create = new CreateCalcylator(dbContext);
                            create.Create();
                            break;

                        case "2":
                            var read = new ReadCalcylator(dbContext);
                            read.Read();
                            break;

                        case "3":
                            var update = new UpdateCalcylator(dbContext);
                            update.Update();
                            break;

                        case "4":
                            var delete = new DeleteCalcylator(dbContext);
                            delete.Delete();
                            break;

                        case "0":
                            var back = new AppChoice();
                            back.MenuChoice();
                            break;

                        default:
                            Console.WriteLine("\nFel inmatning! Vänligen välj ett av alternativen.\n");
                            break;

                    }
                }


            }

        }
    }
}
