using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampingApp.Entities;
using CampingApp.Infrastructure.data;
using Microsoft.EntityFrameworkCore;

namespace CampingApp.Infrastructure.repositories
{
    public class EfUserRepository : IUserRepository
    {
        private readonly CampingDbContext _dbContext;

        public EfUserRepository(CampingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Insert(User entity)
        {
            _dbContext.Users.Add(entity);
            _dbContext.SaveChanges();
        }

        public async Task InsertAsync(User entity)
        {
            _dbContext.Users.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void Delete(User user)
        {
            var deletingUser = _dbContext.Users.Find(user.UserID);
            _dbContext.Users.Remove(deletingUser);
            _dbContext.SaveChanges();
        }

        public async Task DeleteAsync(User user)
        {
            var deletingUser = await _dbContext.Users.FindAsync(user.UserID);
            _dbContext.Users.Remove(deletingUser);
            await _dbContext.SaveChangesAsync();
        }

        public IList<User?> GetAll() => _dbContext.Users.AsNoTracking().ToList()!;

        public async Task<IList<User?>> GetAllAsync() => (await _dbContext.Users.AsNoTracking().ToListAsync())!;
        

        public User? Get(int id) => _dbContext.Users.AsNoTracking().FirstOrDefault(x => x.UserID == id);
       

        public async Task<User?> GetAsync(int id) => await _dbContext.Users.AsNoTracking().FirstOrDefaultAsync(x => x.UserID == id);

        public void Update(User entity)
        {
            _dbContext.Users.Update(entity);
            _dbContext.SaveChanges();
        }

        public async Task UpdateAsync(User entity)
        {
            _dbContext.Users.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<User?>> GetAllForLoginAsync() => (await _dbContext.Users.AsNoTracking().ToListAsync())!;
       
        public IList<User?> GetAllForLogin() => _dbContext.Users.AsNoTracking().ToList()!;
    }
}
