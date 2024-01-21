using Project1Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var newCalcylation = new Calcylate();

            int run = 1;

            while (run == 1)
            {
                Console.WriteLine("Börja räkna (tryck 0 för att avsluta):");

                string input = Console.ReadLine();

                if (input == "0")
                {
                    run = 0;
                    break;
                }

                try
                {
                    int result = EvaluateExpression(input);
                    Console.WriteLine($"Resultat: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ogiltig inmatning. Felmeddelande: {ex.Message}");
                }
            }
        }

        private int EvaluateExpression(string expression)
        {
            string[] parts = expression.Split(' ');
            if (parts.Length != 3)
            {
                throw new ArgumentException("Ogiltig inmatning");
            }

            int operand1 = Convert.ToInt32(parts[0]);
            int operand2 = Convert.ToInt32(parts[2]);
            char operation = parts[1][0];

            switch (operation)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    if (operand2 != 0)
                    {
                        return operand1 / operand2;
                    }
                    else
                    {
                        throw new DivideByZeroException("Division med noll är inte tillåtet");
                    }
                default:
                    throw new ArgumentException("Ogiltig operator");
                    
            }
        }
    }
}
