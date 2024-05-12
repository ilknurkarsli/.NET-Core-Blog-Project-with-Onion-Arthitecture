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
    public class AppUserRepo : BaseRepo<AppUser>, IAppUserRepo
    {
        private readonly AppDbContext _context;
        public AppUserRepo(AppDbContext context) : base(context)
        {
            _context=context;
        }

        public async Task<AppUser> GetUserByEmail(string userEmail)
        {
           return await _context.Users.FirstOrDefaultAsync(x=>x.Email==userEmail);
        }

        public async Task<AppUser> GetUserByName(string userName)
        {
            return await _context.Users.FirstOrDefaultAsync(x=>x.UserName==userName);
        }
    }
}