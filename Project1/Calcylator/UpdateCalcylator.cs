using Project1.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.Calcylator
{
    public class UpdateCalcylator
    {
        private readonly ApplicationDbContext _dbContext;


        public UpdateCalcylator(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Update()
        {
            Console.WriteLine("===========================================================================");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            Console.WriteLine("\t1. Uppdatera uträkning");
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

                        foreach (var calc in _dbContext.Calcylate)
                        {


                            Console.WriteLine("\n=====================================================================================================================");
                            Console.WriteLine($"ID: {calc.CalcylateId}||{calc.Tal1} {calc.Operator} {calc.Tal2} = {calc.Resultat}");
                            Console.WriteLine("=======================================================================================================================\n");
                        }
                        Console.WriteLine("\nVälj ID på beräkningen du vill uppdatera");

                        int calcId = 0;

                        while (!int.TryParse(Console.ReadLine(), out calcId))
                        {
                            Console.WriteLine("Fel inmatning!");
                        }
                        var calcIdToUpdate = _dbContext.Calcylate.FirstOrDefault(c => c.CalcylateId == calcId);
                        if (calcIdToUpdate == null)
                        {
                            Console.WriteLine("Ogiltigt ID!");
                        }
                        else
                        {
                            if (calcIdToUpdate.Operator == "+")
                            {
                                Console.WriteLine("\nAnge första talet");
                                decimal tal1 = 0;
                                if (!decimal.TryParse(Console.ReadLine(), out tal1))
                                {
                                    Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                                }

                                Console.WriteLine("\nAnge andra talet");
                                decimal tal2 = 0;
                                if (!decimal.TryParse(Console.ReadLine(), out tal2))
                                {
                                    Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                                }

                                decimal result1 = tal1 + tal2;

                                calcIdToUpdate.Tal1 = tal1;
                                calcIdToUpdate.Tal2 = tal2;
                                calcIdToUpdate.Operator = "+";
                                calcIdToUpdate.Resultat = result1;
                                calcIdToUpdate.Datum = DateTime.Now;
                                _dbContext.SaveChanges();

                                Console.WriteLine($"\n{calcIdToUpdate.Tal1} {calcIdToUpdate.Operator} {calcIdToUpdate.Tal2} = {calcIdToUpdate.Resultat}");
                                Console.WriteLine("Kör igen! Tryck 1");

                            }

                            if (calcIdToUpdate.Operator == "-")
                            {
                                Console.WriteLine("Ange första talet");
                                decimal talEtt = 0;
                                if (!decimal.TryParse(Console.ReadLine(), out talEtt))
                                {
                                    Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                                }

                                Console.WriteLine("Ange andra talet");
                                decimal talTvå = 0;
                                if (!decimal.TryParse(Console.ReadLine(), out talTvå))
                                {
                                    Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                                }

                                decimal result2 = talEtt - talTvå;

                                calcIdToUpdate.Tal1 = talEtt;
                                calcIdToUpdate.Tal2 = talTvå;
                                calcIdToUpdate.Operator = "-";
                                calcIdToUpdate.Resultat = result2;
                                calcIdToUpdate.Datum = DateTime.Now;
                                _dbContext.SaveChanges();

                                Console.WriteLine($"{calcIdToUpdate.Tal1} {calcIdToUpdate.Operator} {calcIdToUpdate.Tal2} = {calcIdToUpdate.Resultat}");
                                Console.WriteLine("Kör igen! Tryck 1");

                            }

                            if (calcIdToUpdate.Operator == "*")
                            {
                                Console.WriteLine("Ange första talet");
                                decimal talOne = 0;
                                if (!decimal.TryParse(Console.ReadLine(), out talOne))
                                {
                                    Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                                }



                                Console.WriteLine("Ange andra talet");
                                decimal talTwo = 0;
                                if (!decimal.TryParse(Console.ReadLine(), out talTwo))
                                {
                                    Console.WriteLine("Fel inmatning! Ange ett giltigt nummer.");
                                }

                                decimal result3 = talOne * talTwo;

                                calcIdToUpdate.Tal1 = talOne;
                                calcIdToUpdate.Tal2 = talTwo;
                                calcIdToUpdate.Operator = "*";
                                calcIdToUpdate.Resultat = result3;
                                calcIdToUpdate.Datum = DateTime.Now;
                                _dbContext.SaveChanges();

                                Console.WriteLine($"{calcIdToUpdate.Tal1} {calcIdToUpdate.Operator} {calcIdToUpdate.Tal2} = {calcIdToUpdate.Resultat}");
                                Console.WriteLine("Kör igen! Tryck 1 ");

                            }

                            if (calcIdToUpdate.Operator == "/")
                            {
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
                                decimal result4;
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


                                calcIdToUpdate.Tal1 = firstNum;
                                calcIdToUpdate.Tal2 = secNum;
                                calcIdToUpdate.Operator = "/";
                                calcIdToUpdate.Resultat = result4;
                                calcIdToUpdate.Datum = DateTime.Now;
                                _dbContext.SaveChanges();

                                Console.WriteLine($"{calcIdToUpdate.Tal1} {calcIdToUpdate.Operator} {calcIdToUpdate.Tal2} = {calcIdToUpdate.Resultat}");
                                Console.WriteLine("Kör igen! Tryck 1");

                            }

                            if (calcIdToUpdate.Operator == "√")
                            {
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

                                calcIdToUpdate.Tal1 = tal;
                                calcIdToUpdate.Operator = "√";
                                calcIdToUpdate.Resultat = (decimal)result5;
                                calcIdToUpdate.Datum = DateTime.Now;
                                _dbContext.SaveChanges();

                                Console.WriteLine($"{calcIdToUpdate.Tal1} {calcIdToUpdate.Operator} {calcIdToUpdate.Tal2} = {calcIdToUpdate.Resultat}");
                                Console.WriteLine("Kör igen! Tryck 1");

                            }

                            if (calcIdToUpdate.Operator == "%")
                            {
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
                                decimal result6;
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


                                calcIdToUpdate.Tal1 = num1;
                                calcIdToUpdate.Tal2 = num2;
                                calcIdToUpdate.Operator = "%";
                                calcIdToUpdate.Resultat = result6;
                                calcIdToUpdate.Datum = DateTime.Now;

                                Console.WriteLine($"{calcIdToUpdate.Tal1} {calcIdToUpdate.Operator} {calcIdToUpdate.Tal2} = {calcIdToUpdate.Resultat}");
                                Console.WriteLine("Kör igen! Tryck 1");


                                _dbContext.SaveChanges();
                            }

                        }


                        _dbContext.SaveChanges();
                        break;

                    case "0":
                        Console.Clear();
                        var back = new CalcylationMenu();
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
