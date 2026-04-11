using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetPractice.Repository
{
    public class PostRepository
    {
        private readonly ContentDBContext _dbo;

        public PostRepository(ContentDBContext dbContext)
        {
            _dbo = dbContext;
        }
    }
}
