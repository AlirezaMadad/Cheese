using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CheeseRepository : Repository<Core.Entities.Cheese>, ICheeseRepository
    {
        public CheeseRepository(CheeseContext cheeseContext) : base(cheeseContext)
        {

        }
        public async Task<List<Core.Entities.Cheese>> GetAllCheesesAsync()
        {
            return new List<Core.Entities.Cheese>()
            {
                new Core.Entities.Cheese
                {
                    Id = 1,
                    Color = "white and red",
                    Price = 1
                },
                new Core.Entities.Cheese
                {
                    Id = 2,
                    Color = "white and blue",
                    Price = 2
                },
                new Core.Entities.Cheese
                {
                    Id = 3,
                    Color = "white and green",
                    Price = 3
                },
                new Core.Entities.Cheese
                {
                    Id = 4,
                    Color = "white and purple",
                    Price = 4
                },
                new Core.Entities.Cheese
                {
                    Id = 5,
                    Color = "white and orange",
                    Price = 5
                },
            };
        }

    }
}
