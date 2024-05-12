using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_BlogApplication.DTOs;

namespace _2_BlogApplication.Services.IServices
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentDTO>> GetCommentsByArticles(string articleId);
        int CreateComment(CommentDTO commentDTO);
    }
}