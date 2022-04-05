using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class CheeseContext : DbContext
    {
        public CheeseContext(DbContextOptions<CheeseContext> options) : base (options)
        {

        }

        public DbSet<Core.Entities.Cheese> Cheeses { get; set; }
    }
}
