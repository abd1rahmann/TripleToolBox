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
            var newCalc = new Calcylate();

            Console.WriteLine("Ange räknesätt\n1. +\n2. -\n3. *\n4. /\n5. √\n6. % ");

           

            bool run = true;
            while ( run )
            {
                string choice = Console.ReadLine();
                switch ( choice )
                {
                    case "1":
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
                      
                        newCalc.Tal1 = tal1;
                        newCalc.Tal2 = tal2;
                        newCalc.Operator = "+";
                        newCalc.Resultat = result1;
                        newCalc.Datum = DateTime.Now;
                        newCalc.Valid = true;

                        _dbContext.Add(newCalc);
                        _dbContext.SaveChanges();

                        Console.WriteLine($"\n{newCalc.Tal1} {newCalc.Operator} {newCalc.Tal2} = {newCalc.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt");


                        break;

                    case "2":
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

                        newCalc.Tal1 = talEtt;
                        newCalc.Tal2 = talTvå;
                        newCalc.Operator = "-";
                        newCalc.Resultat = result2;
                        newCalc.Datum = DateTime.Now;
                        newCalc.Valid = true;

                        _dbContext.Add(newCalc);
                        _dbContext.SaveChanges();

                        Console.WriteLine($"{newCalc.Tal1} {newCalc.Operator} {newCalc.Tal2} = {newCalc.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt");

                        break;

                    case "3":
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

                        newCalc.Tal1 = talOne;
                        newCalc.Tal2 = talTwo;
                        newCalc.Operator = "*";
                        newCalc.Resultat = result3;
                        newCalc.Datum = DateTime.Now;
                        newCalc.Valid = true;

                        _dbContext.Add(newCalc);
                        _dbContext.SaveChanges();

                        Console.WriteLine($"{newCalc.Tal1} {newCalc.Operator} {newCalc.Tal2} = {newCalc.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt");

                        break;

                    case "4":
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
                       



                        newCalc.Tal1 = firstNum;
                        newCalc.Tal2 = secNum;
                        newCalc.Operator = "/";
                        newCalc.Resultat = result4;
                        newCalc.Datum = DateTime.Now;
                        newCalc.Valid = true;

                        _dbContext.Add(newCalc);
                        _dbContext.SaveChanges();

                        Console.WriteLine($"{newCalc.Tal1} {newCalc.Operator} {newCalc.Tal2} = {newCalc.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt");

                        break;

                    case "5":
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

                        newCalc.Tal1 = tal;
                                newCalc.Operator = "√";
                                newCalc.Resultat = (decimal)result5;
                                newCalc.Datum = DateTime.Now;
                                newCalc.Valid = true;

                                _dbContext.Add(newCalc);
                                _dbContext.SaveChanges();

                        Console.WriteLine($"{newCalc.Tal1} {newCalc.Operator}= {newCalc.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt");



                        break;

                    case "6":
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

                        newCalc.Tal1 = num1;
                        newCalc.Tal2 = num2;
                        newCalc.Operator = "%";
                        newCalc.Resultat = result6;
                        newCalc.Datum = DateTime.Now;
                        newCalc.Valid = true;

                        _dbContext.Add(newCalc);
                        _dbContext.SaveChanges();
                        Console.WriteLine($"{newCalc.Tal1} {newCalc.Operator} {newCalc.Tal2} = {newCalc.Resultat}");
                        Console.WriteLine("Kör igen! Välj räknesätt");

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
