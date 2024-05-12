using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using _2_BlogApplication.DTOs;

namespace _2_BlogApplication.Services.IServices
{
    public interface ICategoryService
    {
        Task<CategoryDTO> GetCategoryByIdAsync(string categoryId);
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();
        int CreateCategory(CategoryDTO categoryDTO);
        int UpdateCategory(CategoryDTO categoryDTO);
        Task<int> DeleteCategory(string categoryId);
        //Task<IEnumerable<CategoryDTO>> GetAllActiveAsync(Expression<Func<CategoryDTO, bool>> filter = null);
        Task<IEnumerable<CategoryDTO>> GetAllActiveAsync();
    }
}