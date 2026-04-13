using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetPractice.Models.DTOs;
using DotnetPractice.Models.Entities;
using DotnetPractice.Models.Requests;
using DotnetPractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetPractice.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostController : ControllerBase
    {
        private readonly PostService _service;

        public PostController(PostService service)
        {
            _service = service;
        }

        [HttpPost("add")]
        public async Task<ActionResult<ApiResponse<Post>>> AddPost(AddPostRequest request)
        {
            ApiResponse<Post> response = await _service.AddPost(request);
            return Ok(response);
        }
    }
}
