using Microsoft.EntityFrameworkCore;
using Project1.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.RockPaperScissor
{
    public class RPSMenu
    {
        public void MenuChoice()
        {
            int run = 1;
            while (run == 1)
            {


                Console.WriteLine(@" 


                                                                                ");


                Console.WriteLine("===========================================================================");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t1. Räkna ut omkrets och area på en form");
                Console.WriteLine("\t2. Se form");
                Console.WriteLine("\t3. Uppdatera form");
                Console.WriteLine("\t4. Radera form");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("===========================================================================");

                var choice = Console.ReadLine();
                var options = new DbContextOptionsBuilder<ApplicationDbContext>();
                Console.Clear();

                options.UseSqlServer("Server=localhost;Database=Project1;Trusted_Connection=True;TrustServerCertificate=true;");
                using (var dbContext = new ApplicationDbContext(options.Options))
                {

                    switch (choice)
                    {
                        case "1":
                            var createForm = new CreateForm(dbContext);
                            createForm.CreateNewForm();
                            break;

                        case "2":
                            var readForm = new ReadForm(dbContext);
                            readForm.DisplayForm();
                            break;

                        case "3":
                            var updateForm = new UpdateForm(dbContext);
                            updateForm.Update();
                            break;

                        case "4":
                            var deleteForm = new DeleteForm(dbContext);
                            deleteForm.Delete();
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
