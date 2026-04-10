using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetPractice.Models.DTOs
{
    public class ApiResponse<T>
    {
        public bool Status { get; set; }
        public required T Data { get; set; }
    }
}
