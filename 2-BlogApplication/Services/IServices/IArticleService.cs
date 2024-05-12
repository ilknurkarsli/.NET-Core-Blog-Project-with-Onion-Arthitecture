using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_BlogApplication.DTOs;

namespace _2_BlogApplication.Services.IServices
{
    public interface IArticleService
    {
        Task<ArticleDTO> GetArticlebyId(string articleid);
        Task<IEnumerable<ArticleDTO>> GetAllArticlesAsync();
        Task<IEnumerable<ArticleDTO>> GetAllArticlesByUserIdAsync(string userId);
        Task<IEnumerable<ArticleDTO>> GetAllArticlesByCategoryIdAsync(string categoryId);
        int CreateArticle(ArticleDTO articleDTO);
        int UpdateArticle(ArticleDTO articleDTO);
        Task<int> DeleteArticle(string articleId);
    }
}