using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using _2_BlogApplication.IRepositories.BaseRepos;

namespace _2_BlogApplication.IRepositories
{
    public interface ICommentRepo: IBaseRepo<Comment>
    {
        Task<IEnumerable<Comment>> GetAllByArticleIdAsync(string id);
    }
}