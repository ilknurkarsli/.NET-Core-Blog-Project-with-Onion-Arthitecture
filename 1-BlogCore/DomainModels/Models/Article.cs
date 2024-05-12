using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.BaseModels;
using _1_BlogCore.DomainModels.Models;

namespace _1_BlogCore.DomainModels.Models
{
    public class Article: BaseEntity, IBaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public string CategoryId { get; set; }
        public string AppUserId { get; set; }

        public virtual AppUser User { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}