using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Template.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                new User { Id = Guid.NewGuid(), Name = "User Default", Email = "userdefault@template.com" });
            return builder;
        }
    }
}
