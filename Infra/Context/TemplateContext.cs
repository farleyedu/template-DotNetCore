using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Data.Extensions;
using Template.Data.Mappings;

namespace Template.Data.Context
{
    public class TemplateContext: DbContext
    {
        public TemplateContext(DbContextOptions<TemplateContext> option) 
            : base(option) { }

        #region "DbSets"
        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMp());

            ModelBuilderExtensions.SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }


    }
}
