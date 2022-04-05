using Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface ICheeseRepository : IRepository<Core.Entities.Cheese>
    {
        public Task<List<Core.Entities.Cheese>> GetAllCheesesAsync();
    }
}
