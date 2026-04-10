using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetPractice.Repository
{
    public class UserRepository
    {
        private readonly UserDBContext _dbo;

        public UserRepository(UserDBContext dbContext)
        {
            _dbo = dbContext;
        }
    }
}
