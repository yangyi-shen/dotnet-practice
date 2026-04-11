using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetPractice.Models.DTOs;
using DotnetPractice.Models.Requests;
using DotnetPractice.Models.Responses;
using DotnetPractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetPractice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ApiResponse<UserDataDTO>>> RegisterUser(
            RegisterRequest request
        )
        {
            ApiResponse<UserDataDTO> response = await _service.RegisterUser(request);
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ApiResponse<UserDataDTO>>> LoginUser(LoginRequest request)
        {
            ApiResponse<UserDataDTO> response = await _service.LoginUser(request);
            return Ok(response);
        }
    }
}
