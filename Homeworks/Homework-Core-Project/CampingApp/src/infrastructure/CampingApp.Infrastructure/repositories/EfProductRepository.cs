using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampingApp.Entities;
using CampingApp.Infrastructure.data;
using Microsoft.EntityFrameworkCore;

namespace CampingApp.Infrastructure.Repositories
{
    public class EfProductRepository : IProductRepository
    {
        private readonly CampingDbContext _context;

        public EfProductRepository(CampingDbContext context)
        {
            _context = context;
        }
        

        public async Task<Product?> GetAsync(int id) => await _context.Products.AsNoTracking().FirstOrDefaultAsync(_=>_.ProductID == id);


        public async Task<IList<Product?>> GetAllAsync() => (await _context.Products.AsNoTracking().ToListAsync())!;


        public async Task InsertAsync(Product entity)
        {
            await _context.Products.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product entity)
        {
            _context.Products.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Product product)
        {
            var deletingProduct = await _context.Products.FindAsync(product.ProductID);
            _context.Products.Remove(deletingProduct!);
            await _context.SaveChangesAsync();
        }
        public void Update(Product entity)
        {
            _context.Products.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Product product)
        {
            var deletingProduct = _context.Products.Find(product.ProductID);
            _context.Products.Remove(deletingProduct!);
            _context.SaveChanges();
        }
        public void Insert(Product entity)
        {
            _context.Products.Add(entity);
            _context.SaveChanges();
        }
        public Product? Get(int id) => _context.Products.FirstOrDefault(_ => _.ProductID == id);
       
        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            var categoryFiltredProducts = _context.Products.Where(_ => _.ProductCategoryID == categoryId);
            return categoryFiltredProducts.AsEnumerable();
        }
        
        public IEnumerable<Product> GetProductsByName(string productName)
        {
            var nameFiltredProduct = _context.Products.Where(_ => _.ProductName == productName);
            return nameFiltredProduct.AsEnumerable();
        }
        public IList<Product?> GetAll() => _context.Products.AsNoTracking().ToList()!;
    }
}
