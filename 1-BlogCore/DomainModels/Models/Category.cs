using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.BaseModels;
using _1_BlogCore.DomainServices;
using _1_BlogCore.DomainModels.Models;

namespace _1_BlogCore.DomainModels.Models
{
    public class Category: BaseEntity, IBaseEntity
    {
        public string Name { get; set; }
        public string Url { get { return NormalizedUrl.TurkishToEnglish(Name); } }

        public virtual ICollection<Article> Articles { get; set; }
    }
}