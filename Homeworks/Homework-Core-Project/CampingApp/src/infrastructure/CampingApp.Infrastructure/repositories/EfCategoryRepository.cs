using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using CampingApp.Entities;
using CampingApp.Infrastructure.data;
using CampingApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CampingApp.Infrastructure.repositories
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private readonly CampingDbContext _context;

        public EfCategoryRepository(CampingDbContext dbContext)
        {
            _context = dbContext;
        }

        public Category? Get(int id)
        {
            return _context.Categories.Find(id);
        }

        public async Task<Category?> GetAsync(int id)
        {
            return await _context.Categories.AsNoTracking().FirstOrDefaultAsync(_ => _.CategoryID == id);
        }

        public IList<Category?> GetAll() => _context.Categories.AsNoTracking().ToList()!;


        public async Task<IList<Category?>> GetAllAsync()
        {
            return (await _context.Categories.AsNoTracking().ToListAsync())!;
        }

        public void Insert(Category entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
        }

        public async Task InsertAsync(Category entity)
        {
            await _context.Categories.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Update(Category entity)
        {
            _context.Categories.Update(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(Category entity)
        {
            _context.Categories.Update(entity!);
            await _context.SaveChangesAsync();
        }

        public void Delete(Category category)
        {
            var deletingCategory = _context.Categories.Find(category.CategoryID);
            _context.Categories.Remove(deletingCategory!);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(Category category)
        {
            var deletingCategory = await _context.Categories.FindAsync(category.CategoryID);
            _context.Categories.Remove(deletingCategory!);
            await _context.SaveChangesAsync();
        }
    }
}
