using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _3_BlogInfrasracture.Configurations
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasMany(u => u.Articles).WithOne(u => u.User).HasForeignKey(a => a.AppUserId);

            //builder.HasMany(u => u.Comments).WithOne(u => u.User).HasForeignKey(c => c.AppUserId);
        }
    }
}