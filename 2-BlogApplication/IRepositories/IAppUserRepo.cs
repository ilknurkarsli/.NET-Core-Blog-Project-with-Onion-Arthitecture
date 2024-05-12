using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using _2_BlogApplication.IRepositories.BaseRepos;

namespace _2_BlogApplication.IRepositories
{
    public interface IAppUserRepo: IBaseRepo<AppUser>
    {
        Task<AppUser> GetUserByName(string userName);
        Task<AppUser> GetUserByEmail(string userEmail);
    }
}