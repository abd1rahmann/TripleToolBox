using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Library.Data
{
    public class ApplicationDBContext
    {
        public class ApplicationDbContext : DbContext
        {

            public DbSet<Shape> Shape { get; set; }
            public DbSet<Calcylate> Calcylate { get; set; }
            public DbSet<RockPaperScissor> RockPaperScissor { get; set; }

            public ApplicationDbContext()
            {

            }

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(@"Server=localhost;Database=Project1;Trusted_Connection=True;TrustServerCertificate=true;");
                }
            }

        }
    }
}

