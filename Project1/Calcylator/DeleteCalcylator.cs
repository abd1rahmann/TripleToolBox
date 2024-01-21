using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project1Library.Data.ApplicationDBContext;

namespace Project1.Calcylator
{
    public class DeleteCalcylator
    {
        private readonly ApplicationDbContext _dbContext;


        public DeleteCalcylator(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete() { }
    }
}
