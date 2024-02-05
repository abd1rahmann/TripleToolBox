using Microsoft.EntityFrameworkCore;
using Project1.Calcylator;
using Project1.RockPaperScissors;

//using Project1.RockPaperScissor;
using Project1.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1
{
    public class AppChoice
    {
        public void MenuChoice()
        {
            int run = 1;
            while (run == 1)
            {


                Console.WriteLine(@"
 _     ___  _                                                                              
/ |   / __>| |_  ___  ___  ___  ___                                                        
| | _ \__ \| . |<_> || . \/ ._><_-<                                                        
|_|<_><___/|_|_|<___||  _/\___./__/                                                        
                     |_|                                                                   
 ___     __ __  _       _            _                                                     
<_  >   |  \  \<_>._ _ <_> _ _ <>_<>| |__._ _  ___  _ _  ___                               
 / /  _ |     || || ' || || '_>`_> || / /| ' |<_> || '_>/ ._>                              
<___><_>|_|_|_||_||_|_||_||_|  <___||_\_\|_|_|<___||_|  \___.                              
                                                                                           
 ____    ___            _      ___                      _    ___       _                   
<__ /   | . \ ___  ___ | |__  | . \ ___  ___  ___  _ _ < >  / __> ___ <_> ___ ___ ___  _ _ 
 <_ \ _ |   // . \/ | '| / / _|  _/<_> || . \/ ._>| '_>/.\/ \__ \/ | '| |<_-<<_-</ . \| '_>
<___/<_>|_\_\\___/\_|_.|_\_\|/|_|  <___||  _/\___.|_|  \_/\ <___/\_|_.|_|/__//__/\___/|_|  
                                        |_|                                                
 

                            ");


                Console.WriteLine("===========================================================================");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t1. Shapes");
                Console.WriteLine("\t2. Miniräknare");
                Console.WriteLine("\t3. Rock,Paper & Scissor");
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
                            var shapes = new ShapesMenu();
                            shapes.MenuChoice();
                            break;

                        case "2":
                            var calc = new CalcylationMenu();
                            calc.MenuChoice();
                            break;

                        case "3":
                            var rps = new RockPaperScissorsGame();
                            rps.Go();
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
