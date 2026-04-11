using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetPractice.Models.Requests
{
    public class RegisterRequest
    {
        public required string UserName { get; set; }
    }
}
