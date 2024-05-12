using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.BaseModels;
using _1_BlogCore.DomainModels.Models;

namespace _1_BlogCore.DomainModels.Models
{
    public class Comment:BaseEntity, IBaseEntity
    {
        public string Content { get; set; }

        public string AppUserId { get; set; }
        public string ArticleId { get; set; }

        public virtual AppUser User { get; set; }
        public virtual Article Article { get; set; }
    }
}