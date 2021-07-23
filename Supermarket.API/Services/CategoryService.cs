using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services;
using Supermarket.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRespository _categoryRepository;


        public CategoryService(ICategoryRespository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
