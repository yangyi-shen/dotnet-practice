using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetPractice.Repository
{
    public class UserRepository
    {
        private readonly UserDBContext _dbo;

        public UserRepository(UserDBContext dbContext)
        {
            _dbo = dbContext;
        }

        public Task AddUser(User data)
        {
            _dbo.Users.Add(data);
            return _dbo.SaveChangesAsync();
        }

        public Task<List<User>> GetAllUsers()
        {
            return _dbo.Users.ToListAsync();
        }

        public Task<User> GetUserByGUID(string guid)
        {
            return _dbo.Users.Where(u => u.GUID == guid).FirstAsync();
        }

        public Task EditUser(User data)
        {
            _dbo.Users.Update(data);
            return _dbo.SaveChangesAsync();
        }
    }
}
