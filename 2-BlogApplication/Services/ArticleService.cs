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

namespace _2_BlogApplication.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public int CreateArticle(ArticleDTO articleDTO)
        {
            var article = mapper.Map<Article>(articleDTO);
            return unitOfWork.ArticleRepo.Add(article);
        }

        public async Task<int> DeleteArticle(string articleId)
        {
            var article =await unitOfWork.ArticleRepo.GetByIdAsync(articleId);
            if(article is not null)
            {
                article.DeleteDate = DateTime.Now;
                article.Status=EntityStatus.Deleted;
                return unitOfWork.ArticleRepo.Delete(article);
            }
            return 0;
        }

        public async Task<IEnumerable<ArticleDTO>> GetAllArticlesAsync()
        {
            var article =await unitOfWork.ArticleRepo.GetAllAsync(x=>x.Status!=EntityStatus.Deleted);
            return mapper.Map<IEnumerable<ArticleDTO>>(article);
        }

        public async Task<IEnumerable<ArticleDTO>> GetAllArticlesByCategoryIdAsync(string categoryId)
        {
            var articles=await unitOfWork.ArticleRepo.GetAllAsync(x=>x.CategoryId==categoryId);
            return mapper.Map<IEnumerable<ArticleDTO>>(articles);
        }

        public async Task<IEnumerable<ArticleDTO>> GetAllArticlesByUserIdAsync(string userId)
        {
            var articles=await unitOfWork.ArticleRepo.GetAllAsync(x=>x.AppUserId==userId);
            return mapper.Map<IEnumerable<ArticleDTO>>(articles);
        }

        public async Task<ArticleDTO> GetArticlebyId(string articleid)
        {
            var article =await unitOfWork.ArticleRepo.GetByIdAsync(articleid);
            return mapper.Map<ArticleDTO>(article); 
        }

        public int UpdateArticle(ArticleDTO articleDTO)
        {
            var article =mapper.Map<Article>(articleDTO);
            if (article != null)
            {
                article.UpdateDate = DateTime.Now;
                article.Status = EntityStatus.Updated;
                return unitOfWork.ArticleRepo.Update(article);
            }
            return 0;
        }
    }
}