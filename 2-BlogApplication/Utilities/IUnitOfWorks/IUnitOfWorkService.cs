using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_BlogApplication.Services.IServices;

namespace _2_BlogApplication.Utilities.IUnitOfWorks
{
    public interface IUnitOfWorkService
    {
         public IAppUserService AppUserService { get; }
        public IArticleService ArticleService { get; }
        public ICategoryService CategoryService { get; }
        public ICommentService CommentService { get; }
    }
}