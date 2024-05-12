using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _3_BlogInfrasracture.Configurations
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(c => c.User).WithMany(c => c.Comments).HasForeignKey(c => c.AppUserId).OnDelete(DeleteBehavior.NoAction);   
        }
    }
}