using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using _2_BlogApplication.IRepositories;
using _3_BlogInfrasracture.Contexts;
using _3_BlogInfrasracture.Repositories.BaseRepos;

namespace _3_BlogInfrasracture.Repositories
{
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(AppDbContext context) : base(context)
        {
        }
    }
}