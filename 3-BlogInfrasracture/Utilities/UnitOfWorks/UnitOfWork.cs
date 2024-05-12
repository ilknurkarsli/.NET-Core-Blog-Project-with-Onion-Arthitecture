using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_BlogApplication.IRepositories;
using _2_BlogApplication.Utilities.IUnitOfWorks;
using _3_BlogInfrasracture.Contexts;
using _3_BlogInfrasracture.Repositories;

namespace _3_BlogInfrasracture.Utilities.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            this._context = context;
            AppUserRepo = new AppUserRepo(_context);
            ArticleRepo = new ArticleRepo(_context);
            CommentRepo = new CommentRepo(_context);
            CategoryRepo = new CategoryRepo(_context);
        }

        public IAppUserRepo AppUserRepo {get;}

        public IArticleRepo ArticleRepo  {get;}

        public ICommentRepo CommentRepo  {get;}

        public ICategoryRepo CategoryRepo  {get;}

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
           return await _context.SaveChangesAsync();
        }
    }
}