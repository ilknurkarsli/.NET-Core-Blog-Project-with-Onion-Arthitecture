using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using _2_BlogApplication.DTOs;
using _2_BlogApplication.Utilities.ILoggings;
using _2_BlogApplication.Utilities.IUnitOfWorks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _4_BlogPresentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWorkService _unitOfWorkService;
        private readonly ILogging _logger;
        private readonly IMapper mapper;

        public CategoryController(IUnitOfWorkService unitOfWorkService, ILogging logger, IMapper mapper)
        {
            _unitOfWorkService = unitOfWorkService;
            _logger = logger;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[action]")]
        public async  Task<IEnumerable<CategoryDTO>> GetAllCat()
        {
            var categories= await _unitOfWorkService.CategoryService.GetAllCategoriesAsync();
            return categories;
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult CreateCategory(CategoryDTO categoryDTO) 
        { 
            var result = _unitOfWorkService.CategoryService.CreateCategory(categoryDTO);
            if (result > 0)
                return Ok();
            else
                _logger.LogError("Hata Gerçekleşti...");
                return BadRequest();
        }
        [HttpGet("{id}")]
        public async Task<int> DeleteCategory(string id) 
        {
           return await _unitOfWorkService.CategoryService.DeleteCategory(id);
        }
     }
}