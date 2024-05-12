using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using _1_BlogCore.DomainModels.Enums;
using _2_BlogApplication.DTOs;
using _2_BlogApplication.IRepositories;
using _2_BlogApplication.Services.IServices;
using _2_BlogApplication.Utilities.IUnitOfWorks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using _2_BlogApplication.Utilities.ILoggings;

namespace _2_BlogApplication.Services
{
    public class CategoryService : ICategoryService
    {
        //unitofwork yapıları tek tek ayaga kaldırmakla ugrasmamızı engeller. sadece unitofworku ayaga kaldırarak içerisinden hepisne ulaşabiliriz. 
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public int CreateCategory(CategoryDTO categoryDTO)
        {
            var category = mapper.Map<Category>(categoryDTO);
            return unitOfWork.CategoryRepo.Add(category); 
        }

        public async Task<int> DeleteCategory(string categoryId)
        {
           var cat=await unitOfWork.CategoryRepo.GetByIdAsync(categoryId);
           cat.DeleteDate = DateTime.Now;
           cat.Status = EntityStatus.Deleted;
           return unitOfWork.CategoryRepo.Delete(cat);
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllActiveAsync()
        {
           var catactive= await unitOfWork.CategoryRepo.GetAllActiveAsync();
           return mapper.Map<IEnumerable<CategoryDTO>>(catactive);
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync()
        {
            var cats=await unitOfWork.CategoryRepo.GetAllAsync();
            //var deneme=mapper.Map<CategoryDTO>(cats); ***Bu yontemle deneme degiskeni bir nesne donduruyor. ama biz liste dondurmesini istiyoruz. Onceden biz bunu select yaparak sağlıyorduk su an daha kolay yontemiyle su sekilde listel dondurebiliriz: 
            return mapper.Map<IEnumerable<CategoryDTO>>(cats);
        }

        public async Task<CategoryDTO> GetCategoryByIdAsync(string categoryId)
        {
           var cat=await unitOfWork.CategoryRepo.GetByIdAsync(categoryId);
           return mapper.Map<CategoryDTO>(cat);
        }

        public int UpdateCategory(CategoryDTO categoryDTO)
        {
            var cat=mapper.Map<Category>(categoryDTO);
            cat.UpdateDate = DateTime.Now;
            cat.Status = EntityStatus.Updated;
            return unitOfWork.CategoryRepo.Update(cat);
        }
    }
}