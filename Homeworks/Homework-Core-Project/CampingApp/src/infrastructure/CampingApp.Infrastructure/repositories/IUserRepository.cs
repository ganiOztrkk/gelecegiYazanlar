using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampingApp.Entities;
using CampingApp.Infrastructure.Repositories;

namespace CampingApp.Infrastructure.repositories
{
    public interface IUserRepository : IRepository<User>
    {
        public Task<IList<User?>> GetAllForLoginAsync();
        public IList<User?> GetAllForLogin();
    }
}
