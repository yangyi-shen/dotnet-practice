using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetPractice.Models.Entities;
using DotnetPractice.Repository;

namespace DotnetPractice.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _repository;

        public CategoryService(CategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await _repository.GetAllCategories();
        }

        public async Task AddCategory(Category data)
        {
            await _repository.AddCategory(data);
        }
    }
}
