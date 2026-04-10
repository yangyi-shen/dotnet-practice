using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetPractice.Models.DTOs
{
    public class ApiResponse<T>
    {
        public bool Status { get; set; }
        public T Data { get; set; } = default!;

        public ApiResponse(T data)
        {
            Status = true;
            Data = data;
        }
    }
}
