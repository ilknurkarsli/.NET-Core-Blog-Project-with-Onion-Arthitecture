using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_BlogApplication.Services;
using _2_BlogApplication.Services.IServices;
using _2_BlogApplication.Utilities.IUnitOfWorks;
using AutoMapper;

namespace _3_BlogInfrasracture.Utilities.UnitOfWorks
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UnitOfWorkService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            AppUserService = new AppUserService(_unitOfWork, _mapper);
            ArticleService = new ArticleService(_unitOfWork, _mapper);
            CategoryService = new CategoryService(_unitOfWork, _mapper);
            CommentService = new CommentService(_unitOfWork, _mapper);
        }
        public IAppUserService AppUserService {get;}

        public IArticleService ArticleService {get;}

        public ICategoryService CategoryService {get;}

        public ICommentService CommentService {get;}
    }
}