using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using _2_BlogApplication.IRepositories;
using _3_BlogInfrasracture.Contexts;
using _3_BlogInfrasracture.Repositories.BaseRepos;
using Microsoft.EntityFrameworkCore;

namespace _3_BlogInfrasracture.Repositories
{
    public class CommentRepo: BaseRepo<Comment>, ICommentRepo
    {
        private readonly AppDbContext _context;
        public CommentRepo(AppDbContext context) : base(context)
        {
            _context=context;
        }

        public async Task<IEnumerable<Comment>> GetAllByArticleIdAsync(string id)
        {
            return await _context.Comments.Where(c => c.ArticleId==id).ToListAsync();
        }
    }
}