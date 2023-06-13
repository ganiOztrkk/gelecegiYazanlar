using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampingApp.Entities;

namespace CampingApp.Infrastructure.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        public IEnumerable<Product> GetProductsByCategory(int categoryId);
        public IEnumerable<Product> GetProductsByName(string productName);
    }
}
