using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Enums;

namespace _1_BlogCore.DomainModels.BaseModels
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }=Guid.NewGuid().ToString();
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Created;
    }
}