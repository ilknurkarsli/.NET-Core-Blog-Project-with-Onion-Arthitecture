using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_BlogApplication.IRepositories;

namespace _2_BlogApplication.Utilities.IUnitOfWorks
{
    public interface IUnitOfWork: IDisposable
    {
        IAppUserRepo AppUserRepo{ get; }
        IArticleRepo ArticleRepo{ get; }
        ICommentRepo CommentRepo{ get; }
        ICategoryRepo CategoryRepo{ get; }
        Task<int> SaveAsync();
    }
}