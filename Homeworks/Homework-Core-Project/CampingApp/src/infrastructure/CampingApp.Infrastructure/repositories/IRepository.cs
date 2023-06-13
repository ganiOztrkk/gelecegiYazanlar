using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CampingApp.Entities;

namespace CampingApp.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        public T? Get(int id);
        public Task <T?> GetAsync(int id);
        public IList<T?> GetAll();
        public Task<IList<T?>> GetAllAsync();
        public void Insert(T entity);
        public Task InsertAsync(T entity);
        public void Update(T entity);
        public Task UpdateAsync(T entity);
        public void Delete(T entity);
        public Task DeleteAsync(T entity);
    }
}
