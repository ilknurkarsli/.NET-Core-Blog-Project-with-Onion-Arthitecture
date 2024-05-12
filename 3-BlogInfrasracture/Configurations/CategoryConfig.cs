using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _3_BlogInfrasracture.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           builder.HasMany(c => c.Articles).WithOne(c => c.Category).HasForeignKey(c => c.CategoryId);
        }
    }
}