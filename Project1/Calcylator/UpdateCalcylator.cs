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
         public void Update() { }
    }
}
