using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_BlogApplication.DTOs;
using _2_BlogApplication.Utilities.IUnitOfWorks;
using AutoMapper;

namespace _2_BlogApplication.Services.IServices
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CommentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public int CreateComment(CommentDTO commentDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CommentDTO>> GetCommentsByArticles(string articleId)
        {
           var comments=await unitOfWork.CommentRepo.GetAllByArticleIdAsync(articleId);
           return mapper.Map<IEnumerable<CommentDTO>>(comments);    
        }
    }
}