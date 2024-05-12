using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_BlogApplication.DTOs
{
    public class CommentDTO
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string AppUserId { get; set; }
        public string ArticleId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}