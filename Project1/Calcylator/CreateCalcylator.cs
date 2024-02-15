using Project1Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.Calcylator
{
    public class CreateCalcylator
    {
        private readonly ApplicationDbContext _dbContext;


        public CreateCalcylator(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create()
        {
            Console.WriteLine("Ange räknesätt\n1. +\n2. -\n3. *\n4. /\n5. √\n6. % ");

            bool run = true;
            while ( run )
            {
                string choice = Console.ReadLine();
                switch ( choice )
                {
                    case "1":
                        var calc1 = new Calcylate();
                        decimal tal1 = 0;
                        while (true)
                        {
                            Console.WriteLine("\nAnge första talet");
                            if (decimal.TryParse(Console.ReadLine(), out tal1))
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                            }
                        }


                        decimal tal2 = 0;
                        while (true)
                        {
                            Console.WriteLine("\nAnge andra talet");
                            if (decimal.TryParse(Console.ReadLine(), out tal2))
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                            }
                        }
                        decimal result1 = tal1 + tal2;
                      
                        calc1.Tal1 = tal1;
                        calc1.Tal2 = tal2;
                        calc1.Operator = "+";
                        calc1.Resultat = result1;
                        calc1.Datum = DateTime.Now;
                        calc1.Valid = true;

                        _dbContext.Add(calc1);
                        _dbContext.SaveChanges();

                        Console.WriteLine($"\n{calc1.Tal1} {calc1.Operator} {calc1.Tal2} = {calc1.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt eller tryck på O för att gå tillbaka till menyn.");


                        break;

                    case "2":
                        var calc2 = new Calcylate();
                        decimal talEtt = 0;
                        while (true)
                        {
                            Console.WriteLine("\nAnge första talet");
                            if (decimal.TryParse(Console.ReadLine(), out talEtt))
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                            }
                        }

                        decimal talTvå = 0;
                        while (true)
                        {
                            Console.WriteLine("\nAnge andra talet");
                            if (decimal.TryParse(Console.ReadLine(), out talTvå))
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                            }
                        }

                        decimal result2 = talEtt - talTvå;

                        calc2.Tal1 = talEtt;
                        calc2.Tal2 = talTvå;
                        calc2.Operator = "-";
                        calc2.Resultat = result2;
                        calc2.Datum = DateTime.Now;
                        calc2.Valid = true;

                        _dbContext.Add(calc2);
                        _dbContext.SaveChanges();

                        Console.WriteLine($"{calc2.Tal1} {calc2.Operator} {calc2.Tal2} = {calc2.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt eller tryck på O för att gå tillbaka till menyn.");

                        break;

                    case "3":
                        var calc3 = new Calcylate();
                        decimal talOne = 0;
                        while (true)
                        {
                            Console.WriteLine("\nAnge första talet");
                            if (decimal.TryParse(Console.ReadLine(), out talOne))
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                            }
                        }


                        decimal talTwo = 0;
                        while (true)
                        {
                            Console.WriteLine("\nAnge andra talet");
                            if (decimal.TryParse(Console.ReadLine(), out talTwo))
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                            }
                        }

                        decimal result3 = talOne * talTwo;

                        calc3.Tal1 = talOne;
                        calc3.Tal2 = talTwo;
                        calc3.Operator = "*";
                        calc3.Resultat = result3;
                        calc3.Datum = DateTime.Now;
                        calc3.Valid = true;

                        _dbContext.Add(calc3);
                        _dbContext.SaveChanges();

                        Console.WriteLine($"{calc3.Tal1} {calc3.Operator} {calc3.Tal2} = {calc3.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt eller tryck på O för att gå tillbaka till menyn.");

                        break;

                    case "4":
                        var calc4 = new Calcylate();
                        decimal firstNum = 0;
                        while (true)
                        {
                            Console.WriteLine("\nAnge första talet");
                            if (decimal.TryParse(Console.ReadLine(), out firstNum))
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                            }
                        }
                        
                        decimal secNum = 0;
                        decimal result4 = 0;
                        while (true)
                        {
                            Console.WriteLine("\nAnge andra talet");
                            if (decimal.TryParse(Console.ReadLine(), out secNum))
                            {
                                if (secNum == 0)
                                {
                                    Console.WriteLine("Det går inte att dela med 0! Testa igen");
                                    
                                }
                                else
                                {
                                     result4 = firstNum / secNum;
                                    break; 

                                }
                            }

                            else
                            {
                                Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                            }
                        }
                       



                        calc4.Tal1 = firstNum;
                        calc4.Tal2 = secNum;
                        calc4.Operator = "/";
                        calc4.Resultat = result4;
                        calc4.Datum = DateTime.Now;
                        calc4.Valid = true;

                        _dbContext.Add(calc4);
                        _dbContext.SaveChanges();

                        Console.WriteLine($"{calc4.Tal1} {calc4.Operator} {calc4.Tal2} = {calc4.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt eller tryck på O för att gå tillbaka till menyn.");

                        break;

                    case "5":
                        var calc5 = new Calcylate();
                        decimal tal;
                        double result5 = 0; 

                        while (true)
                        {
                            Console.WriteLine("\nAnge talet");
                            if (decimal.TryParse(Console.ReadLine(), out tal))
                            {
                                if (0 > tal)
                                {
                                    Console.WriteLine("Det går inta att ta roten ur ett negativt tal! Testa igen");

                                }
                                else
                                {
                                    result5 = Math.Sqrt((double)tal);
                                    break;

                                }
                            }

                            else
                            {
                                Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                            }
                        }

                                calc5.Tal1 = tal;
                                calc5.Operator = "√";
                                calc5.Resultat = (decimal)result5;
                                calc5.Datum = DateTime.Now;
                                calc5.Valid = true;

                                _dbContext.Add(calc5);
                                _dbContext.SaveChanges();

                        Console.WriteLine($"{calc5.Tal1} {calc5.Operator} = {calc5.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt eller tryck på O för att gå tillbaka till menyn.");



                        break;

                    case "6":
                        var calc6 = new Calcylate();
                        decimal num1 = 0;
                        while (true)
                        {
                            Console.WriteLine("\nAnge första talet");
                            if (decimal.TryParse(Console.ReadLine(), out num1))
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                            }
                        }

                        decimal num2;
                        decimal result6 = 0;
                        while (true)
                        {
                            Console.WriteLine("\nAnge andra talet");
                            if (decimal.TryParse(Console.ReadLine(), out num2))
                            {
                                if (num2 == 0)
                                {
                                    Console.WriteLine("Det går inte att räkna modulus med 0 som nämnare! Testa igen");

                                }
                                else
                                {
                                    result6 = num1 % num2;
                                    break;

                                }
                            }

                            else
                            {
                                Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                            }
                        }

                        calc6.Tal1 = num1;
                        calc6.Tal2 = num2;
                        calc6.Operator = "%";
                        calc6.Resultat = result6;
                        calc6.Datum = DateTime.Now;
                        calc6.Valid = true;

                        _dbContext.Add(calc6);
                        _dbContext.SaveChanges();
                        Console.WriteLine($"{calc6.Tal1} {calc6.Operator} {calc6.Tal2} = {calc6.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt eller tryck på O för att gå tillbaka till menyn.");

                        break;

                    case "0":
                        Console.Clear();
                        var back = new CalcylationMenu();
                        back.MenuChoice();
                        break;
                }
            }
        }
    }
}
